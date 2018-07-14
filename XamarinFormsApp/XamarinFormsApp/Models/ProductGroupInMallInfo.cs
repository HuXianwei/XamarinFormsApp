
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsApp.Models
{
    public class ProductGroupInMallInfo
    {
        /// <summary>
        /// 积分商城分类
        /// </summary>
        public List<ProductGroupInfo> PointsMallGroups { get; set; }

        /// <summary>
        /// 分销商城
        /// </summary>
        public List<ProductGroupInfo> DistributionMallGroups { get; set; }

        public ProductGroupInMallInfo()
        {
            PointsMallGroups = new List<ProductGroupInfo>();
            DistributionMallGroups = new List<ProductGroupInfo>();
        }
    }
}
