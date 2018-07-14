using System;
using System.Collections.Generic;
using System.Text;
using XamarinFormsApp.Enums;

namespace XamarinFormsApp.Models
{
    public class ShelfDataModel
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 货架ID
        /// </summary>
        public long ShelfId { get; set; }

        /// <summary>
        /// 外键ID（自定义货架ID、商品ID、分类ID）
        /// </summary>
        public long ForeignId { get; set; }

        /// <summary>
        /// 替换的主图片ID或直接添加的图片ID
        /// </summary>
        public long ImgId { get; set; }

        /// <summary>
        /// 货架的数据类型（SheltDataType枚举）
        /// </summary>
        public ShelfDataType Type { get; set; }

        /// <summary>
        /// 两分栏的商品数量
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 源代码内容或商品详情展示货架文字内容
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// 序号，用于排序
        /// </summary>
        public int Queue { get; set; }

        /**************表外字段***************/
        /// <summary>
        /// 商品详细信息
        /// </summary>
        public ProductInfo Product { get; set; }

        /// <summary>
        /// 分类信息
        /// </summary>
        public Group Group { get; set; }

        /// <summary>
        /// 货架信息
        /// </summary>
        public Shelf Shelf { get; set; }
    }
}
