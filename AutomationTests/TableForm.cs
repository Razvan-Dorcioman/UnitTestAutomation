using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Windows.Forms;

namespace AutomationTests
{
    [ExcludeFromCodeCoverage]
    public partial class TableForm : Form
    {
        public decimal[] creditRateDecreasing;

        public TableForm(decimal[] value)
        {
            InitializeComponent();
            creditRateDecreasing = value;
        }

        public void PopulateTable()
        {
            var lblLabel1 = new Label();
            var lblLabel2 = new Label();
            lblLabel1.Text = "Luna";
            lblLabel2.Text = "Rata";
            lblLabel1.Font = new Font("Verdana", 8, FontStyle.Bold | FontStyle.Regular);
            lblLabel2.Font = new Font("Verdana", 8, FontStyle.Bold | FontStyle.Regular);
            lblLabel1.Height = 20;
            lblLabel2.Height = 20;
            RateTable.Controls.Add(lblLabel1, 0, 0);
            RateTable.Controls.Add(lblLabel2, 1, 0);

            RateTable.RowCount = creditRateDecreasing.Length;
            for (var i = 0; i < creditRateDecreasing.Length; i++)
            {
                RateTable.Controls.Add(new Label {Text = Convert.ToString(i + 1), Height = 20}, 0, i + 1);
                RateTable.Controls.Add(new Label {Text = Convert.ToString(creditRateDecreasing[i]), Height = 20}, 1,
                    i + 1);
            }
        }
    }
}