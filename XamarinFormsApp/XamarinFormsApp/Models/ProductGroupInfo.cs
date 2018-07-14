
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsApp.Models
{
    /// <summary>
    /// 商品分类
    /// </summary>
    public class ProductGroupInfo
    {
        /// <summary>
        /// 分类id
        /// </summary>
        public long GroupId { get; set; }
        /// <summary>
        /// 分类名称
        /// </summary>
        public string GroupName { get; set; }
        /// <summary>
        /// 子分类
        /// </summary>
        public List<ProductGroupInfo> Children { get; set; }
    }
}
