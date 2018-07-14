using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsApp.Enums
{
    /// <summary>
    /// 货架数据类型枚举
    /// </summary>
    public enum ShelfDataType
    {
        /// <summary>
        /// 通栏货架
        /// </summary>
        NormalShelf = 1,
        /// <summary>
        /// 通栏商品
        /// </summary>
        NormalProduct = 2,
        /// <summary>
        /// 通栏分类
        /// </summary>
        NormalGroup = 3,
        /// <summary>
        /// 两分栏
        /// </summary>
        Dichotomy = 4,
        /// <summary>
        /// 多分栏货架
        /// </summary>
        PolychotomyShelf = 5,
        /// <summary>
        /// 多分栏商品
        /// </summary>
        PolychotomyProduct = 6,
        /// <summary>
        /// 多分栏分类
        /// </summary>
        PolychotomyGroup = 7,
        /// <summary>
        /// 左右栏
        /// </summary>
        LeftRight = 8,
        /// <summary>
        /// 上下栏
        /// </summary>
        UpDown = 9,
        /// <summary>
        /// 滑动栏货架
        /// </summary>
        RollShelf = 10,
        /// <summary>
        /// 滑动栏商品
        /// </summary>
        RollProduct = 11,
        /// <summary>
        /// 滑动栏分组
        /// </summary>
        RollGroup = 12,
        /// <summary>
        /// 源代码
        /// </summary>
        SourceCode = 13,
        /// <summary>
        /// 文字
        /// </summary>
        Writing = 14,
        /// <summary>
        /// 图片
        /// </summary>
        Image = 15,
        /// <summary>
        /// 商品
        /// </summary>
        Product = 16,
        /// <summary>
        /// 搜索栏
        /// </summary>
        Search = 17,
        /// <summary>
        /// 类目栏
        /// </summary>
        Category = 18
    }
}
