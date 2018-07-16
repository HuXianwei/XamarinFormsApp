using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BoxLabelView : ContentView
	{
		public BoxLabelView ()
		{
			InitializeComponent ();
            BindingContext = this;
        }

        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(BoxLabelView), default(string));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
    }
}