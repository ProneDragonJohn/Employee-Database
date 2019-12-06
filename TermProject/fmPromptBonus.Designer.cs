namespace TermProject
{
    partial class fmPromptBonus
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
            this.lbEmpID = new System.Windows.Forms.Label();
            this.lbBonus = new System.Windows.Forms.Label();
            this.bnSave = new System.Windows.Forms.Button();
            this.bnCancel = new System.Windows.Forms.Button();
            this.tbEmpID = new System.Windows.Forms.TextBox();
            this.tbBonus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbEmpID
            // 
            this.lbEmpID.AutoSize = true;
            this.lbEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpID.Location = new System.Drawing.Point(36, 52);
            this.lbEmpID.Name = "lbEmpID";
            this.lbEmpID.Size = new System.Drawing.Size(59, 20);
            this.lbEmpID.TabIndex = 0;
            this.lbEmpID.Text = "EmpID";
            // 
            // lbBonus
            // 
            this.lbBonus.AutoSize = true;
            this.lbBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBonus.Location = new System.Drawing.Point(36, 102);
            this.lbBonus.Name = "lbBonus";
            this.lbBonus.Size = new System.Drawing.Size(213, 20);
            this.lbBonus.TabIndex = 1;
            this.lbBonus.Text = "Enter the Bonus Amount (%)";
            // 
            // bnSave
            // 
            this.bnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnSave.Location = new System.Drawing.Point(77, 189);
            this.bnSave.Name = "bnSave";
            this.bnSave.Size = new System.Drawing.Size(100, 54);
            this.bnSave.TabIndex = 2;
            this.bnSave.Text = "Save";
            this.bnSave.UseVisualStyleBackColor = true;
            this.bnSave.Click += new System.EventHandler(this.bnSave_Click);
            // 
            // bnCancel
            // 
            this.bnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCancel.Location = new System.Drawing.Point(331, 189);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(102, 54);
            this.bnCancel.TabIndex = 3;
            this.bnCancel.Text = "Cancel";
            this.bnCancel.UseVisualStyleBackColor = true;
            this.bnCancel.Click += new System.EventHandler(this.bnCancel_Click);
            // 
            // tbEmpID
            // 
            this.tbEmpID.Enabled = false;
            this.tbEmpID.Location = new System.Drawing.Point(255, 52);
            this.tbEmpID.Name = "tbEmpID";
            this.tbEmpID.Size = new System.Drawing.Size(98, 20);
            this.tbEmpID.TabIndex = 4;
            // 
            // tbBonus
            // 
            this.tbBonus.Location = new System.Drawing.Point(255, 102);
            this.tbBonus.Name = "tbBonus";
            this.tbBonus.Size = new System.Drawing.Size(190, 20);
            this.tbBonus.TabIndex = 5;
            // 
            // fmPromptBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 283);
            this.Controls.Add(this.tbBonus);
            this.Controls.Add(this.tbEmpID);
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.bnSave);
            this.Controls.Add(this.lbBonus);
            this.Controls.Add(this.lbEmpID);
            this.Name = "fmPromptBonus";
            this.Text = "Prompt for Bonus";
            this.Load += new System.EventHandler(this.fmPromptBonus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmpID;
        private System.Windows.Forms.Label lbBonus;
        private System.Windows.Forms.Button bnSave;
        private System.Windows.Forms.Button bnCancel;
        private System.Windows.Forms.TextBox tbEmpID;
        private System.Windows.Forms.TextBox tbBonus;
    }
}