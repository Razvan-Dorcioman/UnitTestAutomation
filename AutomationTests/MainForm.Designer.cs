namespace AutomationTests
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.calculatorTab = new System.Windows.Forms.TabPage();
            this.taxesTab = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.firstHomeRadioButton = new System.Windows.Forms.RadioButton();
            this.realEstateInvestmentsRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.equalMonthlyRateRadioButton = new System.Windows.Forms.RadioButton();
            this.decreasingMonthlyRateRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monthlyCreditRateButton = new System.Windows.Forms.Button();
            this.totalAmountPayableLabel = new System.Windows.Forms.Label();
            this.monthlyCreditRateLabel = new System.Windows.Forms.Label();
            this.totalAmountPayableTextBox = new System.Windows.Forms.TextBox();
            this.monthlyCreditRateTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.interestRateLabel2 = new System.Windows.Forms.Label();
            this.downPaymentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.downPaymentLabel2 = new System.Windows.Forms.Label();
            this.homePriceTextBox = new System.Windows.Forms.TextBox();
            this.homePriveLabel = new System.Windows.Forms.Label();
            this.lengthOfLoanNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.downPaymentLabel1 = new System.Windows.Forms.Label();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.downPaymentTextBox1 = new System.Windows.Forms.TextBox();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.lengthOfLoanLabel = new System.Windows.Forms.Label();
            this.conversionTab = new System.Windows.Forms.TabPage();
            this.secondComboBox = new System.Windows.Forms.ComboBox();
            this.firstComboBox = new System.Windows.Forms.ComboBox();
            this.secondTextBox = new System.Windows.Forms.TextBox();
            this.firstTexBox = new System.Windows.Forms.TextBox();
            this.conversionRateTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.conversionRateLabel = new System.Windows.Forms.Label();
            this.conversionRateText = new System.Windows.Forms.Label();
            this.moneyToInvestLTextBox = new System.Windows.Forms.TextBox();
            this.moneyToInvestLabel = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.taxesTab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downPaymentNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthOfLoanNumericUpDown)).BeginInit();
            this.conversionTab.SuspendLayout();
            this.conversionRateTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.calculatorTab);
            this.mainTabControl.Controls.Add(this.taxesTab);
            this.mainTabControl.Controls.Add(this.conversionTab);
            this.mainTabControl.Location = new System.Drawing.Point(13, 1);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1060, 554);
            this.mainTabControl.TabIndex = 0;
            // 
            // calculatorTab
            // 
            this.calculatorTab.Location = new System.Drawing.Point(4, 25);
            this.calculatorTab.Margin = new System.Windows.Forms.Padding(4);
            this.calculatorTab.Name = "calculatorTab";
            this.calculatorTab.Padding = new System.Windows.Forms.Padding(4);
            this.calculatorTab.Size = new System.Drawing.Size(1052, 525);
            this.calculatorTab.TabIndex = 0;
            this.calculatorTab.Text = "Calculator";
            this.calculatorTab.UseVisualStyleBackColor = true;
            // 
            // taxesTab
            // 
            this.taxesTab.Controls.Add(this.groupBox4);
            this.taxesTab.Controls.Add(this.groupBox3);
            this.taxesTab.Controls.Add(this.groupBox2);
            this.taxesTab.Controls.Add(this.groupBox1);
            this.taxesTab.Location = new System.Drawing.Point(4, 25);
            this.taxesTab.Margin = new System.Windows.Forms.Padding(4);
            this.taxesTab.Name = "taxesTab";
            this.taxesTab.Padding = new System.Windows.Forms.Padding(4);
            this.taxesTab.Size = new System.Drawing.Size(1052, 525);
            this.taxesTab.TabIndex = 1;
            this.taxesTab.Text = "Taxes";
            this.taxesTab.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.firstHomeRadioButton);
            this.groupBox4.Controls.Add(this.realEstateInvestmentsRadioButton);
            this.groupBox4.Location = new System.Drawing.Point(80, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(881, 111);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            // 
            // firstHomeRadioButton
            // 
            this.firstHomeRadioButton.AutoSize = true;
            this.firstHomeRadioButton.Location = new System.Drawing.Point(174, 51);
            this.firstHomeRadioButton.Name = "firstHomeRadioButton";
            this.firstHomeRadioButton.Size = new System.Drawing.Size(95, 21);
            this.firstHomeRadioButton.TabIndex = 2;
            this.firstHomeRadioButton.TabStop = true;
            this.firstHomeRadioButton.Text = "First home";
            this.firstHomeRadioButton.UseVisualStyleBackColor = true;
            this.firstHomeRadioButton.CheckedChanged += new System.EventHandler(this.firstHomeRadioButton_CheckedChanged);
            // 
            // realEstateInvestmentsRadioButton
            // 
            this.realEstateInvestmentsRadioButton.AutoSize = true;
            this.realEstateInvestmentsRadioButton.Location = new System.Drawing.Point(543, 51);
            this.realEstateInvestmentsRadioButton.Name = "realEstateInvestmentsRadioButton";
            this.realEstateInvestmentsRadioButton.Size = new System.Drawing.Size(180, 21);
            this.realEstateInvestmentsRadioButton.TabIndex = 3;
            this.realEstateInvestmentsRadioButton.TabStop = true;
            this.realEstateInvestmentsRadioButton.Text = "Real estate investments";
            this.realEstateInvestmentsRadioButton.UseVisualStyleBackColor = true;
            this.realEstateInvestmentsRadioButton.CheckedChanged += new System.EventHandler(this.realEstateInvestmentsRadioButton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.equalMonthlyRateRadioButton);
            this.groupBox3.Controls.Add(this.decreasingMonthlyRateRadioButton);
            this.groupBox3.Location = new System.Drawing.Point(459, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(502, 146);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // equalMonthlyRateRadioButton
            // 
            this.equalMonthlyRateRadioButton.AutoSize = true;
            this.equalMonthlyRateRadioButton.Location = new System.Drawing.Point(58, 61);
            this.equalMonthlyRateRadioButton.Name = "equalMonthlyRateRadioButton";
            this.equalMonthlyRateRadioButton.Size = new System.Drawing.Size(147, 21);
            this.equalMonthlyRateRadioButton.TabIndex = 0;
            this.equalMonthlyRateRadioButton.TabStop = true;
            this.equalMonthlyRateRadioButton.Text = "Equal monthly rate";
            this.equalMonthlyRateRadioButton.UseVisualStyleBackColor = true;
            this.equalMonthlyRateRadioButton.CheckedChanged += new System.EventHandler(this.equalMonthlyRateRadioButton_CheckedChanged);
            // 
            // decreasingMonthlyRateRadioButton
            // 
            this.decreasingMonthlyRateRadioButton.AutoSize = true;
            this.decreasingMonthlyRateRadioButton.Location = new System.Drawing.Point(264, 61);
            this.decreasingMonthlyRateRadioButton.Name = "decreasingMonthlyRateRadioButton";
            this.decreasingMonthlyRateRadioButton.Size = new System.Drawing.Size(183, 21);
            this.decreasingMonthlyRateRadioButton.TabIndex = 1;
            this.decreasingMonthlyRateRadioButton.TabStop = true;
            this.decreasingMonthlyRateRadioButton.Text = "Decreasing monthly rate";
            this.decreasingMonthlyRateRadioButton.UseVisualStyleBackColor = true;
            this.decreasingMonthlyRateRadioButton.CheckedChanged += new System.EventHandler(this.decreasingMonthlyRateRadioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.moneyToInvestLabel);
            this.groupBox2.Controls.Add(this.moneyToInvestLTextBox);
            this.groupBox2.Controls.Add(this.monthlyCreditRateButton);
            this.groupBox2.Controls.Add(this.totalAmountPayableLabel);
            this.groupBox2.Controls.Add(this.monthlyCreditRateLabel);
            this.groupBox2.Controls.Add(this.totalAmountPayableTextBox);
            this.groupBox2.Controls.Add(this.monthlyCreditRateTextBox);
            this.groupBox2.Location = new System.Drawing.Point(459, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 217);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // monthlyCreditRateButton
            // 
            this.monthlyCreditRateButton.Location = new System.Drawing.Point(51, 132);
            this.monthlyCreditRateButton.Name = "monthlyCreditRateButton";
            this.monthlyCreditRateButton.Size = new System.Drawing.Size(144, 47);
            this.monthlyCreditRateButton.TabIndex = 4;
            this.monthlyCreditRateButton.Text = "See monthly rates";
            this.monthlyCreditRateButton.UseVisualStyleBackColor = true;
            this.monthlyCreditRateButton.Click += new System.EventHandler(this.monthlyCreditRateButton_Click);
            // 
            // totalAmountPayableLabel
            // 
            this.totalAmountPayableLabel.AutoSize = true;
            this.totalAmountPayableLabel.Location = new System.Drawing.Point(289, 37);
            this.totalAmountPayableLabel.Name = "totalAmountPayableLabel";
            this.totalAmountPayableLabel.Size = new System.Drawing.Size(145, 17);
            this.totalAmountPayableLabel.TabIndex = 3;
            this.totalAmountPayableLabel.Text = "Total amount payable";
            // 
            // monthlyCreditRateLabel
            // 
            this.monthlyCreditRateLabel.AutoSize = true;
            this.monthlyCreditRateLabel.Location = new System.Drawing.Point(55, 37);
            this.monthlyCreditRateLabel.Name = "monthlyCreditRateLabel";
            this.monthlyCreditRateLabel.Size = new System.Drawing.Size(125, 17);
            this.monthlyCreditRateLabel.TabIndex = 2;
            this.monthlyCreditRateLabel.Text = "Monthly credit rate";
            // 
            // totalAmountPayableTextBox
            // 
            this.totalAmountPayableTextBox.Location = new System.Drawing.Point(283, 78);
            this.totalAmountPayableTextBox.Name = "totalAmountPayableTextBox";
            this.totalAmountPayableTextBox.ReadOnly = true;
            this.totalAmountPayableTextBox.Size = new System.Drawing.Size(164, 22);
            this.totalAmountPayableTextBox.TabIndex = 1;
            // 
            // monthlyCreditRateTextBox
            // 
            this.monthlyCreditRateTextBox.Location = new System.Drawing.Point(41, 78);
            this.monthlyCreditRateTextBox.Name = "monthlyCreditRateTextBox";
            this.monthlyCreditRateTextBox.ReadOnly = true;
            this.monthlyCreditRateTextBox.Size = new System.Drawing.Size(164, 22);
            this.monthlyCreditRateTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.interestRateLabel2);
            this.groupBox1.Controls.Add(this.downPaymentNumericUpDown);
            this.groupBox1.Controls.Add(this.downPaymentLabel2);
            this.groupBox1.Controls.Add(this.homePriceTextBox);
            this.groupBox1.Controls.Add(this.homePriveLabel);
            this.groupBox1.Controls.Add(this.lengthOfLoanNumericUpDown);
            this.groupBox1.Controls.Add(this.downPaymentLabel1);
            this.groupBox1.Controls.Add(this.interestRateTextBox);
            this.groupBox1.Controls.Add(this.downPaymentTextBox1);
            this.groupBox1.Controls.Add(this.interestRateLabel);
            this.groupBox1.Controls.Add(this.lengthOfLoanLabel);
            this.groupBox1.Location = new System.Drawing.Point(80, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 358);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // interestRateLabel2
            // 
            this.interestRateLabel2.AutoSize = true;
            this.interestRateLabel2.Location = new System.Drawing.Point(288, 303);
            this.interestRateLabel2.Name = "interestRateLabel2";
            this.interestRateLabel2.Size = new System.Drawing.Size(20, 17);
            this.interestRateLabel2.TabIndex = 17;
            this.interestRateLabel2.Text = "%";
            // 
            // downPaymentNumericUpDown
            // 
            this.downPaymentNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.downPaymentNumericUpDown.Location = new System.Drawing.Point(221, 142);
            this.downPaymentNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.downPaymentNumericUpDown.Name = "downPaymentNumericUpDown";
            this.downPaymentNumericUpDown.Size = new System.Drawing.Size(61, 22);
            this.downPaymentNumericUpDown.TabIndex = 16;
            this.downPaymentNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.downPaymentNumericUpDown.ValueChanged += new System.EventHandler(this.downPaymentNumericUpDown_ValueChanged);
            // 
            // downPaymentLabel2
            // 
            this.downPaymentLabel2.AutoSize = true;
            this.downPaymentLabel2.Location = new System.Drawing.Point(288, 144);
            this.downPaymentLabel2.Name = "downPaymentLabel2";
            this.downPaymentLabel2.Size = new System.Drawing.Size(20, 17);
            this.downPaymentLabel2.TabIndex = 15;
            this.downPaymentLabel2.Text = "%";
            // 
            // homePriceTextBox
            // 
            this.homePriceTextBox.Location = new System.Drawing.Point(78, 61);
            this.homePriceTextBox.Name = "homePriceTextBox";
            this.homePriceTextBox.Size = new System.Drawing.Size(217, 22);
            this.homePriceTextBox.TabIndex = 14;
            this.homePriceTextBox.TextChanged += new System.EventHandler(this.homePriceTextBox_TextChanged);
            // 
            // homePriveLabel
            // 
            this.homePriveLabel.AutoSize = true;
            this.homePriveLabel.Location = new System.Drawing.Point(75, 25);
            this.homePriveLabel.Name = "homePriveLabel";
            this.homePriveLabel.Size = new System.Drawing.Size(80, 17);
            this.homePriveLabel.TabIndex = 12;
            this.homePriveLabel.Text = "Home price";
            // 
            // lengthOfLoanNumericUpDown
            // 
            this.lengthOfLoanNumericUpDown.Location = new System.Drawing.Point(78, 219);
            this.lengthOfLoanNumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.lengthOfLoanNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.lengthOfLoanNumericUpDown.Name = "lengthOfLoanNumericUpDown";
            this.lengthOfLoanNumericUpDown.Size = new System.Drawing.Size(217, 22);
            this.lengthOfLoanNumericUpDown.TabIndex = 11;
            this.lengthOfLoanNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lengthOfLoanNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lengthOfLoanNumericUpDown.ValueChanged += new System.EventHandler(this.lengthOfLoanNumericUpDown_ValueChanged);
            // 
            // downPaymentLabel1
            // 
            this.downPaymentLabel1.AutoSize = true;
            this.downPaymentLabel1.Location = new System.Drawing.Point(75, 103);
            this.downPaymentLabel1.Name = "downPaymentLabel1";
            this.downPaymentLabel1.Size = new System.Drawing.Size(105, 17);
            this.downPaymentLabel1.TabIndex = 4;
            this.downPaymentLabel1.Text = "Down payment ";
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Location = new System.Drawing.Point(78, 300);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(204, 22);
            this.interestRateTextBox.TabIndex = 10;
            this.interestRateTextBox.TextChanged += new System.EventHandler(this.interestRateTextBox_TextChanged);
            // 
            // downPaymentTextBox1
            // 
            this.downPaymentTextBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.downPaymentTextBox1.Location = new System.Drawing.Point(78, 141);
            this.downPaymentTextBox1.Name = "downPaymentTextBox1";
            this.downPaymentTextBox1.Size = new System.Drawing.Size(137, 22);
            this.downPaymentTextBox1.TabIndex = 5;
            this.downPaymentTextBox1.TextChanged += new System.EventHandler(this.downPaymentTextBox1_TextChanged);
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.AutoSize = true;
            this.interestRateLabel.Location = new System.Drawing.Point(75, 261);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(88, 17);
            this.interestRateLabel.TabIndex = 9;
            this.interestRateLabel.Text = "Interest rate ";
            // 
            // lengthOfLoanLabel
            // 
            this.lengthOfLoanLabel.AutoSize = true;
            this.lengthOfLoanLabel.Location = new System.Drawing.Point(75, 178);
            this.lengthOfLoanLabel.Name = "lengthOfLoanLabel";
            this.lengthOfLoanLabel.Size = new System.Drawing.Size(103, 17);
            this.lengthOfLoanLabel.TabIndex = 7;
            this.lengthOfLoanLabel.Text = "Length of loan ";
            // 
            // conversionTab
            // 
            this.conversionTab.Controls.Add(this.secondComboBox);
            this.conversionTab.Controls.Add(this.firstComboBox);
            this.conversionTab.Controls.Add(this.secondTextBox);
            this.conversionTab.Controls.Add(this.firstTexBox);
            this.conversionTab.Controls.Add(this.conversionRateTableLayoutPanel);
            this.conversionTab.Location = new System.Drawing.Point(4, 22);
            this.conversionTab.Location = new System.Drawing.Point(4, 25);
            this.conversionTab.Margin = new System.Windows.Forms.Padding(4);
            this.conversionTab.Name = "conversionTab";
            this.conversionTab.Padding = new System.Windows.Forms.Padding(4);
            this.conversionTab.Size = new System.Drawing.Size(1052, 525);
            this.conversionTab.TabIndex = 2;
            this.conversionTab.Text = "Conversion";
            this.conversionTab.UseVisualStyleBackColor = true;
            // 
            // secondComboBox
            // 
            this.secondComboBox.FormattingEnabled = true;
            this.secondComboBox.Items.AddRange(new object[] {
            "EUR",
            "RON",
            "USD",
            "CAD",
            "GBP"});
            this.secondComboBox.Location = new System.Drawing.Point(545, 68);
            this.secondComboBox.Name = "secondComboBox";
            this.secondComboBox.Size = new System.Drawing.Size(121, 21);
            this.secondComboBox.TabIndex = 2;
            this.secondComboBox.SelectedIndexChanged += new System.EventHandler(this.secondComboBox_SelectedIndexChanged);
            // 
            // firstComboBox
            // 
            this.firstComboBox.FormattingEnabled = true;
            this.firstComboBox.Items.AddRange(new object[] {
            "EUR",
            "RON",
            "USD",
            "CAD",
            "GBP"});
            this.firstComboBox.Location = new System.Drawing.Point(99, 66);
            this.firstComboBox.Name = "firstComboBox";
            this.firstComboBox.Size = new System.Drawing.Size(121, 21);
            this.firstComboBox.TabIndex = 1;
            this.firstComboBox.SelectedIndexChanged += new System.EventHandler(this.firstComboBox_SelectedIndexChanged);
            // 
            // secondTextBox
            // 
            this.secondTextBox.Location = new System.Drawing.Point(439, 68);
            this.secondTextBox.Name = "secondTextBox";
            this.secondTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondTextBox.TabIndex = 9;
            this.secondTextBox.TextChanged += new System.EventHandler(this.secondTextBox_TextChanged);
            // 
            // firstTexBox
            // 
            this.firstTexBox.Location = new System.Drawing.Point(226, 68);
            this.firstTexBox.Name = "firstTexBox";
            this.firstTexBox.Size = new System.Drawing.Size(100, 20);
            this.firstTexBox.TabIndex = 8;
            this.firstTexBox.TextChanged += new System.EventHandler(this.firstTexBox_TextChanged);
            // 
            // conversionRateTableLayoutPanel
            // 
            this.conversionRateTableLayoutPanel.AutoSize = true;
            this.conversionRateTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.conversionRateTableLayoutPanel.ColumnCount = 2;
            this.conversionRateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.conversionRateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.conversionRateTableLayoutPanel.Controls.Add(this.conversionRateLabel, 0, 0);
            this.conversionRateTableLayoutPanel.Controls.Add(this.conversionRateText, 1, 0);
            this.conversionRateTableLayoutPanel.Location = new System.Drawing.Point(325, 34);
            this.conversionRateTableLayoutPanel.Name = "conversionRateTableLayoutPanel";
            this.conversionRateTableLayoutPanel.RowCount = 1;
            this.conversionRateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.conversionRateTableLayoutPanel.Size = new System.Drawing.Size(114, 13);
            this.conversionRateTableLayoutPanel.TabIndex = 7;
            // 
            // conversionRateLabel
            // 
            this.conversionRateLabel.AutoSize = true;
            this.conversionRateLabel.Location = new System.Drawing.Point(3, 0);
            this.conversionRateLabel.Name = "conversionRateLabel";
            this.conversionRateLabel.Size = new System.Drawing.Size(89, 13);
            this.conversionRateLabel.TabIndex = 0;
            this.conversionRateLabel.Text = "Conversion Rate:";
            // 
            // conversionRateText
            // 
            this.conversionRateText.AutoSize = true;
            this.conversionRateText.Location = new System.Drawing.Point(98, 0);
            this.conversionRateText.Name = "conversionRateText";
            this.conversionRateText.Size = new System.Drawing.Size(13, 13);
            this.conversionRateText.TabIndex = 1;
            this.conversionRateText.Text = "0";
            // 
            // moneyToInvestLTextBox
            // 
            this.moneyToInvestLTextBox.Location = new System.Drawing.Point(283, 157);
            this.moneyToInvestLTextBox.Name = "moneyToInvestLTextBox";
            this.moneyToInvestLTextBox.ReadOnly = true;
            this.moneyToInvestLTextBox.Size = new System.Drawing.Size(164, 22);
            this.moneyToInvestLTextBox.TabIndex = 5;
            // 
            // moneyToInvestLabel
            // 
            this.moneyToInvestLabel.AutoSize = true;
            this.moneyToInvestLabel.Location = new System.Drawing.Point(249, 132);
            this.moneyToInvestLabel.Name = "moneyToInvestLabel";
            this.moneyToInvestLabel.Size = new System.Drawing.Size(247, 17);
            this.moneyToInvestLabel.TabIndex = 6;
            this.moneyToInvestLabel.Text = "Money to invest before down payment";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.mainTabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.mainTabControl.ResumeLayout(false);
            this.taxesTab.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downPaymentNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthOfLoanNumericUpDown)).EndInit();
            this.conversionTab.ResumeLayout(false);
            this.conversionTab.PerformLayout();
            this.conversionRateTableLayoutPanel.ResumeLayout(false);
            this.conversionRateTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage calculatorTab;
        private System.Windows.Forms.TabPage taxesTab;
        private System.Windows.Forms.TabPage conversionTab;
        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.Label lengthOfLoanLabel;
        private System.Windows.Forms.Label downPaymentLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label totalAmountPayableLabel;
        private System.Windows.Forms.Label monthlyCreditRateLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label homePriveLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.RadioButton firstHomeRadioButton;
        private System.Windows.Forms.NumericUpDown lengthOfLoanNumericUpDown;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.TextBox downPaymentTextBox1;
        private System.Windows.Forms.RadioButton realEstateInvestmentsRadioButton;
        private System.Windows.Forms.TextBox totalAmountPayableTextBox;
        private System.Windows.Forms.TextBox monthlyCreditRateTextBox;
        private System.Windows.Forms.TextBox homePriceTextBox;
        private System.Windows.Forms.RadioButton decreasingMonthlyRateRadioButton;
        private System.Windows.Forms.RadioButton equalMonthlyRateRadioButton;
        private System.Windows.Forms.Label downPaymentLabel2;
        private System.Windows.Forms.NumericUpDown downPaymentNumericUpDown;
        private System.Windows.Forms.Label interestRateLabel2;
        private System.Windows.Forms.Button monthlyCreditRateButton;
        private System.Windows.Forms.Label moneyToInvestLabel;
        private System.Windows.Forms.TextBox moneyToInvestLTextBox;
        private System.Windows.Forms.ComboBox secondComboBox;
        private System.Windows.Forms.ComboBox firstComboBox;
        private System.Windows.Forms.TextBox secondTextBox;
        private System.Windows.Forms.TextBox firstTexBox;
        private System.Windows.Forms.TableLayoutPanel conversionRateTableLayoutPanel;
        private System.Windows.Forms.Label conversionRateLabel;
        private System.Windows.Forms.Label conversionRateText;
    }
}

