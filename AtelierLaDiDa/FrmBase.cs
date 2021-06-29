using AtelierLaDiDa.DataBases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtelierLaDiDa
{
    /// <summary>
    /// 基底表單
    /// </summary>
    public partial class FrmBase : Form
    {
        /// <summary>
        /// 資料庫物件
        /// </summary>
        public CommonDataBase dataBase;

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
            cbxSeriesName.Items.Add("A17");
            cbxSeriesName.Items.Add("A20");
            cbxSeriesName.Items.Add("A21");
            //to update
        }

        private EnumSeriesName seriesName;

        private void CbxSeriesName_SelectedIndexChanged(object sender, EventArgs e)
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
        /// 更新物品目錄
        /// </summary>
        private void IndexUpdate()
        {
            cbxDestination.Items.Clear();
            cbxSource.Items.Clear();
            cbxItemType.Items.Clear();
            this.dataBase = chbxJapanese.Checked ? new CommonDataBase(seriesName, "Japanese") : new CommonDataBase(seriesName);
            if ((seriesName == EnumSeriesName.A11_Atelier_Rorona || seriesName == EnumSeriesName.A12_Atelier_Totori) && chbxJapanese.Checked)
            {
                cbxSource.Items.AddRange(dataBase.GenerateJapaneseObjectList().ToArray());
                cbxDestination.Items.AddRange(dataBase.GenerateJapaneseObjectList().ToArray());
            }
            else
            {
                cbxSource.Items.AddRange(dataBase.GenerateObjectList().ToArray());
                cbxDestination.Items.AddRange(dataBase.GenerateObjectList().ToArray());
            }
            cbxItemType.Items.AddRange(dataBase.GeneratrTypeList().ToArray());
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            IndexUpdate();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //tbxResult.Text = dataBase.search(cbxSource.Text, cbxDestination.Text);
            tbxResult.Text = ((seriesName == EnumSeriesName.A11_Atelier_Rorona || seriesName == EnumSeriesName.A12_Atelier_Totori) && chbxJapanese.Checked) ? dataBase.SearchInJapanese(cbxSource.Text, cbxDestination.Text) : dataBase.Search(cbxSource.Text, cbxDestination.Text);
        }

        private void BtnReadMe_Click(object sender, EventArgs e)
        {
            string message = "";
            message += "";
            MessageBox.Show(message, "Read Me");
        }

        private void BtnDetailSource_Click(object sender, EventArgs e)
        {
            tbxResult.Text = dataBase.ShowItemDetail(cbxSource.Text);
        }

        private void BtnDetailDestination_Click(object sender, EventArgs e)
        {
            tbxResult.Text = dataBase.ShowItemDetail(cbxDestination.Text);
        }

        private void BtnSearchSource_Click(object sender, EventArgs e)
        {
            tbxResult.Text = dataBase.SearchSource(cbxItemType.Text);
        }

        private void BtnSearchType_Click(object sender, EventArgs e)
        {
            tbxResult.Text = dataBase.SearchType(cbxItemType.Text);
        }
    }
}