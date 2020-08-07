using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace AtelierLaDiDa.DataBases
{
    class A20DB
    {
        /// <summary>
        /// 資料庫路徑
        /// </summary>
        private string dBPath = "DataBases/atelierLaDiDaA20Sqlite.db";
        /// <summary>
        /// 連線路徑
        /// </summary>
        private string connectionString;
        /// <summary>
        /// 連線物件
        /// </summary>
        SQLiteConnection connection;
        /// <summary>
        /// 物品清單
        /// </summary>
        List<string> objectList = new List<string>();
        /// <summary>
        /// 建構式，連線建立
        /// </summary>
        public A20DB()
        {
            connectionString = "data source =" + dBPath;
            try
            {
                connection = new SQLiteConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                Log.writeLog(ex.Message);
            }

        }
        /// <summary>
        /// 生成物品清單
        /// </summary>
        /// <returns>物品清單</returns>
        public List<string> generateObjectList()
        {
            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Lulua$";
            SQLiteDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                if (!dataReader[0].Equals(DBNull.Value))
                    objectList.Add(dataReader["Name"].ToString());
            }
            return objectList;
        }
        /// <summary>
        /// 特性轉移路徑查詢
        /// </summary>
        /// <param name="sourceItem"></param>
        /// <param name="destinationItem"></param>
        public string search(string sourceItem, string destinationItem)
        {
            string returnValue = "";
            #region 原料類型及目標物原料拆解
            //原料類型
            List<string> sourceType = new List<string>();
            //目標物原料
            List<string> destinationIngredient = new List<string>();
            sourceType = seperateSource(sourceItem);
            destinationIngredient = seperateDestination(destinationItem);
            #endregion
            #region 第一層搜尋
            bool firstLevelMatch = false;
            foreach (string di in destinationIngredient)
            {
                if (di == "" || di == null)
                    break;
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
            //目標物可能的原料名稱
            List<string> secondLevelName = new List<string>();
            //目標物原料的原料
            List<string> secondLevelIngredient = new List<string>();
            bool secondLevelMatch = false;

            foreach (string di in destinationIngredient)
            {
                if (di == "" || di == null)
                    break;
                secondLevelName.AddRange(searchIngredient(di));
            }
            //secondLevelName 這時包含了目標物的所有可能原料名稱(包含Type符合的物件名稱)
            foreach (string item in clearItemName(secondLevelName))
            {
                secondLevelIngredient.AddRange(seperateDestination(item));
                foreach (string di in seperateDestination(item))
                {
                    if (di == "" || di == null)
                        continue;
                    if (di == sourceItem)
                        secondLevelMatch = true;
                    foreach (string st in sourceType)
                    {
                        if (st == "" || st == null)
                            break;
                        if (di == st)
                            secondLevelMatch = true;
                    }
                }
                if (secondLevelMatch)
                {
                    returnValue += $"\r\nSecond Level:\r\n{sourceItem}-->{item}-->{destinationItem}";
                    secondLevelMatch = false;
                }
            }
            //secondLevelIngredient 包含了目標物原料的原料
            #endregion
            # region 第三層搜尋
            //目標物原料的可能的原料名稱(迴圈暫存)
            List<string> thirdLevelName = new List<string>();
            //目標物的原料的原料的原料
            List<string> thirdLevelIngredient = new List<string>();
            bool thirdLevelMatch = false;
            //secondItem是目標物可能的原料名稱之一，先將無法製作的物品排除掉
            foreach (string secondItem in clearItemName(secondLevelName))
            {
                //di是secondItem的材料之一
                foreach (string di in seperateDestination(secondItem))
                {
                    if (di == "" || di == null)
                        continue;
                    thirdLevelName = searchIngredient(di);
                    //ddi是符合di條件的物品名稱，也就是secondItem可能的材料名稱
                    foreach (string ddi in clearItemName(thirdLevelName))
                    {
                        //dddi是ddi材料名稱的原料類型or名稱
                        foreach (string dddi in seperateDestination(ddi))
                        {
                            if (dddi == "" || dddi == null)
                                continue;
                            if (dddi == sourceItem)
                                thirdLevelMatch = true;
                            foreach (string st in sourceType)
                            {
                                if (st == "" || st == null)
                                    break;
                                if (dddi == st)
                                    thirdLevelMatch = true;
                            }
                        }
                        if (thirdLevelMatch)
                        {
                            returnValue += $"\r\nThird Level:\r\n{sourceItem}-->{ddi}-->{secondItem}-->{destinationItem}";
                            thirdLevelMatch = false;
                        }
                    }
                }
            }
            #endregion
            return returnValue;
        }
        /// <summary>
        /// 原料類別拆解
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns></returns>
        private List<string> seperateSource(string itemName)
        {
            List<string> sourceType = new List<string>();
            SQLiteCommand commandS = connection.CreateCommand();
            commandS.CommandText = $"SELECT * FROM Lulua$ WHERE Name = '{itemName}'";
            SQLiteDataReader dataReaderS = commandS.ExecuteReader();
            while (dataReaderS.Read())
            {
                if (!dataReaderS[0].Equals(DBNull.Value))
                {
                    sourceType.Add(dataReaderS["Type1"].ToString());
                    sourceType.Add(dataReaderS["Type2"].ToString());
                    sourceType.Add(dataReaderS["Type3"].ToString());
                    sourceType.Add(dataReaderS["Type4"].ToString());
                    sourceType.Add(dataReaderS["Type5"].ToString());
                    sourceType.Add(dataReaderS["Type6"].ToString());
                }
            }
            return sourceType;
        }
        /// <summary>
        /// 目標物原料拆解
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns></returns>
        private List<string> seperateDestination(string itemName)
        {
            List<string> destinationIngredient = new List<string>();
            SQLiteCommand commandD = connection.CreateCommand();
            commandD.CommandText = $"SELECT * FROM Lulua$ WHERE Name = '{itemName}'";
            SQLiteDataReader dataReaderD = commandD.ExecuteReader();
            while (dataReaderD.Read())
            {
                if (!dataReaderD[0].Equals(DBNull.Value))
                {
                    destinationIngredient.Add(dataReaderD["Source1"].ToString());
                    destinationIngredient.Add(dataReaderD["Source2"].ToString());
                    destinationIngredient.Add(dataReaderD["Source3"].ToString());
                    destinationIngredient.Add(dataReaderD["Source4"].ToString());
                }
            }
            return destinationIngredient;
        }
        /// <summary>
        /// 查詢原料的原料名稱
        /// </summary>
        /// <param name="itemNameOrType"></param>
        /// <returns></returns>
        private List<string> searchIngredient(string itemNameOrType)
        {
            List<string> nameList = new List<string>();
            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = $"SELECT * FROM Lulua$ WHERE Name = '{itemNameOrType}' OR Type1 = '{itemNameOrType}' OR Type2 = '{itemNameOrType}' OR Type3 = '{itemNameOrType}' OR Type4 = '{itemNameOrType}';";
            //command.CommandText = $"SELECT * FROM Lulua$ WHERE Name = '{itemNameOrType}'";
            SQLiteDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                if (!dataReader[0].Equals(DBNull.Value))
                {
                    nameList.Add(dataReader["Name"].ToString());
                }
            }
            return nameList;
        }
        /// <summary>
        /// 將List中無法製作的物品排除
        /// </summary>
        /// <param name="ItemName"></param>
        /// <returns></returns>
        private List<string> clearItemName(List<string> ItemName)
        {
            List<string> clearList = new List<string>();
            string subReturn = "";
            foreach (string secondItem in ItemName)
            {
                subReturn = subClearSecondItemName(secondItem);
                if (subReturn != "")
                    clearList.Add(subReturn);
            }

            return clearList;
        }
        private string subClearSecondItemName(string secondItemName)
        {
            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = $"SELECT * FROM Lulua$ WHERE Name = '{secondItemName}' AND Source1 NOT NULL";
            SQLiteDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read() && !dataReader[0].Equals(DBNull.Value))
            {
                return dataReader["Name"].ToString();
            }
            return "";
        }
    }
}
