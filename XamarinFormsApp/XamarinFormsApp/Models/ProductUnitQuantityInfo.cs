
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsApp.Models
{
    /// <summary>
    /// 商品单位规格数量
    /// </summary>
    public class ProductUnitQuantityInfo
    {
        public long Id { get; set; }

        /// <summary>
        /// 单位规格id
        /// </summary>
        public long SpvId { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Name { get; set; }

        /// <summary>
		/// 单位数量
		/// </summary>
        public int UnitQuantity { get; set; }
    }
}
