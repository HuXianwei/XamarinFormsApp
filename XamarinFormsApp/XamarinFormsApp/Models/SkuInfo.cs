
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsApp.Models
{
    /// <summary>
    /// sku信息
    /// </summary>
    public class SkuInfo
    {
        /// <summary>
		/// id
		/// </summary>
        public long Id { get; set; }
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
        /// 重量
        /// </summary>
        public float Weight { get; set; }
        /// <summary>
        /// 市场价
        /// </summary>
        public decimal MarketPrice { get; set; }
        /// <summary>
        /// 建议零售价
        /// </summary>
        public decimal RetailPrice { get; set; }

        /// <summary>
        /// 采购价
        /// </summary>
        public decimal PurchasePrice { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public long ImgId { get; set; }

        /// <summary>
        /// 物流系数
        /// </summary>
        public float LogisticsCoeffi { get; set; }
        /// <summary>
        /// sku总数量 (歌渠道数量总和)
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// 是否赠品
        /// </summary>
        public bool IsGift { get; set; }

        /// <summary>
        /// 销售是否可见
        /// </summary>
        public bool Disabled { get; set; }

        /// <summary>
        /// 是否已经删除
        /// </summary>
        public bool IsDel { get; set; }

        /// <summary>
        /// 商品单位
        /// </summary>
        public ProductUnitQuantityInfo Unit { get; set; }
        /// <summary>
        /// sku的规格
        /// </summary>
        public List<SpecificationsInSkuInfo> Specifications { get; set; }

        /// <summary>
        /// 定价信息
        /// </summary>
        public List<ProductSkuPricingInfo> ProductSkuPricings { get; set; }

        public List<PromotionItemGeneralInfo> Promotions { get; set; }

        /// <summary>
        /// 起购数量(打印用)
        /// </summary>
        public int MiniOrderQuantity { get; set; }
        /// <summary>
        /// 销售价(打印用)
        /// </summary>
        public decimal Price { get; set; }
    }
}
