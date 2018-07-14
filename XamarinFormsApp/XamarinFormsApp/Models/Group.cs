using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsApp.Models
{
    public class Group
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
        /// 父级分类ID（一级分类的父级分类ID默认为0）
        /// </summary>
        public long ParentId { get; set; }

        /// <summary>
        /// 图片ID
        /// </summary>
        public long ImgId { get; set; }

        /// <summary>
        /// 分类名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 商城类型（1.分销商城；2.积分商城）
        /// </summary>
        public int MallType { get; set; }

        /// <summary>
        /// 分类类型（1.系统分类；2.自建分类）
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 序号，用于排序
        /// </summary>
        public int Queue { get; set; }

        /// <summary>
        /// 是否删除（0.否；1.是）
        /// </summary>
        public bool IsDel { get; set; }
    }
}
