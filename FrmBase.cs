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
        /// 建構式
        /// </summary>
        public FrmBase()
        {
            InitializeComponent();
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {
            cbxSeriesName.Items.Add("A17");
            cbxSeriesName.Items.Add("A21");
            //to update
        }
        private EnumSeriesName seriesName;
        private void cbxSeriesName_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbxSeriesName.Text)
            {
                case "A17":
                    lblSeriesName.Text = "ソフィーのアトリエ ～不思議な本の錬金術士～";
                    seriesName = EnumSeriesName.A17_Atelier_Sophie;
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
            List<string> returnValue;
            string[] objectList;
            switch (seriesName)
            {
                case EnumSeriesName.A17_Atelier_Sophie:
                    DataBases.A17DB a17 = new DataBases.A17DB();
                    returnValue = a17.generateObjectList();
                    objectList = returnValue.ToArray();
                    cbxSource.Items.AddRange(objectList);
                    cbxDestination.Items.AddRange(objectList);
                    break;
                case EnumSeriesName.A21_Atelier_Ryza:
                    A21DB a21 = new A21DB();
                    returnValue = a21.generateObjectList();
                    objectList = returnValue.ToArray();
                    cbxSource.Items.AddRange(objectList);
                    cbxDestination.Items.AddRange(objectList);
                    break;
                default:
                    break;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            indexUpdate();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            AtelierLaDiDa.DataBases.A17DB a17 = new DataBases.A17DB();
            a17.testDB();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            switch(seriesName)
            {
                case EnumSeriesName.A17_Atelier_Sophie:
                    A17DB a17 = new A17DB();
                    tbxResult.Text = a17.search(cbxSource.Text,cbxDestination.Text);
                    break;
                case EnumSeriesName.A21_Atelier_Ryza:
                    A21DB a21 = new A21DB();
                    tbxResult.Text = a21.search(cbxSource.Text, cbxDestination.Text);
                    break;
                default:
                    break;
            }
        }

        private void btnReadMe_Click(object sender, EventArgs e)
        {
            string message="";
            message += "2020/8/6 初版說明\r\n此軟體會放上Github歡迎自由修改，如有C#能手能夠加以指教更是再好不過。\r\n目前版本包含A17中文版物品的特性轉移計算，資料庫源自巴哈試算表，計算僅到第二層，路徑並未考慮特性是否可加在該類型物品上。";
            MessageBox.Show(message, "Read Me");
        }
    }
}
