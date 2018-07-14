using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsApp.Models
{
    /// <summary>
    /// 商品所有信息模型（包含ProductInfo, 历史购买信息等）
    /// </summary>
    public class ProductAllInfoModel
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        public ProductInfo ProductInfo { get; set; }

        /// <summary>
        /// 历史购买数量
        /// </summary>
        public List<HistoryBuyCountModel> HistoryBuyCountList { get; set; }
    }

    /// <summary>
    /// 历史购买量集合
    /// </summary>
    public class HistoryBuyCountModel
    {
        /// <summary>
        /// skuId
        /// </summary>
        public long SkuId { get; set; }

        /// <summary>
        /// 历史购买数量
        /// </summary>
        public int HistoryBuyCount { get; set; }
    }
}
