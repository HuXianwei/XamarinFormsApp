using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsApp.Models
{
    public class Shelf
    {
        /// <summary>
        /// 主键
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 区域ID
        /// </summary>
        public long AreaId { get; set; }

        /// <summary>
        /// 渠道ID
        /// </summary>
        public long ChannleId { get; set; }

        /// <summary>
        /// 主图ID
        /// </summary>
        public long BannerId { get; set; }

        /// <summary>
        /// 商城类型（1.分销商城；2.积分商城）
        /// </summary>
        public int MallType { get; set; }

        /// <summary>
        /// 货架名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 货架类型（1.首页；2.自定义；3.商品详情展示货架）
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 是否默认（0.否；1.是）
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// 是否删除（0.否；1.是）
        /// </summary>
        public bool IsDel { get; set; }
    }
}
