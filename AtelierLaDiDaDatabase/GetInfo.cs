using AtelierLaDiDaDatabase.Data;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AtelierLaDiDaDatabase
{
    public class Parameters
    {
        internal static string DBPath = "";

        public static void SetDBPath(string path) => DBPath = "Data Source=" + path;
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
            AtelierLaDiDaDbContext db = new AtelierLaDiDaDbContext();
            List<IAtelier> res = seriesName switch
            {
                EnumSeriesName.A11_Atelier_Rorona => db.Rorona.Select(r => (IAtelier)r).ToList(),
                EnumSeriesName.A12_Atelier_Totori => db.Totori.Select(t => (IAtelier)t).ToList(),
                EnumSeriesName.A14_Atelier_Ayesha => db.Ayesha.Select(a => (IAtelier)a).ToList(),
                EnumSeriesName.A15_Atelier_EschaLogy => db.EschaLogy.Select(e => (IAtelier)e).ToList(),
                EnumSeriesName.A17_Atelier_Sophie => db.Sophie.Select(s => (IAtelier)s).ToList(),
                EnumSeriesName.A18_Atelier_Firis => db.Firis.Select(f => (IAtelier)f).ToList(),
                EnumSeriesName.A19_Atelier_LydieSuelle => db.LydieSuelle.Select(l => (IAtelier)l).ToList(),
                EnumSeriesName.A20_Atelier_Lulua => db.Lulua.Select(l => (IAtelier)l).ToList(),
                EnumSeriesName.A21_Atelier_Ryza => db.Ryza.Select(r => (IAtelier)r).ToList(),
                _ => new List<IAtelier>(),
            };
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
        /// アーシャのアトリエ 〜黄昏の大地の錬金術士〜
        /// </summary>
        A14_Atelier_Ayesha = 14,

        /// <summary>
        /// エスカ&ロジーのアトリエ 〜黄昏の空の錬金術士〜
        /// </summary>
        A15_Atelier_EschaLogy = 15,

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
        A19_Atelier_LydieSuelle = 19,

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