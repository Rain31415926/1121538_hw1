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
            
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.lblTotalLoanAmount = new System.Windows.Forms.Label();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.lblFirstMonthDetails = new System.Windows.Forms.Label();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.lblTotalRepayment = new System.Windows.Forms.Label();

            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();

            // lblTotalHousePrice
            this.lblTotalHousePrice.AutoSize = true;
            this.lblTotalHousePrice.Location = new System.Drawing.Point(30, 30);
            this.lblTotalHousePrice.Name = "lblTotalHousePrice";
            this.lblTotalHousePrice.Size = new System.Drawing.Size(120, 15);
            this.lblTotalHousePrice.TabIndex = 0;
            this.lblTotalHousePrice.Text = "房屋總價 (元):";

            // txtTotalHousePrice
            this.txtTotalHousePrice.Location = new System.Drawing.Point(180, 27);
            this.txtTotalHousePrice.Name = "txtTotalHousePrice";
            this.txtTotalHousePrice.Size = new System.Drawing.Size(150, 25);
            this.txtTotalHousePrice.TabIndex = 1;

            // lblDownPaymentType
            this.lblDownPaymentType.AutoSize = true;
            this.lblDownPaymentType.Location = new System.Drawing.Point(30, 70);
            this.lblDownPaymentType.Name = "lblDownPaymentType";
            this.lblDownPaymentType.Size = new System.Drawing.Size(120, 15);
            this.lblDownPaymentType.TabIndex = 2;
            this.lblDownPaymentType.Text = "自備款方式:";

            // cmbDownPaymentType
            this.cmbDownPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDownPaymentType.FormattingEnabled = true;
            this.cmbDownPaymentType.Items.AddRange(new object[] { "比例 (%)", "金額 (元)" });
            this.cmbDownPaymentType.Location = new System.Drawing.Point(180, 67);
            this.cmbDownPaymentType.Name = "cmbDownPaymentType";
            this.cmbDownPaymentType.Size = new System.Drawing.Size(90, 23);
            this.cmbDownPaymentType.TabIndex = 3;
            this.cmbDownPaymentType.SelectedIndex = 0;

            // txtDownPayment
            this.txtDownPayment.Location = new System.Drawing.Point(280, 67);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(150, 25);
            this.txtDownPayment.TabIndex = 4;
            this.txtDownPayment.Text = "20";

            // lblAnnualInterestRate
            this.lblAnnualInterestRate.AutoSize = true;
            this.lblAnnualInterestRate.Location = new System.Drawing.Point(30, 110);
            this.lblAnnualInterestRate.Name = "lblAnnualInterestRate";
            this.lblAnnualInterestRate.Size = new System.Drawing.Size(120, 15);
            this.lblAnnualInterestRate.TabIndex = 5;
            this.lblAnnualInterestRate.Text = "貸款年利率 (%):";

            // txtAnnualInterestRate
            this.txtAnnualInterestRate.Location = new System.Drawing.Point(180, 107);
            this.txtAnnualInterestRate.Name = "txtAnnualInterestRate";
            this.txtAnnualInterestRate.Size = new System.Drawing.Size(150, 25);
            this.txtAnnualInterestRate.TabIndex = 6;
            this.txtAnnualInterestRate.Text = "2.15";

            // lblLoanTerm
            this.lblLoanTerm.AutoSize = true;
            this.lblLoanTerm.Location = new System.Drawing.Point(30, 150);
            this.lblLoanTerm.Name = "lblLoanTerm";
            this.lblLoanTerm.Size = new System.Drawing.Size(120, 15);
            this.lblLoanTerm.TabIndex = 7;
            this.lblLoanTerm.Text = "貸款年限 (年):";

            // txtLoanTerm
            this.txtLoanTerm.Location = new System.Drawing.Point(180, 147);
            this.txtLoanTerm.Name = "txtLoanTerm";
            this.txtLoanTerm.Size = new System.Drawing.Size(150, 25);
            this.txtLoanTerm.TabIndex = 8;
            this.txtLoanTerm.Text = "30";

            // lblGracePeriod
            this.lblGracePeriod.AutoSize = true;
            this.lblGracePeriod.Location = new System.Drawing.Point(30, 190);
            this.lblGracePeriod.Name = "lblGracePeriod";
            this.lblGracePeriod.Size = new System.Drawing.Size(120, 15);
            this.lblGracePeriod.TabIndex = 9;
            this.lblGracePeriod.Text = "寬限期 (年, 選填):";

            // txtGracePeriod
            this.txtGracePeriod.Location = new System.Drawing.Point(180, 187);
            this.txtGracePeriod.Name = "txtGracePeriod";
            this.txtGracePeriod.Size = new System.Drawing.Size(150, 25);
            this.txtGracePeriod.TabIndex = 10;
            this.txtGracePeriod.Text = "0";

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(180, 230);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 40);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "計算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);

            // groupBoxResult
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

            // lblTotalLoanAmount
            this.lblTotalLoanAmount.AutoSize = true;
            this.lblTotalLoanAmount.Location = new System.Drawing.Point(20, 30);
            this.lblTotalLoanAmount.Name = "lblTotalLoanAmount";
            this.lblTotalLoanAmount.Size = new System.Drawing.Size(90, 15);
            this.lblTotalLoanAmount.TabIndex = 0;
            this.lblTotalLoanAmount.Text = "貸款總金額:";

            // lblMonthlyPayment
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(20, 70);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(105, 15);
            this.lblMonthlyPayment.TabIndex = 1;
            this.lblMonthlyPayment.Text = "每月應繳金額:";

            // lblFirstMonthDetails
            this.lblFirstMonthDetails.AutoSize = true;
            this.lblFirstMonthDetails.Location = new System.Drawing.Point(20, 110);
            this.lblFirstMonthDetails.Name = "lblFirstMonthDetails";
            this.lblFirstMonthDetails.Size = new System.Drawing.Size(135, 15);
            this.lblFirstMonthDetails.TabIndex = 2;
            this.lblFirstMonthDetails.Text = "首期利息與本金:";

            // lblTotalInterest
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Location = new System.Drawing.Point(20, 150);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(90, 15);
            this.lblTotalInterest.TabIndex = 3;
            this.lblTotalInterest.Text = "總利息支出:";

            // lblTotalRepayment
            this.lblTotalRepayment.AutoSize = true;
            this.lblTotalRepayment.Location = new System.Drawing.Point(20, 190);
            this.lblTotalRepayment.Name = "lblTotalRepayment";
            this.lblTotalRepayment.Size = new System.Drawing.Size(90, 15);
            this.lblTotalRepayment.TabIndex = 4;
            this.lblTotalRepayment.Text = "總還款金額:";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 560);
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
    }
}

