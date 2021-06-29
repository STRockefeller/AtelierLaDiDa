using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtelierLaDiDaDatabase;

namespace AtelierLaDiDaDataAdapter
{
    public class DataAdapter
    {
        static EnumSeriesName seriesName;
        /// <summary>
        /// 設定資料庫路徑
        /// </summary>
        /// <param name="path"></param>
        public static void SetDBPath(string path) => Parameters.SetDBPath(path);
        /// <summary>
        /// 設定系列名
        /// </summary>
        /// <param name="name"></param>
        public static void SetSeriesName(string name)
        {
            switch (name)
            {
                case "A11":
                    seriesName = EnumSeriesName.A11_Atelier_Rorona;
                    break;

                case "A12":
                    seriesName = EnumSeriesName.A12_Atelier_Totori;
                    break;

                case "A17":
                    seriesName = EnumSeriesName.A17_Atelier_Sophie;
                    break;

                case "A20":
                    seriesName = EnumSeriesName.A20_Atelier_Lulua;
                    break;

                case "A21":
                    seriesName = EnumSeriesName.A21_Atelier_Ryza;
                    break;

                default:
                    break;
                    //to update
            }
        }
        /// <summary>
        /// 取得物品名稱清單
        /// </summary>
        /// <returns></returns>
        public static string[] GetItemNames() => GetInfo.GetItemInfo(seriesName).Select(item => item.Name).ToArray();
    }
}
