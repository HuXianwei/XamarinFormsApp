using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsApp.Enums
{
    public enum MallType
    {
        /// <summary>
        /// 分销商城
        /// </summary>
        NormalMall = 1,
        /// <summary>
        /// 积分商城
        /// </summary>
        CreditMall = 2
    }

    public class NowMallType
    {
        public static MallType Type { get; set; } = MallType.NormalMall;
    }
}
