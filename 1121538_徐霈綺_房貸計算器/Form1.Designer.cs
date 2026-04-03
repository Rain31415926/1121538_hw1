namespace _1121538_徐霈綺_房貸計算器
{
    partial class Form1
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
            this.lblTotalHousePrice = new System.Windows.Forms.Label();
            this.txtTotalHousePrice = new System.Windows.Forms.TextBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.lblDownPaymentType = new System.Windows.Forms.Label();
            this.cmbDownPaymentType = new System.Windows.Forms.ComboBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.lblAnnualInterestRate = new System.Windows.Forms.Label();
            this.txtAnnualInterestRate = new System.Windows.Forms.TextBox();
            this.lblLoanTerm = new System.Windows.Forms.Label();
            this.txtLoanTerm = new System.Windows.Forms.TextBox();
            this.lblGracePeriod = new System.Windows.Forms.Label();
            this.txtGracePeriod = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.lblTotalLoanAmount = new System.Windows.Forms.Label();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.lblFirstMonthDetails = new System.Windows.Forms.Label();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.lblTotalRepayment = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblHistory = new System.Windows.Forms.Label();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.btnApplyHistory = new System.Windows.Forms.Button();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalHousePrice
            // 
            this.lblTotalHousePrice.AutoSize = true;
            this.lblTotalHousePrice.Location = new System.Drawing.Point(30, 30);
            this.lblTotalHousePrice.Name = "lblTotalHousePrice";
            this.lblTotalHousePrice.Size = new System.Drawing.Size(133, 15);
            this.lblTotalHousePrice.TabIndex = 0;
            this.lblTotalHousePrice.Text = "房屋總價 (萬元)(&P):";
            // 
            // txtTotalHousePrice
            // 
            this.txtTotalHousePrice.Location = new System.Drawing.Point(179, 27);
            this.txtTotalHousePrice.Name = "txtTotalHousePrice";
            this.txtTotalHousePrice.Size = new System.Drawing.Size(150, 25);
            this.txtTotalHousePrice.TabIndex = 1;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(340, 30);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(41, 15);
            this.lblCurrency.TabIndex = 18;
            this.lblCurrency.Text = "幣值:";
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Items.AddRange(new object[] {
            "新台幣 (TWD)",
            "美元 (USD)",
            "日圓 (JPY)",
            "歐元 (EUR)",
            "人民幣 (CNY)"});
            this.cmbCurrency.Location = new System.Drawing.Point(391, 27);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(90, 23);
            this.cmbCurrency.TabIndex = 19;
            // 
            // lblDownPaymentType
            // 
            this.lblDownPaymentType.AutoSize = true;
            this.lblDownPaymentType.Location = new System.Drawing.Point(30, 70);
            this.lblDownPaymentType.Name = "lblDownPaymentType";
            this.lblDownPaymentType.Size = new System.Drawing.Size(106, 15);
            this.lblDownPaymentType.TabIndex = 2;
            this.lblDownPaymentType.Text = "自備款方式(&D):";
            // 
            // cmbDownPaymentType
            // 
            this.cmbDownPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDownPaymentType.FormattingEnabled = true;
            this.cmbDownPaymentType.Items.AddRange(new object[] {
            "比例 (%)",
            "金額 (元)"});
            this.cmbDownPaymentType.Location = new System.Drawing.Point(179, 67);
            this.cmbDownPaymentType.Name = "cmbDownPaymentType";
            this.cmbDownPaymentType.Size = new System.Drawing.Size(90, 23);
            this.cmbDownPaymentType.TabIndex = 3;
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Location = new System.Drawing.Point(280, 67);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(150, 25);
            this.txtDownPayment.TabIndex = 4;
            this.txtDownPayment.Text = "20";
            // 
            // lblAnnualInterestRate
            // 
            this.lblAnnualInterestRate.AutoSize = true;
            this.lblAnnualInterestRate.Location = new System.Drawing.Point(30, 110);
            this.lblAnnualInterestRate.Name = "lblAnnualInterestRate";
            this.lblAnnualInterestRate.Size = new System.Drawing.Size(131, 15);
            this.lblAnnualInterestRate.TabIndex = 5;
            this.lblAnnualInterestRate.Text = "貸款年利率 (%)(&R):";
            // 
            // txtAnnualInterestRate
            // 
            this.txtAnnualInterestRate.Location = new System.Drawing.Point(179, 107);
            this.txtAnnualInterestRate.Name = "txtAnnualInterestRate";
            this.txtAnnualInterestRate.Size = new System.Drawing.Size(150, 25);
            this.txtAnnualInterestRate.TabIndex = 6;
            this.txtAnnualInterestRate.Text = "2.15";
            // 
            // lblLoanTerm
            // 
            this.lblLoanTerm.AutoSize = true;
            this.lblLoanTerm.Location = new System.Drawing.Point(30, 150);
            this.lblLoanTerm.Name = "lblLoanTerm";
            this.lblLoanTerm.Size = new System.Drawing.Size(119, 15);
            this.lblLoanTerm.TabIndex = 7;
            this.lblLoanTerm.Text = "貸款年限 (年)(&T):";
            // 
            // txtLoanTerm
            // 
            this.txtLoanTerm.Location = new System.Drawing.Point(179, 147);
            this.txtLoanTerm.Name = "txtLoanTerm";
            this.txtLoanTerm.Size = new System.Drawing.Size(150, 25);
            this.txtLoanTerm.TabIndex = 8;
            this.txtLoanTerm.Text = "30";
            // 
            // lblGracePeriod
            // 
            this.lblGracePeriod.AutoSize = true;
            this.lblGracePeriod.Location = new System.Drawing.Point(30, 190);
            this.lblGracePeriod.Name = "lblGracePeriod";
            this.lblGracePeriod.Size = new System.Drawing.Size(143, 15);
            this.lblGracePeriod.TabIndex = 9;
            this.lblGracePeriod.Text = "寬限期 (年, 選填)(&G):";
            // 
            // txtGracePeriod
            // 
            this.txtGracePeriod.Location = new System.Drawing.Point(179, 187);
            this.txtGracePeriod.Name = "txtGracePeriod";
            this.txtGracePeriod.Size = new System.Drawing.Size(150, 25);
            this.txtGracePeriod.TabIndex = 10;
            this.txtGracePeriod.Text = "0";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(206, 230);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(90, 40);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "計算(&C)";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(360, 230);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(90, 40);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.Text = "註解(&H)";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.lblTotalLoanAmount);
            this.groupBoxResult.Controls.Add(this.lblMonthlyPayment);
            this.groupBoxResult.Controls.Add(this.lblFirstMonthDetails);
            this.groupBoxResult.Controls.Add(this.lblTotalInterest);
            this.groupBoxResult.Controls.Add(this.lblTotalRepayment);
            this.groupBoxResult.Location = new System.Drawing.Point(30, 290);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(460, 240);
            this.groupBoxResult.TabIndex = 12;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "計算結果";
            // 
            // lblTotalLoanAmount
            // 
            this.lblTotalLoanAmount.AutoSize = true;
            this.lblTotalLoanAmount.Location = new System.Drawing.Point(20, 30);
            this.lblTotalLoanAmount.Name = "lblTotalLoanAmount";
            this.lblTotalLoanAmount.Size = new System.Drawing.Size(86, 15);
            this.lblTotalLoanAmount.TabIndex = 0;
            this.lblTotalLoanAmount.Text = "貸款總金額:";
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(20, 70);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(101, 15);
            this.lblMonthlyPayment.TabIndex = 1;
            this.lblMonthlyPayment.Text = "每月應繳金額:";
            // 
            // lblFirstMonthDetails
            // 
            this.lblFirstMonthDetails.AutoSize = true;
            this.lblFirstMonthDetails.Location = new System.Drawing.Point(20, 110);
            this.lblFirstMonthDetails.Name = "lblFirstMonthDetails";
            this.lblFirstMonthDetails.Size = new System.Drawing.Size(116, 15);
            this.lblFirstMonthDetails.TabIndex = 2;
            this.lblFirstMonthDetails.Text = "首期利息與本金:";
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Location = new System.Drawing.Point(20, 150);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(86, 15);
            this.lblTotalInterest.TabIndex = 3;
            this.lblTotalInterest.Text = "總利息支出:";
            // 
            // lblTotalRepayment
            // 
            this.lblTotalRepayment.AutoSize = true;
            this.lblTotalRepayment.Location = new System.Drawing.Point(20, 190);
            this.lblTotalRepayment.Name = "lblTotalRepayment";
            this.lblTotalRepayment.Size = new System.Drawing.Size(86, 15);
            this.lblTotalRepayment.TabIndex = 4;
            this.lblTotalRepayment.Text = "總還款金額:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(66, 230);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 40);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "重置(&E)";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Location = new System.Drawing.Point(520, 30);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(71, 15);
            this.lblHistory.TabIndex = 15;
            this.lblHistory.Text = "歷史紀錄:";
            // 
            // lstHistory
            // 
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 15;
            this.lstHistory.Location = new System.Drawing.Point(520, 50);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(280, 424);
            this.lstHistory.TabIndex = 16;
            this.lstHistory.DoubleClick += new System.EventHandler(this.BtnApplyHistory_Click);
            // 
            // btnApplyHistory
            // 
            this.btnApplyHistory.Location = new System.Drawing.Point(520, 490);
            this.btnApplyHistory.Name = "btnApplyHistory";
            this.btnApplyHistory.Size = new System.Drawing.Size(280, 40);
            this.btnApplyHistory.TabIndex = 17;
            this.btnApplyHistory.Text = "套用選取紀錄";
            this.btnApplyHistory.UseVisualStyleBackColor = true;
            this.btnApplyHistory.Click += new System.EventHandler(this.BtnApplyHistory_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 560);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.btnApplyHistory);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtGracePeriod);
            this.Controls.Add(this.lblGracePeriod);
            this.Controls.Add(this.txtLoanTerm);
            this.Controls.Add(this.lblLoanTerm);
            this.Controls.Add(this.txtAnnualInterestRate);
            this.Controls.Add(this.lblAnnualInterestRate);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.cmbDownPaymentType);
            this.Controls.Add(this.lblDownPaymentType);
            this.Controls.Add(this.txtTotalHousePrice);
            this.Controls.Add(this.lblTotalHousePrice);
            this.Name = "Form1";
            this.Text = "個人房貸試算器";
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label lblTotalHousePrice;
        private System.Windows.Forms.TextBox txtTotalHousePrice;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Label lblDownPaymentType;
        private System.Windows.Forms.ComboBox cmbDownPaymentType;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.Label lblAnnualInterestRate;
        private System.Windows.Forms.TextBox txtAnnualInterestRate;
        private System.Windows.Forms.Label lblLoanTerm;
        private System.Windows.Forms.TextBox txtLoanTerm;
        private System.Windows.Forms.Label lblGracePeriod;
        private System.Windows.Forms.TextBox txtGracePeriod;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Label lblTotalLoanAmount;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Label lblFirstMonthDetails;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.Label lblTotalRepayment;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Button btnApplyHistory;
    }
}

