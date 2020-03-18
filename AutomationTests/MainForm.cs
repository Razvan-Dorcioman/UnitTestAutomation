using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows.Forms;

namespace AutomationTests
{
    [ExcludeFromCodeCoverage]
    public partial class MainForm : Form
    {
        private ConversionRate _conversionRate;
        public Calculator calculator;
        public Taxes taxes;

        public MainForm()
        {
            InitializeComponent();
            calculator = new Calculator();
            taxes = new Taxes();
            realEstateInvestmentsRadioButton.Checked = true;
            equalMonthlyRateRadioButton.Checked = true;
        }

        private void calculatorTabExpressionTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void calculatorTabCalculateExpressionButton_Click(object sender, EventArgs e)
        {
            var result = calculator.calculateBasic(calculatorTabExpressionTextBox.Text);
            calculatorTabResultLabel.Text = result;
        }

        private void homePriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (homePriceTextBox.Text == "")
                taxes.SetHomePrice("0");
            else
                taxes.SetHomePrice(homePriceTextBox.Text);

            downPaymentTextBox1.Text = taxes.calculateDownPaymentByProcent(downPaymentNumericUpDown.Text);
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
            if (taxes.ValidateDownPaymentProcent(downPaymentNumericUpDown.Value) == false)
            {
                MessageBox.Show("Invalid input for down payment procent");
                downPaymentNumericUpDown.Value = firstHomeRadioButton.Checked ? 5 : 15;
            }

            moneyToInvestLTextBox.Visible = false;
            moneyToInvestLabel.Visible = false;
            decreasingMonthlyRateRadioButton.Visible = true;
            CheckAndCalculateRate();
        }

        private async void downPaymentTextBox1_TextChanged(object sender, EventArgs e)
        {
            var dpbox = sender as TextBox;
            if (await dpbox.GetIdle(500))
                if (downPaymentTextBox1.Text != "")
                    if (homePriceTextBox.Text != "")
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
                        }
                    }
        }

        private async void downPaymentNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            var dppnupdown = sender as NumericUpDown;
            if (await dppnupdown.GetIdle(500))
            {
                if (taxes.ValidateDownPaymentProcent(downPaymentNumericUpDown.Value))
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
            }
        }

        private void lengthOfLoanNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            taxes.SetLengthOfLoan(lengthOfLoanNumericUpDown.Value);
            CheckAndCalculateRate();
        }

        private async void interestRateTextBox_TextChanged(object sender, EventArgs e)
        {
            var dpbox = sender as TextBox;
            if (await dpbox.GetIdle())
            {
                if (taxes.validateInterestRate(interestRateTextBox.Text) && interestRateTextBox.Text != "")
                {
                    CheckAndCalculateRate();
                }
                else
                {
                    if (interestRateTextBox.Text != "")
                    {
                        interestRateTextBox.Text = "";
                        MessageBox.Show("invalid interest rate");
                    }
                }
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
            if (monthlyCreditRateTextBox.Text != "")
            {
                var tableForm = new TableForm(taxes.creditRateDecreasing);
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

                    if (decreasingMonthlyRateRadioButton.Checked) monthlyCreditRateButton.Enabled = true;

                    if (firstHomeRadioButton.Checked)
                        moneyToInvestLTextBox.Text = Convert.ToString(taxes.differenceFirstHome);
                }
            }

            InitializeAdditionalComponent();

            _conversionRate = new ConversionRate();
        }

        private void InitializeAdditionalComponent()
        {
            firstComboBox.SelectedIndex = 0;
            secondComboBox.SelectedIndex = 1;
        }

        private async void secondTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(secondTextBox.Text))
            {
                firstTexBox.Text = "";
                conversionRateText.Text = @"0";

                return;
            }

            firstTexBox.TextChanged -= firstTexBox_TextChanged;

            var firstText = secondTextBox.Text;
            var firstCombo = secondComboBox.SelectedItem.ToString();
            var secondCombo = firstComboBox.SelectedItem.ToString();

            double convRate;

            var res = _conversionRate.Convert(firstText, firstCombo, secondCombo, out convRate);

            if (res != -1)
            {
                ConversionRate.Inverse = true;
                firstTexBox.Text = res.ToString(CultureInfo.InvariantCulture);
                conversionRateText.Text = convRate.ToString(CultureInfo.InvariantCulture);

                var textbox = secondTextBox;

                if (await textbox.GetIdle())
                    _conversionRate.SaveHistory(firstComboBox.SelectedItem + " " + firstTexBox.Text + " <- " +
                                                secondTextBox.Text + " " + secondComboBox.SelectedItem);
            }
            else
            {
                ConversionRate.Inverse = false;
                firstTexBox.Text = "";
                secondTextBox.Text = "";
                conversionRateText.Text = "";
            }

            firstTexBox.TextChanged += firstTexBox_TextChanged;
        }

        private async void firstTexBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstTexBox.Text))
            {
                secondTextBox.Text = "";
                conversionRateText.Text = "0";

                return;
            }

            secondTextBox.TextChanged -= secondTextBox_TextChanged;

            var firstText = firstTexBox.Text;
            var firstCombo = firstComboBox.SelectedItem.ToString();
            var secondCombo = secondComboBox.SelectedItem.ToString();

            var res = _conversionRate.Convert(firstText, firstCombo, secondCombo, out var convRate);

            if (res != -1)
            {
                ConversionRate.Inverse = false;
                secondTextBox.Text = res.ToString(CultureInfo.InvariantCulture);
                conversionRateText.Text = convRate.ToString(CultureInfo.InvariantCulture);

                var textbox = firstTexBox;

                if (await textbox.GetIdle())
                    _conversionRate.SaveHistory(firstComboBox.SelectedItem + " " + firstTexBox.Text + " -> " +
                                                secondTextBox.Text + " " + secondComboBox.SelectedItem);
            }
            else
            {
                ConversionRate.Inverse = false;
                firstTexBox.Text = "";
                secondTextBox.Text = "";
                conversionRateText.Text = "";
            }

            secondTextBox.TextChanged += secondTextBox_TextChanged;
        }

        private void firstComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ConversionRate.Inverse == false)
                firstTexBox_TextChanged(sender, e);
            else
                secondTextBox_TextChanged(sender, e);
        }

        private void secondComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ConversionRate.Inverse == false)
                firstTexBox_TextChanged(sender, e);
            else
                secondTextBox_TextChanged(sender, e);
        }
    }
}