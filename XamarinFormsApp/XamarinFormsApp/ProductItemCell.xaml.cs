using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsApp.Models;

namespace XamarinFormsApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProductItemCell : ViewCell
	{
       
		public ProductItemCell()
		{
			InitializeComponent ();
		}

        public static readonly BindableProperty ProductInfoProperty =
            BindableProperty.Create("ProductInfo", typeof(ProductInfo), typeof(ProductItemCell), new ProductInfo());

        public static readonly BindableProperty HistoryBuyCountModelProperty =
            BindableProperty.Create("HistoryBuyCountModel", typeof(HistoryBuyCountModel), typeof(ProductItemCell), new HistoryBuyCountModel());

        public ProductInfo ProductInfo
        {
            get { return (ProductInfo)GetValue(ProductInfoProperty); }
            set { SetValue(ProductInfoProperty, value); }
        }

        public HistoryBuyCountModel HistoryBuyCountModel
        {
            get { return (HistoryBuyCountModel)GetValue(HistoryBuyCountModelProperty); }
            set { SetValue(HistoryBuyCountModelProperty, value); }
        }
    }
}