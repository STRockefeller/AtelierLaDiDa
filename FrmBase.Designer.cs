namespace AtelierLaDiDa
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.btnReadMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxSeriesName
            // 
            this.cbxSeriesName.FormattingEnabled = true;
            this.cbxSeriesName.Location = new System.Drawing.Point(96, 20);
            this.cbxSeriesName.Name = "cbxSeriesName";
            this.cbxSeriesName.Size = new System.Drawing.Size(62, 23);
            this.cbxSeriesName.TabIndex = 0;
            this.cbxSeriesName.SelectedIndexChanged += new System.EventHandler(this.cbxSeriesName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Series Name";
            // 
            // lblSeriesName
            // 
            this.lblSeriesName.AutoSize = true;
            this.lblSeriesName.Location = new System.Drawing.Point(165, 23);
            this.lblSeriesName.Name = "lblSeriesName";
            this.lblSeriesName.Size = new System.Drawing.Size(89, 15);
            this.lblSeriesName.TabIndex = 2;
            this.lblSeriesName.Text = "lblSeriesName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Source";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Destination";
            // 
            // cbxSource
            // 
            this.cbxSource.FormattingEnabled = true;
            this.cbxSource.Location = new System.Drawing.Point(96, 92);
            this.cbxSource.Name = "cbxSource";
            this.cbxSource.Size = new System.Drawing.Size(121, 23);
            this.cbxSource.TabIndex = 5;
            // 
            // cbxDestination
            // 
            this.cbxDestination.FormattingEnabled = true;
            this.cbxDestination.Location = new System.Drawing.Point(96, 128);
            this.cbxDestination.Name = "cbxDestination";
            this.cbxDestination.Size = new System.Drawing.Size(121, 23);
            this.cbxDestination.TabIndex = 6;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(8, 53);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(464, 488);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(8, 167);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tbxResult
            // 
            this.tbxResult.Location = new System.Drawing.Point(545, 12);
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.ReadOnly = true;
            this.tbxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxResult.Size = new System.Drawing.Size(513, 499);
            this.tbxResult.TabIndex = 10;
            // 
            // btnReadMe
            // 
            this.btnReadMe.Location = new System.Drawing.Point(15, 488);
            this.btnReadMe.Name = "btnReadMe";
            this.btnReadMe.Size = new System.Drawing.Size(75, 23);
            this.btnReadMe.TabIndex = 11;
            this.btnReadMe.Text = "Read Me";
            this.btnReadMe.UseVisualStyleBackColor = true;
            this.btnReadMe.Visible = false;
            this.btnReadMe.Click += new System.EventHandler(this.btnReadMe_Click);
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 537);
            this.Controls.Add(this.btnReadMe);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cbxDestination);
            this.Controls.Add(this.cbxSource);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSeriesName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSeriesName);
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
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.Button btnReadMe;
    }
}

