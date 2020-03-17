﻿using System;
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
            Label lblLabel1 = new Label();
            Label lblLabel2 = new Label();
            lblLabel1.Text = "Luna";
            lblLabel2.Text = "Rata";
            lblLabel1.Font = new Font("Verdana", 8, FontStyle.Bold | FontStyle.Regular);
            lblLabel2.Font = new Font("Verdana", 8, FontStyle.Bold | FontStyle.Regular);
            lblLabel1.Height = 20;
            lblLabel2.Height = 20;
            RateTable.Controls.Add(lblLabel1, 0, 0);
            RateTable.Controls.Add(lblLabel2, 1, 0);

            RateTable.RowCount = creditRateDecreasing.Length;
            for (int i = 0; i<creditRateDecreasing.Length; i++)
            {
                RateTable.Controls.Add(new Label() { Text = Convert.ToString(i + 1), Height = 20 }, 0, i + 1) ;
                RateTable.Controls.Add(new Label() { Text = Convert.ToString(creditRateDecreasing[i]), Height = 20 }, 1, i + 1);
            }
            
        }

        private void RateTable_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
