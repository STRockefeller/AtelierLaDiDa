using System.Data;
using AtelierLaDiDaDatabase.Data;
using System.Linq;
using System.Collections.Generic;

namespace AtelierLaDiDaDatabase
{
    public class Parameters
    {
        internal static string DBPath = "";
        public static void SetDBPath(string path) => DBPath = path;
    }
    /// <summary>
    /// 對外提供資料庫資訊的類別
    /// </summary>
    public class GetInfo
    {
        /// <summary>
        /// 取得對應資料內容
        /// </summary>
        /// <param name="seriesName"></param>
        /// <returns></returns>
        public static List<IAtelier> GetItemInfo(EnumSeriesName seriesName)
        {
            List<IAtelier> res;
            AtelierLaDiDaDbContext db = new AtelierLaDiDaDbContext();
            switch (seriesName)
            {
                case EnumSeriesName.A11_Atelier_Rorona:
                    res = db.Rorona.Select(r => (IAtelier)r).ToList();
                    break;
                case EnumSeriesName.A12_Atelier_Totori:
                    res = db.Totori.Select(t => (IAtelier)t).ToList();
                    break;
                case EnumSeriesName.A17_Atelier_Sophie:
                    res = db.Sophie.Select(s => (IAtelier)s).ToList();
                    break;
                case EnumSeriesName.A20_Atelier_Lulua:
                    res = db.Lulua.Select(l => (IAtelier)l).ToList();
                    break;
                case EnumSeriesName.A21_Atelier_Ryza:
                    res = db.Ryza.Select(r => (IAtelier)r).ToList();
                    break;
                default:
                    res = new List<IAtelier>();
                    //error log
                    break;
            }
            return res;
        }
        /// <summary>
        /// 取得所有資料
        /// </summary>
        /// <returns></returns>
        public static AtelierLaDiDaDbContext GetAllData() => new AtelierLaDiDaDbContext();
    }

    /// <summary>
    /// 系列名列舉
    /// </summary>
    public enum EnumSeriesName
    {
        /// <summary>
        /// ロロナのアトリエ～アーランドの錬金術士～
        /// </summary>
        A11_Atelier_Rorona = 11,

        /// <summary>
        /// トトリのアトリエ ～アーランドの錬金術士2～
        /// </summary>
        A12_Atelier_Totori = 12,

        /// <summary>
        /// ソフィーのアトリエ ～不思議な本の錬金術士～
        /// </summary>
        A17_Atelier_Sophie = 17,

        /// <summary>
        /// フィリスのアトリエ ～不思議な旅の錬金術士～
        /// </summary>
        A18_Atelier_Firis = 18,

        /// <summary>
        /// リディー＆スールのアトリエ ～不思議な絵画の錬金術士～
        /// </summary>
        A19_Atelier_Lydie_and_Suelle = 19,

        /// <summary>
        /// ルルアのアトリエ ～アーランドの錬金術士 4～
        /// </summary>
        A20_Atelier_Lulua = 20,

        /// <summary>
        /// ライザのアトリエ　常闇の女王と秘密の隠れ家
        /// </summary>
        A21_Atelier_Ryza = 21
    }
}