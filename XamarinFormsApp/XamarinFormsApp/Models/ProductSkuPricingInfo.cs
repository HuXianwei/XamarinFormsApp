
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsApp.Models
{
    /// <summary>
    /// 商品定价信息
    /// </summary>
    public class ProductSkuPricingInfo
    {
        /// <summary>
        /// 定价表对应id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        public long ProductId { get; set; }

        /// <summary>
        /// skuid
        /// </summary>
        public long SkuId { get; set; }

        /// <summary>
		/// 渠道id
		/// </summary>
        public long ChannelId { get; set; }

        /// <summary>
        /// 购买时需要消费的积分
        /// </summary>
        public int CostPoints { get; set; }
        /// <summary>
        /// 购买时可获得到的积分
        /// </summary>
        public int GetPoints { get; set; }
        /// <summary>
        /// 销售价格
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 限购量
        /// </summary>
        public int LimitOrderQuantity { get; set; }
        /// <summary>
        /// 限购时效
        /// </summary>
        public int LimitOrderInterval { get; set; }
        /// <summary>
        /// 起购量
        /// </summary>
        public int MiniOrderQuantity { get; set; }
        /// <summary>
        /// 可售量
        /// </summary>
        public int ValidQuantity { get; set; }

        /// <summary>
        /// 配送区域下的可售数量
        /// </summary>
        public int TransportionAreaValidQuantity { get; set; }

        /// <summary>
        /// 是否联动到WMS
        /// </summary>
        public bool IsActionWms { get; set; }

        /// <summary>
        /// 定价人
        /// </summary>
        public string PricingedMan { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Created { get; set; }

    }
}
