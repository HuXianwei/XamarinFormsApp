
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsApp.Models
{
    /// <summary>
    /// 在组合商品中的sku信息
    /// </summary>
    public class SkuInPackageInfo
    {
        /// <summary>
        /// SkuId
        /// </summary>
        public long SkuId { get; set; }
        /// <summary>
        /// 所属商品id
        /// </summary>
        public long Pid { get; set; }

        /// <summary>
        /// 所属商品名称
        /// </summary>
        public string Pname { get; set; }
        /// <summary>
        /// sku名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 商品码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 条码
        /// </summary>
        public string Barcode { get; set; }
        /// <summary>
        /// sku总数量 (歌渠道数量总和)
        /// </summary>
        public int Quantity { get; set; }
    }
}
