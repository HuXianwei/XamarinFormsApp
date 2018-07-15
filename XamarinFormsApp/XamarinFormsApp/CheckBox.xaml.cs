using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsApp.Binders;

namespace XamarinFormsApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CheckBox : ContentView
	{
        /// <summary>
        /// 选中事件
        /// </summary>
        public event EventHandler CheckChanged;

        /// <summary>
        /// 是否选中,默认未选中
        /// </summary>
        public static readonly BindableProperty CheckedProperty =
            BindableProperty.Create("Checked",
                typeof(bool),
                typeof(CheckBox),
                false,
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: CheckedChanged
                );


        /// <summary>
        /// 是否选中, 默认未选中
        /// </summary>
        public bool Checked
        {
            get
            {
                return (bool)this.GetValue(CheckedProperty);
            }
            set
            {
                this.SetValue(CheckedProperty, value);
            }
        }

        private static void CheckedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var chk = (CheckBox)bindable;
            var source = chk.Checked ? chk.OnImg : chk.OffImg;
            chk.Icon.Source = source;// new BytesImageSource(datas);
        }


        #region IsShowLabel
        /// <summary>
        /// 是否显示标签文本,默认不显示
        /// </summary>
        public static readonly BindableProperty ShowLabelProperty =
            BindableProperty.Create("ShowLabel",
                typeof(bool),
                typeof(CheckBox),
                false
                );

        /// <summary>
        /// 是否显示标签文本,默认不显示
        /// </summary>
        public bool ShowLabel
        {
            get
            {
                return (bool)this.GetValue(ShowLabelProperty);
            }
            set
            {
                this.SetValue(ShowLabelProperty, value);
            }
        }

        #endregion

        #region Text
        /// <summary>
        /// 标签文本
        /// </summary>
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create("Text",
                typeof(string),
                typeof(CheckBox),
                null,
                defaultBindingMode: BindingMode.TwoWay
                );

        /// <summary>
        /// 标签文本
        /// </summary>
        public string Text
        {
            get
            {
                return (string)this.GetValue(TextProperty);
            }
            set
            {
                this.SetValue(TextProperty, value);
            }
        }
        #endregion

        #region Size
        /// <summary>
        /// 选择框大小, 默认25, 只控制选择框, 对文本不起作用
        /// </summary>
        public static readonly BindableProperty SizeProperty =
            BindableProperty.Create("Size",
                                    typeof(double),
                                    typeof(CheckBox),
                                    25D,
                                    propertyChanged: IconSizeChanged);

        /// <summary>
        /// 选择框大小, 默认25, 只控制选择框, 对文本不起作用
        /// </summary>
        public double Size
        {
            get
            {
                return (double)this.GetValue(SizeProperty);
            }
            set
            {
                this.SetValue(SizeProperty, value);
            }
        }

        private static void IconSizeChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var chk = (CheckBox)bindable;
            chk.Icon.WidthRequest = chk.Icon.HeightRequest = (double)newValue;

        }
        #endregion

        #region CheckChangedCmd
        /// <summary>
        /// 选中状态变化时触发的命令, 带一个 bool 参数
        /// </summary>
        public static readonly BindableProperty CheckChangedCmdProperty =
            BindableProperty.Create("CheckChangedCmd",
                typeof(ICommand),
                typeof(CheckBox)
                );

        /// <summary>
        /// 选中状态变化时触发的命令, 带一个 bool 参数
        /// </summary>
        public ICommand CheckChangedCmd
        {
            get
            {
                return (ICommand)this.GetValue(CheckChangedCmdProperty);
            }
            set
            {
                this.SetValue(CheckChangedCmdProperty, value);
            }
        }
        #endregion

        #region ImgSource
        public static readonly BindableProperty OnImgProperty =
            BindableProperty.Create("OnImg",
                typeof(ImageSource),
                typeof(CheckBox),
                ImageSource.FromResource("XamarinFormsApp.Resources.Checkbox-Checked.png", IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly),
                propertyChanged: ImgSourceChanged
                );

        public ImageSource OnImg
        {
            get
            {
                return (ImageSource)this.GetValue(OnImgProperty);
            }
            set
            {
                this.SetValue(OnImgProperty, value);
            }
        }

        public static readonly BindableProperty OffImgProperty =
            BindableProperty.Create("OffImg",
                typeof(ImageSource),
                typeof(CheckBox),
                ImageSource.FromResource("XamarinFormsApp.Resources.Checkbox-Unchecked.png", IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly),
                propertyChanged: ImgSourceChanged
                );

        public ImageSource OffImg
        {
            get
            {
                return (ImageSource)this.GetValue(OffImgProperty);
            }
            set
            {
                this.SetValue(OffImgProperty, value);
            }
        }

        private static void ImgSourceChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var chk = (CheckBox)bindable;
            chk.UpdateImageSource(chk.OnImg, chk.OffImg);
        }

        private void UpdateImageSource(ImageSource on, ImageSource off)
        {
            this.Icon.Source = this.Checked ? on : off;
        }

        private readonly Grid Grid;
        private readonly Label Label;
        private readonly Image Icon;
        #endregion

        /// <summary>
        /// 内部使用点击命令
        /// </summary>
        private ICommand TapCmd { get; }

        //public static ImageSource DefaultCheckedImg1 {
        //    get {
        //        return DefaultCheckedImg;
        //    }
        //}

        public CheckBox()
        {
            this.TapCmd = new Command(() => {
                this.Checked = !this.Checked;

                if (this.CheckChanged != null)
                    this.CheckChanged.Invoke(this, new EventArgs());

                if (this.CheckChangedCmd != null && this.CheckChangedCmd.CanExecute(this.Checked))
                    this.CheckChangedCmd.Execute(this.Checked);
            });

            var cols = new ColumnDefinitionCollection();
            cols.Add(new ColumnDefinition() { Width = GridLength.Auto });
            cols.Add(new ColumnDefinition() { Width = GridLength.Auto });
            this.Grid = new Grid()
            {
                ColumnDefinitions = cols,
            };

            //绑定内部Tap 命令
            TapBinder.SetCmd(this.Grid, this.TapCmd);

            this.Content = this.Grid;

            this.Label = new Label()
            {
                BindingContext = this,
                VerticalTextAlignment = TextAlignment.Center
            };
            this.Label.SetBinding(Label.TextProperty, "Text");
            this.Label.SetBinding(Label.IsVisibleProperty, "ShowLabel");
            this.Label.SetValue(Grid.ColumnProperty, 1);

            this.Grid.Children.Add(this.Label);

            this.Icon = new Image()
            {
                WidthRequest = this.Size,
                HeightRequest = this.Size,
                Source = this.OffImg
            };
            this.Icon.SetValue(Grid.ColumnProperty, 0);
            this.Grid.Children.Add(this.Icon);
        }
    }
}