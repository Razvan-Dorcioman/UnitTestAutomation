using System;
using System.Windows.Forms;

namespace AutomationTests
{
    public partial class MainForm : Form
    {
        private readonly ConversionRate _conversionRate;

        public MainForm()
        {
            InitializeComponent();
            InitializeAdditionalComponent();

            _conversionRate = new ConversionRate();
        }

        private void InitializeAdditionalComponent()
        {
            firstComboBox.SelectedIndex = 0;
            secondComboBox.SelectedIndex = 1;
        }

        private void secondTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(secondTextBox.Text))
            {
                firstTexBox.Text = "";
                conversionRateText.Text = "0";

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
                firstTexBox.Text = res.ToString();
                conversionRateText.Text = convRate.ToString();
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

        private void firstTexBox_TextChanged(object sender, EventArgs e)
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
                secondTextBox.Text = res.ToString();
                conversionRateText.Text = convRate.ToString();
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