namespace AtelierLaDiDaUICore
{
    partial class FrmBase
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxSeriesName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSeriesName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSource = new System.Windows.Forms.ComboBox();
            this.cbxDestination = new System.Windows.Forms.ComboBox();
            this.btnGetRoute = new System.Windows.Forms.Button();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.btnReadMe = new System.Windows.Forms.Button();
            this.chbxJapanese = new System.Windows.Forms.CheckBox();
            this.cbxItemType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDetailSource = new System.Windows.Forms.Button();
            this.btnDetailDestination = new System.Windows.Forms.Button();
            this.btnSearchSource = new System.Windows.Forms.Button();
            this.btnSearchType = new System.Windows.Forms.Button();
            this.lblLoading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxSeriesName
            // 
            this.cbxSeriesName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSeriesName.FormattingEnabled = true;
            this.cbxSeriesName.Location = new System.Drawing.Point(117, 26);
            this.cbxSeriesName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxSeriesName.Name = "cbxSeriesName";
            this.cbxSeriesName.Size = new System.Drawing.Size(69, 27);
            this.cbxSeriesName.TabIndex = 0;
            this.cbxSeriesName.SelectedIndexChanged += new System.EventHandler(this.CbxSeriesName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Series Name";
            // 
            // lblSeriesName
            // 
            this.lblSeriesName.AutoSize = true;
            this.lblSeriesName.Location = new System.Drawing.Point(14, 72);
            this.lblSeriesName.Name = "lblSeriesName";
            this.lblSeriesName.Size = new System.Drawing.Size(110, 19);
            this.lblSeriesName.TabIndex = 2;
            this.lblSeriesName.Text = "lblSeriesName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Source";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Destination";
            // 
            // cbxSource
            // 
            this.cbxSource.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxSource.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSource.FormattingEnabled = true;
            this.cbxSource.Location = new System.Drawing.Point(108, 117);
            this.cbxSource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxSource.Name = "cbxSource";
            this.cbxSource.Size = new System.Drawing.Size(136, 27);
            this.cbxSource.TabIndex = 5;
            // 
            // cbxDestination
            // 
            this.cbxDestination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxDestination.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxDestination.FormattingEnabled = true;
            this.cbxDestination.Location = new System.Drawing.Point(108, 162);
            this.cbxDestination.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxDestination.Name = "cbxDestination";
            this.cbxDestination.Size = new System.Drawing.Size(136, 27);
            this.cbxDestination.TabIndex = 6;
            // 
            // btnGetRoute
            // 
            this.btnGetRoute.Location = new System.Drawing.Point(108, 217);
            this.btnGetRoute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetRoute.Name = "btnGetRoute";
            this.btnGetRoute.Size = new System.Drawing.Size(136, 29);
            this.btnGetRoute.TabIndex = 9;
            this.btnGetRoute.Text = "Get Route";
            this.btnGetRoute.UseVisualStyleBackColor = true;
            this.btnGetRoute.Click += new System.EventHandler(this.BtnGetRoute_Click);
            // 
            // tbxResult
            // 
            this.tbxResult.Location = new System.Drawing.Point(613, 15);
            this.tbxResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.ReadOnly = true;
            this.tbxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxResult.Size = new System.Drawing.Size(577, 631);
            this.tbxResult.TabIndex = 10;
            // 
            // btnReadMe
            // 
            this.btnReadMe.Location = new System.Drawing.Point(17, 618);
            this.btnReadMe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReadMe.Name = "btnReadMe";
            this.btnReadMe.Size = new System.Drawing.Size(84, 29);
            this.btnReadMe.TabIndex = 11;
            this.btnReadMe.Text = "Read Me";
            this.btnReadMe.UseVisualStyleBackColor = true;
            this.btnReadMe.Visible = false;
            this.btnReadMe.Click += new System.EventHandler(this.BtnReadMe_Click);
            // 
            // chbxJapanese
            // 
            this.chbxJapanese.AutoSize = true;
            this.chbxJapanese.Location = new System.Drawing.Point(207, 27);
            this.chbxJapanese.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbxJapanese.Name = "chbxJapanese";
            this.chbxJapanese.Size = new System.Drawing.Size(94, 23);
            this.chbxJapanese.TabIndex = 12;
            this.chbxJapanese.Text = "Japanese";
            this.chbxJapanese.UseVisualStyleBackColor = true;
            this.chbxJapanese.CheckedChanged += new System.EventHandler(this.ChbxJapanese_OnCheckedChanged);
            // 
            // cbxItemType
            // 
            this.cbxItemType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxItemType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxItemType.FormattingEnabled = true;
            this.cbxItemType.Location = new System.Drawing.Point(108, 348);
            this.cbxItemType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxItemType.Name = "cbxItemType";
            this.cbxItemType.Size = new System.Drawing.Size(136, 27);
            this.cbxItemType.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Type";
            // 
            // btnDetailSource
            // 
            this.btnDetailSource.Location = new System.Drawing.Point(290, 117);
            this.btnDetailSource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetailSource.Name = "btnDetailSource";
            this.btnDetailSource.Size = new System.Drawing.Size(84, 29);
            this.btnDetailSource.TabIndex = 15;
            this.btnDetailSource.Text = "Detail";
            this.btnDetailSource.UseVisualStyleBackColor = true;
            this.btnDetailSource.Click += new System.EventHandler(this.BtnDetailSource_Click);
            // 
            // btnDetailDestination
            // 
            this.btnDetailDestination.Location = new System.Drawing.Point(290, 161);
            this.btnDetailDestination.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetailDestination.Name = "btnDetailDestination";
            this.btnDetailDestination.Size = new System.Drawing.Size(84, 29);
            this.btnDetailDestination.TabIndex = 16;
            this.btnDetailDestination.Text = "Detail";
            this.btnDetailDestination.UseVisualStyleBackColor = true;
            this.btnDetailDestination.Click += new System.EventHandler(this.BtnDetailDestination_Click);
            // 
            // btnSearchSource
            // 
            this.btnSearchSource.Location = new System.Drawing.Point(290, 347);
            this.btnSearchSource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchSource.Name = "btnSearchSource";
            this.btnSearchSource.Size = new System.Drawing.Size(136, 29);
            this.btnSearchSource.TabIndex = 17;
            this.btnSearchSource.Text = "Search Source";
            this.btnSearchSource.UseVisualStyleBackColor = true;
            this.btnSearchSource.Click += new System.EventHandler(this.BtnSearchSource_Click);
            // 
            // btnSearchType
            // 
            this.btnSearchType.Location = new System.Drawing.Point(290, 384);
            this.btnSearchType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchType.Name = "btnSearchType";
            this.btnSearchType.Size = new System.Drawing.Size(136, 29);
            this.btnSearchType.TabIndex = 18;
            this.btnSearchType.Text = "Search Type";
            this.btnSearchType.UseVisualStyleBackColor = true;
            this.btnSearchType.Click += new System.EventHandler(this.BtnSearchType_Click);
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.ForeColor = System.Drawing.Color.Red;
            this.lblLoading.Location = new System.Drawing.Point(323, 29);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(114, 19);
            this.lblLoading.TabIndex = 19;
            this.lblLoading.Text = "Loading Status";
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 680);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.btnSearchType);
            this.Controls.Add(this.btnSearchSource);
            this.Controls.Add(this.btnDetailDestination);
            this.Controls.Add(this.btnDetailSource);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxItemType);
            this.Controls.Add(this.chbxJapanese);
            this.Controls.Add(this.btnReadMe);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.btnGetRoute);
            this.Controls.Add(this.cbxDestination);
            this.Controls.Add(this.cbxSource);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSeriesName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSeriesName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBase";
            this.Text = "AtelierLaDiDa";
            this.Load += new System.EventHandler(this.FrmBase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSeriesName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSeriesName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxSource;
        private System.Windows.Forms.ComboBox cbxDestination;
        private System.Windows.Forms.Button btnGetRoute;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.Button btnReadMe;
        private System.Windows.Forms.CheckBox chbxJapanese;
        private System.Windows.Forms.ComboBox cbxItemType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDetailSource;
        private System.Windows.Forms.Button btnDetailDestination;
        private System.Windows.Forms.Button btnSearchSource;
        private System.Windows.Forms.Button btnSearchType;
        private System.Windows.Forms.Label lblLoading;
    }
}

