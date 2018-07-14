
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsApp.Models
{
    /// <summary>
    /// 商品销售状态
    /// </summary>
    public class ProductStatusInSaleInfo
    {
        /// <summary>
        /// 商品id
        /// </summary>
        public long ProductId { get; set; }

        /// <summary>
		/// 客户渠道
		/// </summary>
        public long ChannelId { get; set; }

        /// <summary>
        /// 渠道标题
        /// </summary>
        public string ChannelName { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 渠道下的副标题
        /// </summary>
        //public string Subhead { get; set; }

        /// <summary>
        /// 渠道下的可售数量
        /// </summary>
        public int ValidQuantity { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 上架时间
        /// </summary>
        public DateTime InSalesDatetime { get; set; }
        /// <summary>
        /// 下架时间
        /// </summary>
        public DateTime HaltSalesDatetime { get; set; }



    }
}
