using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationTests
{
    public partial class MainForm : Form
    {
        public Taxes taxes;
        public MainForm()
        {
            InitializeComponent();
            taxes = new Taxes();
            realEstateInvestmentsRadioButton.Checked = true;
            equalMonthlyRateRadioButton.Checked = true;
        }

        private void homePriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (homePriceTextBox.Text == "")
            {
                taxes.SetHomePrice("0");
            }
            else
            {
                taxes.SetHomePrice(homePriceTextBox.Text);

            }
            
            downPaymentTextBox1.Text = taxes.calculateDownPaymentByProcent(Convert.ToDecimal(downPaymentNumericUpDown.Text));
            CheckAndCalculateRate();
        }

        private void firstHomeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            taxes.SetRateType("firstHome");
            decreasingMonthlyRateRadioButton.Visible = false;
            equalMonthlyRateRadioButton.Checked = true;
            moneyToInvestLTextBox.Visible = true;
            moneyToInvestLabel.Visible = true;
            CheckAndCalculateRate();
        }

        private void realEstateInvestmentsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            taxes.SetRateType("realEstateInvestments");
            moneyToInvestLTextBox.Visible = false;
            moneyToInvestLabel.Visible = false;
            decreasingMonthlyRateRadioButton.Visible = true;
            CheckAndCalculateRate();
        }

        private void downPaymentTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (taxes.ValidateDownPayment(downPaymentTextBox1.Text, homePriceTextBox.Text))
            {
                taxes.SetDownPayment(downPaymentTextBox1.Text);
                downPaymentNumericUpDown.Value = taxes.calculateDownPaymentProcent();
                taxes.SetDownPaymentPercentage(downPaymentNumericUpDown.Value);
                CheckAndCalculateRate();
            }
            else
            {
                MessageBox.Show("Invalid input for down payment.");
                downPaymentTextBox1.Text = "";
                //validate after 1 sec
            }
        }
        private void downPaymentNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if(taxes.ValidateDownPaymentProcent(downPaymentNumericUpDown.Value))
            {
                taxes.SetDownPaymentPercentage(downPaymentNumericUpDown.Value);
                downPaymentTextBox1.Text = taxes.calculateDownPayment();
                CheckAndCalculateRate();
            }
            else
            {
                MessageBox.Show("Invalid input for down payment procent");
                downPaymentNumericUpDown.Value = firstHomeRadioButton.Checked ? 5 : 15;
            }
            //validate after 1 sec
            
        }

        private void lengthOfLoanNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            taxes.SetLengthOfLoan(lengthOfLoanNumericUpDown.Value);
            CheckAndCalculateRate();
        }

        private void interestRateTextBox_TextChanged(object sender, EventArgs e)
        {
            if(taxes.validateInterestRate(interestRateTextBox.Text))
            {
                CheckAndCalculateRate();
            }
            else
            {
                interestRateTextBox.Text = "";
                MessageBox.Show("invalid interest rate");
            }
        }

        private void equalMonthlyRateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            taxes.SetRateMonthlyType("equal");
            monthlyCreditRateButton.Visible = false;
            CheckAndCalculateRate();
        }

        private void decreasingMonthlyRateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            taxes.SetRateMonthlyType("decreasing");
            monthlyCreditRateButton.Visible = true;
            CheckAndCalculateRate();

        }

        private void monthlyCreditRateButton_Click(object sender, EventArgs e)
        {
            if(monthlyCreditRateTextBox.Text != "")
            {
                TableForm tableForm = new TableForm(taxes.creditRateDecreasing);
                tableForm.Show();
                tableForm.PopulateTable();
            }
        }

        private void CheckAndCalculateRate()
        {
            
            if (taxes.CheckIfPropsAreEmpthy())
            {
                taxes.CalculateRate();
                if (taxes.GetTotalAmountPayable() != "")
                {
                    monthlyCreditRateTextBox.Text = taxes.GetMonthlyCreditRate();
                    totalAmountPayableTextBox.Text = taxes.GetTotalAmountPayable();

                    if(decreasingMonthlyRateRadioButton.Checked)
                    {
                        monthlyCreditRateButton.Enabled = true;
                    }

                    if(firstHomeRadioButton.Checked)
                    {
                        moneyToInvestLTextBox.Text = Convert.ToString(taxes.differenceFirstHome);
                    }
                }
            }
        }
    }
}
