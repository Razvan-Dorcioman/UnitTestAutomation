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
            this.conversionTab = new System.Windows.Forms.TabPage();
            this.secondComboBox = new System.Windows.Forms.ComboBox();
            this.firstComboBox = new System.Windows.Forms.ComboBox();
            this.secondTextBox = new System.Windows.Forms.TextBox();
            this.firstTexBox = new System.Windows.Forms.TextBox();
            this.conversionRateTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.conversionRateLabel = new System.Windows.Forms.Label();
            this.conversionRateText = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.conversionTab.SuspendLayout();
            this.conversionRateTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.calculatorTab);
            this.mainTabControl.Controls.Add(this.taxesTab);
            this.mainTabControl.Controls.Add(this.conversionTab);
            this.mainTabControl.Location = new System.Drawing.Point(4, 1);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(795, 450);
            this.mainTabControl.TabIndex = 0;
            // 
            // calculatorTab
            // 
            this.calculatorTab.Location = new System.Drawing.Point(4, 22);
            this.calculatorTab.Name = "calculatorTab";
            this.calculatorTab.Padding = new System.Windows.Forms.Padding(3);
            this.calculatorTab.Size = new System.Drawing.Size(787, 424);
            this.calculatorTab.TabIndex = 0;
            this.calculatorTab.Text = "Calculator";
            this.calculatorTab.UseVisualStyleBackColor = true;
            // 
            // taxesTab
            // 
            this.taxesTab.Location = new System.Drawing.Point(4, 22);
            this.taxesTab.Name = "taxesTab";
            this.taxesTab.Padding = new System.Windows.Forms.Padding(3);
            this.taxesTab.Size = new System.Drawing.Size(787, 424);
            this.taxesTab.TabIndex = 1;
            this.taxesTab.Text = "Taxes";
            this.taxesTab.UseVisualStyleBackColor = true;
            // 
            // conversionTab
            // 
            this.conversionTab.Controls.Add(this.secondComboBox);
            this.conversionTab.Controls.Add(this.firstComboBox);
            this.conversionTab.Controls.Add(this.secondTextBox);
            this.conversionTab.Controls.Add(this.firstTexBox);
            this.conversionTab.Controls.Add(this.conversionRateTableLayoutPanel);
            this.conversionTab.Location = new System.Drawing.Point(4, 22);
            this.conversionTab.Name = "conversionTab";
            this.conversionTab.Padding = new System.Windows.Forms.Padding(3);
            this.conversionTab.Size = new System.Drawing.Size(787, 424);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTabControl);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.mainTabControl.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox secondComboBox;
        private System.Windows.Forms.ComboBox firstComboBox;
        private System.Windows.Forms.TextBox secondTextBox;
        private System.Windows.Forms.TextBox firstTexBox;
        private System.Windows.Forms.TableLayoutPanel conversionRateTableLayoutPanel;
        private System.Windows.Forms.Label conversionRateLabel;
        private System.Windows.Forms.Label conversionRateText;
    }
}

