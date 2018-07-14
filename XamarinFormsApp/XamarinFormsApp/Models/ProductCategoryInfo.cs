
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsApp.Models
{
    /// <summary>
    /// 商品类目信息
    /// </summary>
    public class ProductCategoryInfo
    {
        /// <summary>
        /// id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 上级id
        /// </summary>
        public long Pid { get; set; }
        /// <summary>
        /// 外部id
        /// </summary>
        public string ExtId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 等级
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// 标记终结点
        /// </summary>
        public bool IsLeaf { get; set; }

        /// <summary>
        /// 是否同步完成
        /// </summary>
        public bool IsSyncomplete { get; set; }
    }
}
