
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsApp.Models
{
    /// <summary>
    /// sku中的规格信息
    /// </summary>
    public class SpecificationsInSkuInfo
    {
        /// <summary>
        /// 规格id
        /// </summary>
        public long SpecificationId { get; set; }
        /// <summary>
        /// 规格名称
        /// </summary>
        public string SpecificationName { get; set; }
        /// <summary>
        /// 规格值id
        /// </summary>
        public long SpecificationValueId { get; set; }
        /// <summary>
        /// 规格值名称
        /// </summary>
        public string SpecificationValueName { get; set; }
    }
}
