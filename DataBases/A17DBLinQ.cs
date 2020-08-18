using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace AtelierLaDiDa.DataBases
{
    /// <summary>
    /// A17資料處理類別，LinQ練習
    /// </summary>
    class A17DBLinQ
    {
        /// <summary>
        /// 資料庫路徑
        /// </summary>
        private string dBPath = "DataBases/atelierLaDiDaA17Sqlite.db";
        /// <summary>
        /// 連線路徑
        /// </summary>
        private string connectionString;
        /// <summary>
        /// 連線物件
        /// </summary>
        SQLiteConnection connection;
        List<A17Data> a17Datas = new List<A17Data>();
        /// <summary>
        /// 建構式
        /// </summary>
        public A17DBLinQ()
        {
            connectionString = "data source =" + dBPath;
            try
            {
                connection = new SQLiteConnection(connectionString);
                connection.Open();
                saveData();
            }
            catch (Exception ex)
            {
                Log.writeLog(ex.Message);
            }
        }
        /// <summary>
        /// 將資料庫內容塞入A17Data類別中
        /// </summary>
        private void saveData()
        {
            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Sophie$";
            SQLiteDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                if (!dataReader[0].Equals(DBNull.Value))
                {
                    A17Data a17Data = new A17Data();
                    a17Data.ID = Convert.ToInt32(dataReader["No#"]);
                    a17Data.Name = dataReader["Name"].ToString();
                    a17Data.Attribute.Add(dataReader["Attribute1"].ToString());
                    a17Data.Attribute.Add(dataReader["Attribute2"].ToString());
                    a17Data.Attribute.Add(dataReader["Attribute3"].ToString());
                    a17Data.Attribute.Add(dataReader["Attribute4"].ToString());
                    a17Data.Attribute.Add(dataReader["Attribute5"].ToString());
                    a17Data.Type.Add(dataReader["Type1"].ToString());
                    a17Data.Type.Add(dataReader["Type2"].ToString());
                    a17Data.Type.Add(dataReader["Type3"].ToString());
                    a17Data.Type.Add(dataReader["Type4"].ToString());
                    a17Data.Source.Add(dataReader["Source1"].ToString());
                    a17Data.Source.Add(dataReader["Source2"].ToString());
                    a17Data.Source.Add(dataReader["Source3"].ToString());
                    a17Data.Source.Add(dataReader["Source4"].ToString());
                    System.Predicate<string> stringIsNull = new Predicate<string>(str => str=="");
                    a17Data.Attribute.RemoveAll(stringIsNull);
                    a17Data.Type.RemoveAll(stringIsNull);
                    a17Data.Source.RemoveAll(stringIsNull);
                    a17Datas.Add(a17Data);
                }
            }
        }
        /// <summary>
        /// 生成物品清單
        /// </summary>
        /// <returns>物品清單</returns>
        public List<string> generateObjectList()
        {
            List<string> returnValue = new List<string>();
            foreach(A17Data a17Data in a17Datas)
                returnValue.Add(a17Data.Name);
            return returnValue;
        }
        /// <summary>
        /// 特性轉移路徑查詢
        /// </summary>
        /// <param name="sourceItem"></param>
        /// <param name="destinationItem"></param>
        public string search(string sourceItem, string destinationItem)
        {
            IEnumerable<A17Data> sourceItemData =
                from s in a17Datas
                where s.Name == sourceItem
                select s;

            IEnumerable<A17Data> destinationItemData =
                from d in a17Datas
                where d.Name == destinationItem
                select d;

            string returnValue = "";
            #region 原料類型及目標物原料拆解
            //原料類型
            List<string> sourceType = sourceItemData.FirstOrDefault().Type;
            //目標物原料
            List<string> destinationIngredient = destinationItemData.FirstOrDefault().Source;
            #endregion
            #region 第一層搜尋
            bool firstLevelMatch = false;
            foreach (string di in destinationIngredient)
            {
                if (di == sourceItem)
                    firstLevelMatch = true;
                foreach (string st in sourceType)
                {
                    if (st == "" || st == null)
                        break;
                    if (di == st)
                        firstLevelMatch = true;
                }
            }
            if (firstLevelMatch)
            {
                returnValue += $"First Level:\r\n{sourceItem}-->{destinationItem}\r\n";
            }
            #endregion
            # region 第二層搜尋
            //目標物可能的原料
            List<A17Data> secondLevelName = new List<A17Data>();
            bool secondLevelMatch = false;

            foreach (string di in destinationIngredient)
            {
                var query =
                    from data in a17Datas
                    where data.Name == di
                    select data;
                var query2 =
                    from data in a17Datas
                    where data.Type.Contains(di)
                    select data;
                secondLevelName.AddRange(query.ToList());
                secondLevelName.AddRange(query2.ToList());
                secondLevelName = secondLevelName.Distinct().ToList();
            }
            //secondLevelName 這時包含了目標物的所有可能原料名稱(包含Type符合的物件名稱)
            foreach (A17Data item in secondLevelName)
            {
                foreach (string di in item.Source)
                {
                    if (di == sourceItem)
                        secondLevelMatch = true;
                    foreach (string st in sourceType)
                    {
                        if (di == st)
                            secondLevelMatch = true;
                    }
                }
                if (secondLevelMatch)
                {
                    returnValue += $"\r\nSecond Level:\r\n{sourceItem}-->{item.Name}-->{destinationItem}";
                    secondLevelMatch = false;
                }
            }
            #endregion
            # region 第三層搜尋
            //目標物原料的可能的原料(迴圈暫存)
            List<A17Data> thirdLevelName = new List<A17Data>();
            //目標物的原料的原料的原料
            List<string> thirdLevelIngredient = new List<string>();
            bool thirdLevelMatch = false;
            //secondItem是目標物可能的原料名稱之一，先將無法製作的物品排除掉
            foreach (A17Data secondItem in secondLevelName)
            {
                //di是secondItem的材料之一
                foreach (string di in secondItem.Source)
                {
                    var query =
                        from data in a17Datas
                        where data.Name == di
                        select data;
                    var query2 =
                        from data in a17Datas
                        where data.Type.Contains(di)
                        select data;
                    thirdLevelName.Clear();
                    thirdLevelName.AddRange(query.ToList());
                    thirdLevelName.AddRange(query2.ToList());
                    thirdLevelName = thirdLevelName.Distinct().ToList();
                    //thirdItem是符合di條件的物品名稱，也就是secondItem可能的材料名稱
                    foreach (A17Data thirdItem in thirdLevelName)
                    {
                        //dddi是ddi材料名稱的原料類型or名稱
                        foreach (string dddi in thirdItem.Source)
                        {
                            if (dddi == sourceItem)
                                thirdLevelMatch = true;
                            foreach (string st in sourceType)
                            {
                                if (dddi == st)
                                    thirdLevelMatch = true;
                            }
                            if (thirdLevelMatch)
                                break;
                        }
                        if (thirdLevelMatch)
                        {
                            returnValue += $"\r\nThird Level:\r\n{sourceItem}-->{thirdItem.Name}-->{secondItem.Name}-->{destinationItem}";
                            thirdLevelMatch = false;
                        }
                    }
                }
            }
            #endregion
            return returnValue;
        }
    }
    /// <summary>
    /// 物品類別
    /// </summary>
    public class A17Data
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
