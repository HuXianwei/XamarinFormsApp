
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsApp.Models
{
    /// <summary>
    /// 商品中定义的属性
    /// </summary>
    public class PropertiesInProductInfo
    {
        /// <summary>
        /// 属性id
        /// </summary>
        public long PropertyId { get; set; }

        /// <summary>
        /// 属性名称
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// 属性值id
        /// </summary>
        public long PropertyValueId { get; set; }
        /// <summary>
        /// 属性值名称
        /// </summary>
        public string PropertyValueName { get; set; }
    }
}
