using System;
using System.Windows.Forms;
using AtelierLaDiDaDatabase;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AtelierLaDiDaUICore
{
    /// <summary>
    /// 基底表單
    /// </summary>
    public partial class FrmBase : Form
    {
        #region 無關表單的部分

        private List<CustomData> data;
        private List<IAtelier> oldData;
        private EnumSeriesName seriesName;

        private void SetDBPath()
        {
            string path = Directory.GetCurrentDirectory() + @"\DataBases\atelierLaDiDa.db";
            Parameters.SetDBPath(path);
        }

        private void SeriesLabelUpdate()
        {
            switch (cbxSeriesName.Text)
            {
                case "A11":
                    lblSeriesName.Text = "ロロナのアトリエ～アーランドの錬金術士～";
                    seriesName = EnumSeriesName.A11_Atelier_Rorona;
                    break;

                case "A12":
                    lblSeriesName.Text = "トトリのアトリエ ～アーランドの錬金術士2～";
                    seriesName = EnumSeriesName.A12_Atelier_Totori;
                    break;

                case "A14":
                    lblSeriesName.Text = "アーシャのアトリエ 〜黄昏の大地の錬金術士〜";
                    seriesName = EnumSeriesName.A14_Atelier_Ayesha;
                    break;

                case "A17":
                    lblSeriesName.Text = "ソフィーのアトリエ ～不思議な本の錬金術士～";
                    seriesName = EnumSeriesName.A17_Atelier_Sophie;
                    break;

                case "A20":
                    lblSeriesName.Text = "ルルアのアトリエ ～アーランドの錬金術士 4～";
                    seriesName = EnumSeriesName.A20_Atelier_Lulua;
                    break;

                case "A21":
                    lblSeriesName.Text = "ライザのアトリエ 〜常闇の女王と秘密の隠れ家〜";
                    seriesName = EnumSeriesName.A21_Atelier_Ryza;
                    break;

                default:
                    break;
                    //to update
            }
        }

        /// <summary>
        /// 目前A11 A12 A14 A17 A20 A21皆支援日文。
        /// A20 日文資料有欠缺，標示為"欠如"。
        /// </summary>
        private void JapanesSettingReset()
        {
            //不支援日文的項目進到if裡面
            if (false)
            {
                chbxJapanese.Checked = false;
                chbxJapanese.Enabled = false;
            }
            else
                chbxJapanese.Enabled = true;
        }

        private void SetData()
        {
            oldData = GetInfo.GetItemInfo(seriesName);
            data = new List<CustomData>();
            foreach (var item in oldData)
                data.Add(new CustomData().MigrateFromIAtelier(item));
        }

        /// <summary>
        /// 更新物品目錄
        /// </summary>
        private void IndexUpdate()
        {
            cbxDestination.Text = "";
            cbxSource.Text = "";
            cbxItemType.Text = "";
            cbxDestination.Items.Clear();
            cbxSource.Items.Clear();
            cbxItemType.Items.Clear();
            string[] itemNames = chbxJapanese.Checked ?
                data.Select(item => item.JapaneseName).ToArray() : data.Select(item => item.Name).ToArray();
            cbxDestination.Items.AddRange(itemNames);
            cbxSource.Items.AddRange(itemNames);
            cbxItemType.Items.AddRange(GeneraterTypeList().ToArray());
        }

        /// <summary>
        /// 顯示物品詳細資料
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns></returns>
        private string ShowItemDetail(string itemName)
        {
            CustomData target = chbxJapanese.Checked ?
                data.Where(item => item.JapaneseName == itemName).FirstOrDefault() : data.Where(item => item.Name == itemName).FirstOrDefault();
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
        private string Search(string sourceItem, string destinationItem)
        {
            CustomData sourceItemData = data.Single(item => item.Name == sourceItem);
            CustomData destinationItemData = data.Single(item => item.Name == destinationItem);
            string returnValue = "";

            #region 1st Level

            bool firstLevelMatchName = destinationItemData.Source.Any(source => source == sourceItemData.Name);
            bool firstLevelMatchType = destinationItemData.Source.Any(source => source != null && sourceItemData.Type.Contains(source));
            if (firstLevelMatchName || firstLevelMatchType)
                returnValue += $"First Level:\r\n{sourceItem}-->{destinationItem}";

            #endregion 1st Level

            #region 2nd Level

            var secondLevelItem = data.Where(item =>
            {
                if (destinationItemData.Source.Contains(item.Name))
                    return true;
                foreach (string source in destinationItemData.Source)
                    if (source != null && item.Type.Contains(source))
                        return true;
                return false;
            });
            foreach (CustomData itemData in secondLevelItem)
            {
                bool secondLevelMatchName = itemData.Source.Any(source => source == sourceItemData.Name);
                bool secondLevelMatchType = itemData.Source.Any(source => source != null && sourceItemData.Type.Contains(source));
                if (secondLevelMatchName || secondLevelMatchType)
                    returnValue += $"\r\nSecond Level:\r\n{sourceItem}-->{itemData.Name}-->{destinationItem}";
            }

            #endregion 2nd Level

            #region 3rd Level

            List<CustomData> thirdLevelItem = new List<CustomData>();
            foreach (CustomData secondItem in secondLevelItem)
            {
                var t = data.Where(item =>
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
                foreach (CustomData itemData in thirdLevelItem)
                {
                    bool thirdLevelMatchName = itemData.Source.Any(source => source == sourceItemData.Name);
                    bool thirdLevelMatchType = itemData.Source.Any(source => source != null && sourceItemData.Type.Contains(source));
                    if (thirdLevelMatchName || thirdLevelMatchType)
                        returnValue += $"\r\nThird Level:\r\n{sourceItem}-->{itemData.Name}-->{secondItem.Name}-->{destinationItem}";
                }
            }

            #endregion 3rd Level

            return returnValue;
        }

        /// <summary>
        /// 特性轉移路徑查詢(日文)
        /// </summary>
        /// <param name="sourceItem"></param>
        /// <param name="destinationItem"></param>
        private string SearchInJapanese(string sourceItem, string destinationItem)
        {
            CustomData sourceItemData = data.Single(item => item.JapaneseName == sourceItem);
            CustomData destinationItemData = data.Single(item => item.JapaneseName == destinationItem);
            string returnValue = "";

            #region 1st Level

            bool firstLevelMatchName = destinationItemData.Source.Any(source => source == sourceItemData.Name);
            bool firstLevelMatchType = destinationItemData.Source.Any(source => source != null && sourceItemData.Type.Contains(source));
            if (firstLevelMatchName || firstLevelMatchType)
                returnValue += $"First Level:\r\n{sourceItem}-->{destinationItem}";

            #endregion 1st Level

            #region 2nd Level

            var secondLevelItem = data.Where(item =>
            {
                if (destinationItemData.Source.Contains(item.Name))
                    return true;
                foreach (string source in destinationItemData.Source)
                    if (source != null && item.Type.Contains(source))
                        return true;
                return false;
            });
            foreach (CustomData itemData in secondLevelItem)
            {
                bool secondLevelMatchName = itemData.Source.Any(source => source == sourceItemData.Name);
                bool secondLevelMatchType = itemData.Source.Any(source => source != null && sourceItemData.Type.Contains(source));
                if (secondLevelMatchName || secondLevelMatchType)
                    returnValue += $"\r\nSecond Level:\r\n{sourceItem}-->{itemData.JapaneseName}-->{destinationItem}";
            }

            #endregion 2nd Level

            #region 3rd Level

            List<CustomData> thirdLevelItem = new List<CustomData>();
            foreach (CustomData secondItem in secondLevelItem)
            {
                var t = data.Where(item =>
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
                foreach (CustomData itemData in thirdLevelItem)
                {
                    bool thirdLevelMatchName = itemData.Source.Any(source => source == sourceItemData.Name);
                    bool thirdLevelMatchType = itemData.Source.Any(source => source != null && sourceItemData.Type.Contains(source));
                    if (thirdLevelMatchName || thirdLevelMatchType)
                        returnValue += $"\r\nThird Level:\r\n{sourceItem}-->{itemData.JapaneseName}-->{secondItem.JapaneseName}-->{destinationItem}";
                }
            }

            #endregion 3rd Level

            return returnValue;
        }

        /// <summary>
        /// 找包含原料包含目標類型的物品
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        private string SearchSource(string target)
        {
            string returnValue = "";
            var q = data.Where(item => item.Source.Contains(target));
            foreach (CustomData s in q)
                returnValue += s.Name + "\r\n";
            return returnValue;
        }

        /// <summary>
        /// 找該類別的物品
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        private string SearchType(string target)
        {
            string returnValue = "";
            var q = data.Where(item => item.Type.Contains(target));
            foreach (CustomData s in q)
                returnValue += s.Name + "\r\n";
            return returnValue;
        }

        /// <summary>
        /// 生成物品類型清單
        /// </summary>
        /// <returns>物品類型清單</returns>
        private List<string> GeneraterTypeList()
        {
            List<string> returnValue = new List<string>();
            foreach (CustomData item in data)
                returnValue.AddRange(item.Type.Where(str => str != null));
            return returnValue.Distinct().ToList();
        }

        #endregion 無關表單的部分

        #region 有關表單的部分

        /// <summary>
        /// 建構式
        /// </summary>
        public FrmBase()
        {
            InitializeComponent();
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {
            cbxSeriesName.Items.Add("A11");
            cbxSeriesName.Items.Add("A12");
            cbxSeriesName.Items.Add("A14");
            cbxSeriesName.Items.Add("A17");
            cbxSeriesName.Items.Add("A20");
            cbxSeriesName.Items.Add("A21");
            //to update
            SetDBPath();
            lblLoading.Visible = false;
        }

        private void CbxSeriesName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblLoading.Text = "Loading Database";
            lblLoading.ForeColor = System.Drawing.Color.Red;
            lblLoading.Visible = true;
            SeriesLabelUpdate();
            JapanesSettingReset();
            SetData();
            IndexUpdate();
            lblLoading.Text = "Completed";
            lblLoading.ForeColor = System.Drawing.Color.Green;
        }

        private void ChbxJapanese_OnCheckedChanged(object sender, EventArgs e)
        {
            lblLoading.Text = "Loading Database";
            lblLoading.ForeColor = System.Drawing.Color.Red;
            lblLoading.Visible = true;
            IndexUpdate();
            lblLoading.Text = "Completed";
            lblLoading.ForeColor = System.Drawing.Color.Green;
        }

        private void BtnReadMe_Click(object sender, EventArgs e)
        {
            string message = "";
            message += "";
            MessageBox.Show(message, "Read Me");
        }

        private void BtnDetailSource_Click(object sender, EventArgs e)
        {
            tbxResult.Clear();
            tbxResult.Text += ShowItemDetail(cbxSource.Text);
        }

        private void BtnDetailDestination_Click(object sender, EventArgs e)
        {
            tbxResult.Clear();
            tbxResult.Text += ShowItemDetail(cbxDestination.Text);
        }

        private void BtnSearchSource_Click(object sender, EventArgs e)
        {
            tbxResult.Clear();
            tbxResult.Text += SearchSource(cbxItemType.Text);
        }

        private void BtnSearchType_Click(object sender, EventArgs e)
        {
            tbxResult.Clear();
            tbxResult.Text += SearchType(cbxItemType.Text);
        }

        private void BtnGetRoute_Click(object sender, EventArgs e)
        {
            tbxResult.Clear();
            tbxResult.Text += chbxJapanese.Checked ?
                SearchInJapanese(cbxSource.Text, cbxDestination.Text) : Search(cbxSource.Text, cbxDestination.Text);
        }

        #endregion 有關表單的部分
    }
}