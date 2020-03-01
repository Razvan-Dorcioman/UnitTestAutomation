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
            this.mainTabControl.SuspendLayout();
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
            this.conversionTab.Location = new System.Drawing.Point(4, 22);
            this.conversionTab.Name = "conversionTab";
            this.conversionTab.Padding = new System.Windows.Forms.Padding(3);
            this.conversionTab.Size = new System.Drawing.Size(787, 424);
            this.conversionTab.TabIndex = 2;
            this.conversionTab.Text = "Conversion";
            this.conversionTab.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage calculatorTab;
        private System.Windows.Forms.TabPage taxesTab;
        private System.Windows.Forms.TabPage conversionTab;
    }
}

