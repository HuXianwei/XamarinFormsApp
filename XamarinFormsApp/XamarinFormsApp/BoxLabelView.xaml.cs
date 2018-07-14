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
		}

        public static readonly BindableProperty NameProperty =
            BindableProperty.Create("Name", typeof(string), typeof(BoxLabelView), "sku");

        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }
    }
}