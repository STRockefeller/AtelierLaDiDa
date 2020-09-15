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
            cbxSeriesName.Items.Add("A17");
            cbxSeriesName.Items.Add("A20");
            cbxSeriesName.Items.Add("A21");
            //to update
        }
        private EnumSeriesName seriesName;
        private void cbxSeriesName_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxSeriesName.Text)
            {
                case "A11":
                    lblSeriesName.Text = "ロロナのアトリエ～アーランドの錬金術士～";
                    seriesName = EnumSeriesName.A11_Atelier_Rorona;
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
        private void indexUpdate()
        {
            cbxDestination.Items.Clear();
            cbxSource.Items.Clear();
            cbxItemType.Items.Clear();
            if (chbxJapanese.Checked)
                this.dataBase = new CommonDataBase(seriesName, "Japanese");
            else
                this.dataBase = new CommonDataBase(seriesName);
            cbxSource.Items.AddRange(dataBase.generateObjectList().ToArray());
            cbxDestination.Items.AddRange(dataBase.generateObjectList().ToArray());
            cbxItemType.Items.AddRange(dataBase.generatrTypeList().ToArray());
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            indexUpdate();
        }

        #region test
        private void btnTest_Click(object sender, EventArgs e)
        {
            //AtelierLaDiDa.DataBases.A17DB a17 = new DataBases.A17DB();
            //a17.testDB();

            CommonDataBase commonDataBase;
            switch (seriesName)
            {
                case EnumSeriesName.A17_Atelier_Sophie:
                    if (chbxJapanese.Checked)
                    {
                        commonDataBase = new CommonDataBase(seriesName, "Japanese");
                    }
                    else
                    {
                        commonDataBase = new CommonDataBase(seriesName);
                    }
                    break;
                default:
                    break;
            }
        }
        #endregion

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            tbxResult.Text = dataBase.search(cbxSource.Text, cbxDestination.Text);
        }

        private void btnReadMe_Click(object sender, EventArgs e)
        {
            string message = "";
            message += "";
            MessageBox.Show(message, "Read Me");
        }

        private void btnDetailSource_Click(object sender, EventArgs e)
        {
            tbxResult.Text = dataBase.showItemDetail(cbxSource.Text);
        }

        private void btnDetailDestination_Click(object sender, EventArgs e)
        {
            tbxResult.Text = dataBase.showItemDetail(cbxDestination.Text);
        }

        private void btnSearchSource_Click(object sender, EventArgs e)
        {
            tbxResult.Text = dataBase.searchSource(cbxItemType.Text);
        }

        private void btnSearchType_Click(object sender, EventArgs e)
        {
            tbxResult.Text = dataBase.searchType(cbxItemType.Text);
        }
    }
}
