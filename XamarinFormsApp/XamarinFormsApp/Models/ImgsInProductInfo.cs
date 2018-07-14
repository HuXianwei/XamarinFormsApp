
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsApp.Models
{
    /// <summary>
    /// 商品图片信息
    /// </summary>
    public class ImgsInProductInfo
    {
        /// <summary>
        /// 图片id
        /// </summary>
        public long ImgId { get; set; }

        /// <summary>
        /// 图片类型
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        public string Url { get; set; }
    }
}
