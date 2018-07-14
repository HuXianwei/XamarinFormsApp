
using System;
using System.Collections.Generic;
using System.Text;
using XamarinFormsApp.Models;

namespace XamarinFormsApp.Models
{
    public class ProductInfo
    {
        /// <summary>
		/// id
		/// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 所属类目id
        /// </summary>
        public long CategoryId { get; set; }
        /// <summary>
        /// 所属区域id
        /// </summary>
        public long AreaId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 商品副标题
        /// </summary>
        public string Subhead { get; set; }
        /// <summary>
        /// 商品标签
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// 商品详情
        /// </summary>
        public string Detail { get; set; }
        /// <summary>
        /// 是否保修
        /// </summary>
        public bool IsRepair { get; set; }
        /// <summary>
        /// 是否开具发票
        /// </summary>
        public bool IsInvoice { get; set; }
        /// <summary>
        /// 是否包换
        /// </summary>
        public bool IsReplacement { get; set; }
        /// <summary>
        /// 订单交易次数
        /// </summary>
        public int TradesNum { get; set; }
        /// <summary>
        /// 销售数量
        /// </summary>
        public int SalesNum { get; set; }
        /// <summary>
        /// 商品总数量（各渠道数量总和）
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// 开售时间
        /// </summary>
        public DateTime StartSaleDatetime { get; set; }
        /// <summary>
        /// 停售时间
        /// </summary>
        public DateTime EndSaleDatetime { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// 删除时间
        /// </summary>
        public DateTime DeletedDateTime { get; set; }
        /// <summary>
        /// 是否已经删除
        /// </summary>
        public bool IsDel { get; set; }

        /// <summary>
        /// 外部id
        /// </summary>
        public long ExtId { get; set; }

        /// <summary>
        /// 所属类目 最高4级
        /// </summary>
        public List<ProductCategoryInfo> Categories { get; set; }
        /// <summary>
        /// 商品分类
        /// </summary>
        public ProductGroupInMallInfo Groups { get; set; }
        /// <summary>
        /// 商品属性
        /// </summary>
        public List<PropertiesInProductInfo> Properties { get; set; }

        /// <summary>
        /// 图片信息
        /// </summary>
        public List<ImgsInProductInfo> Imgs { get; set; }
        /// <summary>
        /// 对应的sku信息
        /// </summary>
        public List<SkuInfo> Skus { get; set; }

        /// <summary>
        /// 组合商品中sku信息
        /// </summary>
        public List<SkuInPackageInfo> Package { get; set; }

        /// <summary>
        /// 商品状态（新建、上架、下架）
        /// </summary>
        public List<ProductStatusInSaleInfo> Statuses { get; set; }
    }
}
