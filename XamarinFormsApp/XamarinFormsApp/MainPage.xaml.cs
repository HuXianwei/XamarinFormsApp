using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFormsApp.Models;

namespace XamarinFormsApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            ListView.ItemsSource = new List<ProductAllInfoModel>
            {
                new ProductAllInfoModel
                {
                    ProductInfo = new ProductInfo { Name = "乐虎380ml[饮料]", Subhead = "15瓶/件fdsafffffffffffffffffffffffffffffffffffffffffffffffffffffffff", Detail = "￥48.00" },
                    HistoryBuyCountList = new List<HistoryBuyCountModel>
                    {
                        new HistoryBuyCountModel { SkuId = 1, HistoryBuyCount = 10 }
                    }
                }
            };
        }
	}
}
