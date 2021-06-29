
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AtelierLaDiDaDataAdapter;

namespace AtelierLaDiDaUI
{
    /// <summary>
    /// 基底表單
    /// </summary>
    public partial class FrmBase : Form
    {
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
            SetDBPath();
        }
        private void SetDBPath()
        {
            string relPath = @"\atelierLaDiDa.db";
            DataAdapter.SetDBPath(Path.GetFullPath(relPath));
        }

        private void CbxSeriesName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeriesLabelUpdate();
            DataAdapter.SetSeriesName(cbxSeriesName.Text);
            JapanesSettingReset();
        }
        private void SeriesLabelUpdate()
        {
            switch (cbxSeriesName.Text)
            {
                case "A11":
                    lblSeriesName.Text = "ロロナのアトリエ～アーランドの錬金術士～";
                    break;

                case "A12":
                    lblSeriesName.Text = "トトリのアトリエ ～アーランドの錬金術士2～";
                    break;

                case "A17":
                    lblSeriesName.Text = "ソフィーのアトリエ ～不思議な本の錬金術士～";
                    break;

                case "A20":
                    lblSeriesName.Text = "ルルアのアトリエ ～アーランドの錬金術士 4～";
                    break;

                case "A21":
                    lblSeriesName.Text = "ライザのアトリエ 〜常闇の女王と秘密の隠れ家〜";
                    break;

                default:
                    break;
                    //to update
            }
        }
        /// <summary>
        /// 目前只有A11 A12 A17支援日文
        /// </summary>
        private void JapanesSettingReset()
        {
            if (cbxSeriesName.Text != "A11" && cbxSeriesName.Text != "A12" && cbxSeriesName.Text != "A17")
            {
                chbxJapanese.Checked = false;
                chbxJapanese.Enabled = false;
            }
            else
                chbxJapanese.Enabled = true;
        }

        /// <summary>
        /// 更新物品目錄
        /// </summary>
        private void IndexUpdate()
        {
            cbxDestination.Items.Clear();
            cbxSource.Items.Clear();
            cbxItemType.Items.Clear();
            string[] itemNames = DataAdapter.GetItemNames();
            cbxDestination.Items.AddRange(itemNames);
            cbxSource.Items.AddRange(itemNames);
            cbxItemType.Items.AddRange(itemNames);
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            IndexUpdate();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
        }

        private void BtnReadMe_Click(object sender, EventArgs e)
        {
            string message = "";
            message += "";
            MessageBox.Show(message, "Read Me");
        }

        private void BtnDetailSource_Click(object sender, EventArgs e)
        {
        }

        private void BtnDetailDestination_Click(object sender, EventArgs e)
        {
        }

        private void BtnSearchSource_Click(object sender, EventArgs e)
        {
        }

        private void BtnSearchType_Click(object sender, EventArgs e)
        {
        }
    }
}