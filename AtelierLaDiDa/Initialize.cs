using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtelierLaDiDa
{
    /// <summary>
    /// 初始化類別
    /// </summary>
    public class Initialize
    {
        /// <summary>
        /// 建構式
        /// </summary>
        /// <param name="seriesName"></param>
        public Initialize(EnumSeriesName seriesName)
        {
            switch(seriesName)
            {
                case EnumSeriesName.A17_Atelier_Sophie:
                    break;
                case EnumSeriesName.A21_Atelier_Ryza:
                    break;
                default:
                    break;
            }
        }
    }
}