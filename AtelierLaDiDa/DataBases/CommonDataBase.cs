using AtelierLaDiDa.DataBases.JP;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierLaDiDa.DataBases
{
    /// <summary>
    /// 共用資料庫類別
    /// </summary>
    public class CommonDataBase
    {
        /// <summary>
        /// 物品資料
        /// </summary>
        public List<CommonItemData> itemDatas = new List<CommonItemData>();
        /// <summary>
        /// 顯示語言
        /// </summary>
        private string language = "Traditional Chinese";
        /// <summary>
        /// 取得系列名
        /// </summary>
        public EnumSeriesName seriesName { get; set; }
        /// <summary>
        /// 建構式
        /// </summary>
        /// <param name="seriesName"></param>
        public CommonDataBase(EnumSeriesName seriesName)
        {
            this.seriesName = seriesName;
            connectToDB();
        }
        /// <summary>
        /// 建構式，含顯示語言
        /// </summary>
        /// <param name="seriesName"></param>
        /// <param name="language"></param>
        public CommonDataBase(EnumSeriesName seriesName, string language)
        {
            this.seriesName = seriesName;
            this.language = language;
            connectToDB();
        }
        /// <summary>
        /// 連線到對應的資料庫
        /// </summary>
        private void connectToDB()
        {
            itemDatas.Clear();
            switch (seriesName)
            {
                case EnumSeriesName.A11_Atelier_Rorona:

                    using (var db = new AtelierLaDiDaA11SqliteDB("A11DB"))
                    {
                        var query = db.Rorona.Where(item=>item.Name.Length>=1).Select(item => item);
                        foreach (Rorona roronaItem in query)
                        {
                            CommonItemData itemData = new CommonItemData();
                            itemData.Name = roronaItem.Name;
                            itemData.ID = Convert.ToInt32(roronaItem.No.TrimStart('0')) ;
                            itemData.Attribute.Add(roronaItem.Attribute1);
                            itemData.Attribute.Add(roronaItem.Attribute2);
                            itemData.Attribute.Add(roronaItem.Attribute3);
                            itemData.Attribute.Add(roronaItem.Attribute4);
                            itemData.Type.Add(roronaItem.Type1);
                            itemData.Type.Add(roronaItem.Type2);
                            itemData.Type.Add(roronaItem.Type3);
                            itemData.Type.Add(roronaItem.Type4);
                            itemData.Type.Add(roronaItem.Type5);
                            itemData.Type.Add(roronaItem.Type6);
                            itemData.Source.Add(roronaItem.Source1);
                            itemData.Source.Add(roronaItem.Source2);
                            itemData.Source.Add(roronaItem.Source3);
                            itemData.Source.Add(roronaItem.Source4);
                            itemData.JapaneseName = roronaItem.Japanese;
                            itemData.Attribute.RemoveAll(str => str == "");
                            itemData.Type.RemoveAll(str => str == "");
                            itemData.Source.RemoveAll(str => str == "");
                            itemDatas.Add(itemData);
                        }
                    }
                    break;
                case EnumSeriesName.A12_Atelier_Totori:

                    using (var db = new AtelierLaDiDaA12SqliteDB("A12DB"))
                    {
                        var query = db.Totori.Where(item => item.Name.Length >= 1).Select(item => item);
                        foreach (Totori totoriItem in query)
                        {
                            CommonItemData itemData = new CommonItemData();
                            itemData.Name = totoriItem.Name;
                            itemData.ID = Convert.ToInt32(totoriItem.No.TrimStart('0'));
                            itemData.Attribute.Add(totoriItem.Attribute1);
                            itemData.Attribute.Add(totoriItem.Attribute2);
                            itemData.Attribute.Add(totoriItem.Attribute3);
                            itemData.Attribute.Add(totoriItem.Attribute4);
                            itemData.Type.Add(totoriItem.Type1);
                            itemData.Type.Add(totoriItem.Type2);
                            itemData.Type.Add(totoriItem.Type3);
                            itemData.Type.Add(totoriItem.Type4);
                            itemData.Type.Add(totoriItem.Type5);
                            itemData.Type.Add(totoriItem.Type6);
                            itemData.Source.Add(totoriItem.Source1);
                            itemData.Source.Add(totoriItem.Source2);
                            itemData.Source.Add(totoriItem.Source3);
                            itemData.Source.Add(totoriItem.Source4);
                            itemData.JapaneseName = totoriItem.Japanese;
                            itemData.Attribute.RemoveAll(str => str == "");
                            itemData.Type.RemoveAll(str => str == "");
                            itemData.Source.RemoveAll(str => str == "");
                            itemDatas.Add(itemData);
                        }
                    }
                    break;
                case EnumSeriesName.A17_Atelier_Sophie:
                    if (language == "Japanese")
                    {
                        using (var db = new AtelierLaDiDaA17JPSqliteDB("A17DBJP"))
                        {
                            var query = db.Sophie.Select(item => item);
                            foreach (JP.Sophie sophieItem in query)
                            {
                                CommonItemData itemData = new CommonItemData();
                                itemData.Name = sophieItem.Name;
                                itemData.ID = Convert.ToInt32(sophieItem.No);
                                itemData.Attribute.Add(sophieItem.Attribute1);
                                itemData.Attribute.Add(sophieItem.Attribute2);
                                itemData.Attribute.Add(sophieItem.Attribute3);
                                itemData.Attribute.Add(sophieItem.Attribute4);
                                itemData.Attribute.Add(sophieItem.Attribute5);
                                itemData.Type.Add(sophieItem.Type1);
                                itemData.Type.Add(sophieItem.Type2);
                                itemData.Type.Add(sophieItem.Type3);
                                itemData.Type.Add(sophieItem.Type4);
                                itemData.Source.Add(sophieItem.Source1);
                                itemData.Source.Add(sophieItem.Source2);
                                itemData.Source.Add(sophieItem.Source3);
                                itemData.Source.Add(sophieItem.Source4);
                                itemData.Attribute.RemoveAll(str => str == "");
                                itemData.Type.RemoveAll(str => str == "");
                                itemData.Source.RemoveAll(str => str == "");
                                itemDatas.Add(itemData);
                            }
                        }
                    }
                    else
                    {
                        using (var db = new AtelierLaDiDaA17SqliteDB("A17DB"))
                        {
                            var query = db.Sophie.Select(item => item);
                            foreach (Sophie sophieItem in query)
                            {
                                CommonItemData itemData = new CommonItemData();
                                itemData.Name = sophieItem.Name;
                                itemData.ID = Convert.ToInt32(sophieItem.No);
                                itemData.Attribute.Add(sophieItem.Attribute1);
                                itemData.Attribute.Add(sophieItem.Attribute2);
                                itemData.Attribute.Add(sophieItem.Attribute3);
                                itemData.Attribute.Add(sophieItem.Attribute4);
                                itemData.Attribute.Add(sophieItem.Attribute5);
                                itemData.Type.Add(sophieItem.Type1);
                                itemData.Type.Add(sophieItem.Type2);
                                itemData.Type.Add(sophieItem.Type3);
                                itemData.Type.Add(sophieItem.Type4);
                                itemData.Source.Add(sophieItem.Source1);
                                itemData.Source.Add(sophieItem.Source2);
                                itemData.Source.Add(sophieItem.Source3);
                                itemData.Source.Add(sophieItem.Source4);
                                itemData.Attribute.RemoveAll(str => str == "");
                                itemData.Type.RemoveAll(str => str == "");
                                itemData.Source.RemoveAll(str => str == "");
                                itemDatas.Add(itemData);
                            }
                        }
                    }
                    break;
                case EnumSeriesName.A20_Atelier_Lulua:
                    using (var db = new AtelierLaDiDaA20SqliteDB("A20DB"))
                    {
                        var query = db.Lulua.Select(item => item);
                        foreach (Lulua luluaItem in query)
                        {
                            CommonItemData itemData = new CommonItemData();
                            itemData.Name = luluaItem.Name;
                            itemData.ID = Convert.ToInt32(luluaItem.No);
                            itemData.Attribute.Add(luluaItem.Attribute1);
                            itemData.Attribute.Add(luluaItem.Attribute2);
                            itemData.Attribute.Add(luluaItem.Attribute3);
                            itemData.Attribute.Add(luluaItem.Attribute4);
                            itemData.Type.Add(luluaItem.Type1);
                            itemData.Type.Add(luluaItem.Type2);
                            itemData.Type.Add(luluaItem.Type3);
                            itemData.Type.Add(luluaItem.Type4);
                            itemData.Type.Add(luluaItem.Type5);
                            itemData.Type.Add(luluaItem.Type6);
                            itemData.Source.Add(luluaItem.Source1);
                            itemData.Source.Add(luluaItem.Source2);
                            itemData.Source.Add(luluaItem.Source3);
                            itemData.Source.Add(luluaItem.Source4);
                            itemData.Attribute.RemoveAll(str => str == "");
                            itemData.Type.RemoveAll(str => str == "");
                            itemData.Source.RemoveAll(str => str == "");
                            itemDatas.Add(itemData);
                        }
                    }
                    break;
                case EnumSeriesName.A21_Atelier_Ryza:
                    using (var db = new AtelierLaDiDaA21SqliteDB("A21DB"))
                    {
                        var query = db.Ryza.Select(item => item);
                        foreach (Ryza ryzaItem in query)
                        {
                            CommonItemData itemData = new CommonItemData();
                            itemData.Name = ryzaItem.Name;
                            itemData.ID = Convert.ToInt32(ryzaItem.No);
                            itemData.Attribute.Add(ryzaItem.Attribute1);
                            itemData.Attribute.Add(ryzaItem.Attribute2);
                            itemData.Attribute.Add(ryzaItem.Attribute3);
                            itemData.Attribute.Add(ryzaItem.Attribute4);
                            itemData.Type.Add(ryzaItem.Type1);
                            itemData.Type.Add(ryzaItem.Type2);
                            itemData.Type.Add(ryzaItem.Type3);
                            itemData.Type.Add(ryzaItem.Type4);
                            itemData.Type.Add(ryzaItem.Type5);
                            itemData.Type.Add(ryzaItem.Type6);
                            itemData.Source.Add(ryzaItem.Source1);
                            itemData.Source.Add(ryzaItem.Source2);
                            itemData.Source.Add(ryzaItem.Source3);
                            itemData.Source.Add(ryzaItem.Source4);
                            itemData.Attribute.RemoveAll(str => str == "");
                            itemData.Type.RemoveAll(str => str == "");
                            itemData.Source.RemoveAll(str => str == "");
                            itemDatas.Add(itemData);
                        }
                    }
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 生成物品清單
        /// </summary>
        /// <returns>物品清單</returns>
        public List<string> generateObjectList() => itemDatas.Select(item => item.Name).ToList();
        /// <summary>
        /// 生成日文物品清單
        /// </summary>
        /// <returns>物品清單</returns>
        public List<string> generateJapaneseObjectList() => itemDatas.Select(item => item.JapaneseName).ToList();
        /// <summary>
        /// 生成物品類型清單
        /// </summary>
        /// <returns>物品類型清單</returns>
        public List<string> generatrTypeList()
        {
            List<string> returnValue = new List<string>();
            foreach (CommonItemData item in itemDatas)
                returnValue.AddRange(item.Type.Where(str => str != null));
            return returnValue.Distinct().ToList();
        }
        /// <summary>
        /// 顯示物品詳細資料
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns></returns>
        public string showItemDetail(string itemName)
        {
            CommonItemData target = itemDatas.Where(item => item.Name == itemName).FirstOrDefault();
            string returnValue = "";
            returnValue += $"Item Detail\r\n";
            returnValue += $"ID:{target.ID}\r\n";
            returnValue += $"Name:{target.Name}\r\n";
            foreach (string a in target.Attribute)
                if (a != null)
                    returnValue += $"Attribute:{a}\r\n";
            foreach (string a in target.Type)
                if (a != null)
                    returnValue += $"Type:{a}\r\n";
            foreach (string a in target.Source)
                if (a != null)
                    returnValue += $"Source:{a}\r\n";
            return returnValue;
        }
        /// <summary>
        /// 特性轉移路徑查詢
        /// </summary>
        /// <param name="sourceItem"></param>
        /// <param name="destinationItem"></param>
        public string search(string sourceItem, string destinationItem)
        {
            CommonItemData sourceItemData = itemDatas.Single(item => item.Name == sourceItem);
            CommonItemData destinationItemData = itemDatas.Single(item => item.Name == destinationItem);
            string returnValue = "";
            #region 1st Level
            bool firstLevelMatchName = destinationItemData.Source.Any(source => source == sourceItemData.Name);
            bool firstLevelMatchType = destinationItemData.Source.Any(source => source != null && sourceItemData.Type.Contains(source));
            if (firstLevelMatchName || firstLevelMatchType)
                returnValue += $"First Level:\r\n{sourceItem}-->{destinationItem}";
            #endregion
            #region 2nd Level
            var secondLevelItem = itemDatas.Where(item =>
            {
                if (destinationItemData.Source.Contains(item.Name))
                    return true;
                foreach (string source in destinationItemData.Source)
                    if (source != null && item.Type.Contains(source))
                        return true;
                return false;
            });
            foreach (CommonItemData itemData in secondLevelItem)
            {
                bool secondLevelMatchName = itemData.Source.Any(source => source == sourceItemData.Name);
                bool secondLevelMatchType = itemData.Source.Any(source => source != null && sourceItemData.Type.Contains(source));
                if (secondLevelMatchName || secondLevelMatchType)
                    returnValue += $"\r\nSecond Level:\r\n{sourceItem}-->{itemData.Name}-->{destinationItem}";
            }
            #endregion
            #region 3rd Level
            List<CommonItemData> thirdLevelItem = new List<CommonItemData>();
            foreach (CommonItemData secondItem in secondLevelItem)
            {
                var t = itemDatas.Where(item =>
                {
                    if (secondItem.Source.Contains(item.Name))
                        return true;
                    foreach (string source in secondItem.Source)
                        if (source != null && item.Type.Contains(source))
                            return true;
                    return false;
                });
                thirdLevelItem.Clear();
                thirdLevelItem.AddRange(t);
                thirdLevelItem.Distinct();
                foreach (CommonItemData itemData in thirdLevelItem)
                {
                    bool thirdLevelMatchName = itemData.Source.Any(source => source == sourceItemData.Name);
                    bool thirdLevelMatchType = itemData.Source.Any(source => source != null && sourceItemData.Type.Contains(source));
                    if (thirdLevelMatchName || thirdLevelMatchType)
                        returnValue += $"\r\nThird Level:\r\n{sourceItem}-->{itemData.Name}-->{secondItem.Name}-->{destinationItem}";
                }

            }
            #endregion
            return returnValue;
        }
        /// <summary>
        /// 特性轉移路徑查詢(日文)
        /// </summary>
        /// <param name="sourceItem"></param>
        /// <param name="destinationItem"></param>
        public string searchInJapanese(string sourceItem, string destinationItem)
        {
            CommonItemData sourceItemData = itemDatas.Single(item => item.JapaneseName == sourceItem);
            CommonItemData destinationItemData = itemDatas.Single(item => item.JapaneseName == destinationItem);
            string returnValue = "";
            #region 1st Level
            bool firstLevelMatchName = destinationItemData.Source.Any(source => source == sourceItemData.Name);
            bool firstLevelMatchType = destinationItemData.Source.Any(source => source != null && sourceItemData.Type.Contains(source));
            if (firstLevelMatchName || firstLevelMatchType)
                returnValue += $"First Level:\r\n{sourceItem}-->{destinationItem}";
            #endregion
            #region 2nd Level
            var secondLevelItem = itemDatas.Where(item =>
            {
                if (destinationItemData.Source.Contains(item.Name))
                    return true;
                foreach (string source in destinationItemData.Source)
                    if (source != null && item.Type.Contains(source))
                        return true;
                return false;
            });
            foreach (CommonItemData itemData in secondLevelItem)
            {
                bool secondLevelMatchName = itemData.Source.Any(source => source == sourceItemData.Name);
                bool secondLevelMatchType = itemData.Source.Any(source => source != null && sourceItemData.Type.Contains(source));
                if (secondLevelMatchName || secondLevelMatchType)
                    returnValue += $"\r\nSecond Level:\r\n{sourceItem}-->{itemData.JapaneseName}-->{destinationItem}";
            }
            #endregion
            #region 3rd Level
            List<CommonItemData> thirdLevelItem = new List<CommonItemData>();
            foreach (CommonItemData secondItem in secondLevelItem)
            {
                var t = itemDatas.Where(item =>
                {
                    if (secondItem.Source.Contains(item.Name))
                        return true;
                    foreach (string source in secondItem.Source)
                        if (source != null && item.Type.Contains(source))
                            return true;
                    return false;
                });
                thirdLevelItem.Clear();
                thirdLevelItem.AddRange(t);
                thirdLevelItem.Distinct();
                foreach (CommonItemData itemData in thirdLevelItem)
                {
                    bool thirdLevelMatchName = itemData.Source.Any(source => source == sourceItemData.Name);
                    bool thirdLevelMatchType = itemData.Source.Any(source => source != null && sourceItemData.Type.Contains(source));
                    if (thirdLevelMatchName || thirdLevelMatchType)
                        returnValue += $"\r\nThird Level:\r\n{sourceItem}-->{itemData.JapaneseName}-->{secondItem.JapaneseName}-->{destinationItem}";
                }

            }
            #endregion
            return returnValue;
        }
        /// <summary>
        /// 找包含原料包含目標類型的物品
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public string searchSource(string target)
        {
            string returnValue = "";
            var q = itemDatas.Where(item => item.Source.Contains(target));
            foreach (CommonItemData s in q)
                returnValue += s.Name + "\r\n";
            return returnValue;
        }
        /// <summary>
        /// 找該類別的物品
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public string searchType(string target)
        {
            string returnValue = "";
            var q = itemDatas.Where(item => item.Type.Contains(target));
            foreach (CommonItemData s in q)
                returnValue += s.Name + "\r\n";
            return returnValue;
        }
    }
    /// <summary>
    /// 物品類別
    /// </summary>
    public class CommonItemData
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 名稱
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 日文名稱
        /// </summary>
        public string JapaneseName { get; set; }
        /// <summary>
        /// 英文名稱
        /// </summary>
        public string EnglishName { get; set; }
        /// <summary>
        /// 屬性
        /// </summary>
        public List<string> Attribute { get; set; } = new List<string>();
        /// <summary>
        /// 類型
        /// </summary>
        public List<string> Type { get; set; } = new List<string>();
        /// <summary>
        /// 原料
        /// </summary>
        public List<string> Source { get; set; } = new List<string>();
    }
}



