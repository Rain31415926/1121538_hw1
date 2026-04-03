using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1121538_徐霈綺_房貸計算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbDownPaymentType.SelectedIndex = 0;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtTotalHousePrice.Text, out double _totalHousePriceRaw) || _totalHousePriceRaw <= 0)
            {
                MessageBox.Show("請輸入正確的房屋總價 (必須大於 0)。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotalHousePrice.Focus();
                return;
            }
            double totalHousePrice = _totalHousePriceRaw * 10000;

            if (!double.TryParse(txtDownPayment.Text, out double downPaymentVal) || downPaymentVal < 0)
            {
                MessageBox.Show("請輸入正確的自備款數值 (不能為負數)。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDownPayment.Focus();
                return;
            }

            if (!double.TryParse(txtAnnualInterestRate.Text, out double annualRate) || annualRate < 0)
            {
                MessageBox.Show("請輸入正確的貸款年利率 (不能為負數)。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnnualInterestRate.Focus();
                return;
            }

            if (!int.TryParse(txtLoanTerm.Text, out int loanTermYears) || loanTermYears <= 0)
            {
                MessageBox.Show("請輸入正確的貸款年限 (必須大於 0)。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLoanTerm.Focus();
                return;
            }
            
            int gracePeriodYears = 0;
            if (!string.IsNullOrWhiteSpace(txtGracePeriod.Text))
            {
                if (!int.TryParse(txtGracePeriod.Text, out gracePeriodYears) || gracePeriodYears < 0)
                {
                    MessageBox.Show("請輸入正確的寬限期年數 (不能為負數)，或留空。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGracePeriod.Focus();
                    return;
                }
            }

            double downPayment = 0;
            if (cmbDownPaymentType.SelectedIndex == 0) // Percentage
            {
                if (downPaymentVal >= 100)
                {
                    MessageBox.Show("自備款比例不能大於或等於 100%。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDownPayment.Focus();
                    return;
                }
                downPayment = totalHousePrice * (downPaymentVal / 100.0);
            }
            else // Amount
            {
                downPayment = downPaymentVal;
            }

            double principal = totalHousePrice - downPayment;
            if (principal <= 0)
            {
                MessageBox.Show("自備款大於或等於房屋總價，無需貸款。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDownPayment.Focus();
                return;
            }

            if (gracePeriodYears >= loanTermYears)
            {
                MessageBox.Show("寬限期必須小於貸款年限。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGracePeriod.Focus();
                return;
            }

            int totalMonths = loanTermYears * 12;
            int graceMonths = gracePeriodYears * 12;
            int amortMonths = totalMonths - graceMonths;

            double monthlyRate = annualRate / 100.0 / 12.0;

            double graceMonthlyPayment = 0;
            double amortMonthlyPayment = 0;
            
            if (monthlyRate > 0)
            {
                graceMonthlyPayment = principal * monthlyRate;
                double ratePow = Math.Pow(1 + monthlyRate, amortMonths);
                amortMonthlyPayment = principal * (monthlyRate * ratePow) / (ratePow - 1);
            }
            else
            {
                graceMonthlyPayment = 0;
                amortMonthlyPayment = principal / amortMonths;
            }

            double totalInterest = 0;
            double totalRepayment = 0;
            double firstMonthInterest = 0;
            double firstMonthPrincipal = 0;

            if (graceMonths > 0)
            {
                firstMonthInterest = principal * monthlyRate;
                firstMonthPrincipal = 0;
                totalInterest = (graceMonthlyPayment * graceMonths) + (amortMonthlyPayment * amortMonths - principal);
                lblMonthlyPayment.Text = $"每月應繳金額: 寬限期內 {graceMonthlyPayment:N2} 元 / 寬限期後 {amortMonthlyPayment:N2} 元";
            }
            else
            {
                firstMonthInterest = principal * monthlyRate;
                firstMonthPrincipal = amortMonthlyPayment - firstMonthInterest;
                totalInterest = (amortMonthlyPayment * totalMonths) - principal;
                lblMonthlyPayment.Text = $"每月應繳金額: {amortMonthlyPayment:N2} 元";
            }

            totalRepayment = principal + totalInterest;

            lblTotalLoanAmount.Text = $"貸款總金額: {principal:N2} 元";
            lblFirstMonthDetails.Text = $"首期利息: {firstMonthInterest:N2} 元 / 首期本金: {firstMonthPrincipal:N2} 元";
            lblTotalInterest.Text = $"總利息支出: {totalInterest:N2} 元";
            lblTotalRepayment.Text = $"總還款金額: {totalRepayment:N2} 元";

            // 加入至歷史紀錄
            var record = new CalculationRecord
            {
                TotalHousePrice = _totalHousePriceRaw,
                DownPaymentType = cmbDownPaymentType.SelectedIndex,
                DownPayment = downPaymentVal,
                AnnualRate = annualRate,
                LoanTerm = loanTermYears,
                GracePeriod = gracePeriodYears
            };
            lstHistory.Items.Add(record);
        }

        private void BtnApplyHistory_Click(object sender, EventArgs e)
        {
            if (lstHistory.SelectedItem is CalculationRecord record)
            {
                txtTotalHousePrice.Text = record.TotalHousePrice.ToString();
                cmbDownPaymentType.SelectedIndex = record.DownPaymentType;
                txtDownPayment.Text = record.DownPayment.ToString();
                txtAnnualInterestRate.Text = record.AnnualRate.ToString();
                txtLoanTerm.Text = record.LoanTerm.ToString();
                txtGracePeriod.Text = record.GracePeriod.ToString();
            }
            else
            {
                MessageBox.Show("請先選擇一筆歷史紀錄。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            string helpMessage = "【各項名詞說明】\n\n" +
                                 "房屋總價: 欲購買房屋的總價格。\n" +
                                 "自備款比例/金額: 購屋時自己準備的付款金額，可依金額或佔總價的百分比輸入。\n" +
                                 "貸款年利率: 銀行提供的貸款年利率。\n" +
                                 "貸款年限: 預計還款的總年數。\n" +
                                 "寬限期: 在此期間內只需繳交利息，不需攤還本金。設定寬限期會導致寬限期後每月的還款金額增加。\n" +
                                 "貸款總金額: 房屋總價扣除自備款後的實際貸款金額。";
            MessageBox.Show(helpMessage, "註解", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtTotalHousePrice.Text = "";
            cmbDownPaymentType.SelectedIndex = 0;
            txtDownPayment.Text = "20";
            txtAnnualInterestRate.Text = "2.15";
            txtLoanTerm.Text = "30";
            txtGracePeriod.Text = "0";

            lblTotalLoanAmount.Text = "貸款總金額:";
            lblMonthlyPayment.Text = "每月應繳金額:";
            lblFirstMonthDetails.Text = "首期利息與本金:";
            lblTotalInterest.Text = "總利息支出:";
            lblTotalRepayment.Text = "總還款金額:";
        }

        private class CalculationRecord
        {
            public double TotalHousePrice { get; set; }
            public int DownPaymentType { get; set; }
            public double DownPayment { get; set; }
            public double AnnualRate { get; set; }
            public int LoanTerm { get; set; }
            public int GracePeriod { get; set; }

            public override string ToString()
            {
                string typeStr = DownPaymentType == 0 ? "%" : "元";
                return $"總價:{TotalHousePrice}萬, 自備:{DownPayment}{typeStr}, 利率:{AnnualRate}%, {LoanTerm}年";
            }
        }
    }
}
