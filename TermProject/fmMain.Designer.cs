namespace TermProject
{
    partial class fmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterPayrollDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatePayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbxEmployee = new System.Windows.Forms.ListBox();
            this.lbxPayData = new System.Windows.Forms.ListBox();
            this.bnLoad = new System.Windows.Forms.Button();
            this.bnPrompt = new System.Windows.Forms.Button();
            this.bnPay = new System.Windows.Forms.Button();
            this.bnExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFileLoad,
            this.tsmiFileSave,
            this.tsmiFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmiFileLoad
            // 
            this.tsmiFileLoad.Name = "tsmiFileLoad";
            this.tsmiFileLoad.Size = new System.Drawing.Size(180, 22);
            this.tsmiFileLoad.Text = "Load Data";
            this.tsmiFileLoad.Click += new System.EventHandler(this.tsmiFileLoad_Click);
            // 
            // tsmiFileSave
            // 
            this.tsmiFileSave.Name = "tsmiFileSave";
            this.tsmiFileSave.Size = new System.Drawing.Size(180, 22);
            this.tsmiFileSave.Text = "Save As";
            this.tsmiFileSave.Click += new System.EventHandler(this.tsmiFileSave_Click);
            // 
            // tsmiFileExit
            // 
            this.tsmiFileExit.Name = "tsmiFileExit";
            this.tsmiFileExit.Size = new System.Drawing.Size(180, 22);
            this.tsmiFileExit.Text = "Exit";
            this.tsmiFileExit.Click += new System.EventHandler(this.tsmiFileExit_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterPayrollDataToolStripMenuItem,
            this.calculatePayToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // enterPayrollDataToolStripMenuItem
            // 
            this.enterPayrollDataToolStripMenuItem.Name = "enterPayrollDataToolStripMenuItem";
            this.enterPayrollDataToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.enterPayrollDataToolStripMenuItem.Text = "Enter Payroll Data";
            this.enterPayrollDataToolStripMenuItem.Click += new System.EventHandler(this.enterPayrollDataToolStripMenuItem_Click);
            // 
            // calculatePayToolStripMenuItem
            // 
            this.calculatePayToolStripMenuItem.Name = "calculatePayToolStripMenuItem";
            this.calculatePayToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.calculatePayToolStripMenuItem.Text = "Calculate Pay";
            this.calculatePayToolStripMenuItem.Click += new System.EventHandler(this.calculatePayToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lbxEmployee
            // 
            this.lbxEmployee.FormattingEnabled = true;
            this.lbxEmployee.Location = new System.Drawing.Point(22, 42);
            this.lbxEmployee.Name = "lbxEmployee";
            this.lbxEmployee.Size = new System.Drawing.Size(427, 264);
            this.lbxEmployee.TabIndex = 1;
            // 
            // lbxPayData
            // 
            this.lbxPayData.FormattingEnabled = true;
            this.lbxPayData.Location = new System.Drawing.Point(475, 42);
            this.lbxPayData.Name = "lbxPayData";
            this.lbxPayData.Size = new System.Drawing.Size(332, 264);
            this.lbxPayData.TabIndex = 2;
            // 
            // bnLoad
            // 
            this.bnLoad.Location = new System.Drawing.Point(217, 341);
            this.bnLoad.Name = "bnLoad";
            this.bnLoad.Size = new System.Drawing.Size(75, 23);
            this.bnLoad.TabIndex = 3;
            this.bnLoad.Text = "Load Data";
            this.bnLoad.UseVisualStyleBackColor = true;
            this.bnLoad.Click += new System.EventHandler(this.bnLoad_Click);
            // 
            // bnPrompt
            // 
            this.bnPrompt.Location = new System.Drawing.Point(325, 341);
            this.bnPrompt.Name = "bnPrompt";
            this.bnPrompt.Size = new System.Drawing.Size(75, 23);
            this.bnPrompt.TabIndex = 4;
            this.bnPrompt.Text = "Enter Data";
            this.bnPrompt.UseVisualStyleBackColor = true;
            this.bnPrompt.Click += new System.EventHandler(this.bnPrompt_Click);
            // 
            // bnPay
            // 
            this.bnPay.Location = new System.Drawing.Point(429, 341);
            this.bnPay.Name = "bnPay";
            this.bnPay.Size = new System.Drawing.Size(75, 23);
            this.bnPay.TabIndex = 5;
            this.bnPay.Text = "Calc Pay";
            this.bnPay.UseVisualStyleBackColor = true;
            this.bnPay.Click += new System.EventHandler(this.bnPay_Click);
            // 
            // bnExit
            // 
            this.bnExit.Location = new System.Drawing.Point(534, 341);
            this.bnExit.Name = "bnExit";
            this.bnExit.Size = new System.Drawing.Size(75, 23);
            this.bnExit.TabIndex = 6;
            this.bnExit.Text = "Exit";
            this.bnExit.UseVisualStyleBackColor = true;
            this.bnExit.Click += new System.EventHandler(this.bnExit_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 399);
            this.Controls.Add(this.bnExit);
            this.Controls.Add(this.bnPay);
            this.Controls.Add(this.bnPrompt);
            this.Controls.Add(this.bnLoad);
            this.Controls.Add(this.lbxPayData);
            this.Controls.Add(this.lbxEmployee);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmMain";
            this.Text = "Term Project";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileLoad;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileExit;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterPayrollDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatePayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox lbxEmployee;
        private System.Windows.Forms.ListBox lbxPayData;
        private System.Windows.Forms.Button bnLoad;
        private System.Windows.Forms.Button bnPrompt;
        private System.Windows.Forms.Button bnPay;
        private System.Windows.Forms.Button bnExit;
    }
}

