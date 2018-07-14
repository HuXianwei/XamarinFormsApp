
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsApp.Models
{
    /// <summary>
    /// 商品促销细项总览
    /// </summary>
    public class PromotionItemGeneralInfo
    {
        /// <summary>
        /// 促销细项id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 描述信息
        /// </summary>
        public string Desc { get; set; }
        /// <summary>
        /// 促销类型
        /// </summary>
        public int PromotionType { get; set; }
    }
}
