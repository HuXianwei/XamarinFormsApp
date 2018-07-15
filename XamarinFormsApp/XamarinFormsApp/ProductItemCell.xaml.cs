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
            BindingContext = this;
        }

        public static readonly BindableProperty ProductInfoProperty =
            BindableProperty.Create("ProductInfo", typeof(ProductInfo), typeof(ProductItemCell), new ProductInfo());

        public static readonly BindableProperty HistoryBuyCountListProperty =
            BindableProperty.Create("HistoryBuyCountList", typeof(List<HistoryBuyCountModel>), typeof(ProductItemCell), new List<HistoryBuyCountModel>());

        public ProductInfo ProductInfo
        {
            get { return (ProductInfo)GetValue(ProductInfoProperty); }
            set { SetValue(ProductInfoProperty, value); }
        }

        public List<HistoryBuyCountModel> HistoryBuyCountList
        {
            get { return (List<HistoryBuyCountModel>)GetValue(HistoryBuyCountListProperty); }
            set { SetValue(HistoryBuyCountListProperty, value); }
        }
    }
}