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
                    ProductInfo = new ProductInfo {
                        Name = "乐虎380ml[饮料]", Subhead = "15瓶/件", Detail = "￥48.00",
                        Skus = new List<SkuInfo> {
                            new SkuInfo { Name = "青柠味", Quantity = 100, Price = 45.7M, MiniOrderQuantity = 3 },
                            new SkuInfo { Name = "芒果味", Quantity = 20, Price = 4.2M, MiniOrderQuantity = 2 },
                        }
                    },
                    HistoryBuyCountList = new List<HistoryBuyCountModel>
                    {
                        new HistoryBuyCountModel { SkuId = 1, HistoryBuyCount = 10 }
                    }
                },
                new ProductAllInfoModel
                {
                    ProductInfo = new ProductInfo {
                        Name = "乐虎380ml[饮料]", Subhead = "15瓶/件", Detail = "￥48.00",
                        Skus = new List<SkuInfo> {
                            new SkuInfo { Name = "青柠味", Quantity = 100, Price = 45.7M, MiniOrderQuantity = 3 },
                            new SkuInfo { Name = "芒果味", Quantity = 20, Price = 4.2M, MiniOrderQuantity = 2 },
                            new SkuInfo { Name = "西瓜味", Quantity = 3000, Price = 80M, MiniOrderQuantity = 1 },
                        }
                    },
                    HistoryBuyCountList = new List<HistoryBuyCountModel>
                    {
                        new HistoryBuyCountModel { SkuId = 1, HistoryBuyCount = 10 }
                    }
                }
            };
        }
	}
}
