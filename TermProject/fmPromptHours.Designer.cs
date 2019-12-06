namespace TermProject
{
    partial class fmPromptHours
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
            this.tbHours = new System.Windows.Forms.TextBox();
            this.tbEmpID = new System.Windows.Forms.TextBox();
            this.bnCancel = new System.Windows.Forms.Button();
            this.bnSave = new System.Windows.Forms.Button();
            this.lbHours = new System.Windows.Forms.Label();
            this.lbEmpID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbHours
            // 
            this.tbHours.Location = new System.Drawing.Point(274, 95);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(190, 20);
            this.tbHours.TabIndex = 11;
            // 
            // tbEmpID
            // 
            this.tbEmpID.Enabled = false;
            this.tbEmpID.Location = new System.Drawing.Point(274, 45);
            this.tbEmpID.Name = "tbEmpID";
            this.tbEmpID.Size = new System.Drawing.Size(98, 20);
            this.tbEmpID.TabIndex = 10;
            // 
            // bnCancel
            // 
            this.bnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCancel.Location = new System.Drawing.Point(350, 182);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(102, 54);
            this.bnCancel.TabIndex = 9;
            this.bnCancel.Text = "Cancel";
            this.bnCancel.UseVisualStyleBackColor = true;
            this.bnCancel.Click += new System.EventHandler(this.bnCancel_Click);
            // 
            // bnSave
            // 
            this.bnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnSave.Location = new System.Drawing.Point(96, 182);
            this.bnSave.Name = "bnSave";
            this.bnSave.Size = new System.Drawing.Size(100, 54);
            this.bnSave.TabIndex = 8;
            this.bnSave.Text = "Save";
            this.bnSave.UseVisualStyleBackColor = true;
            this.bnSave.Click += new System.EventHandler(this.bnSave_Click);
            // 
            // lbHours
            // 
            this.lbHours.AutoSize = true;
            this.lbHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHours.Location = new System.Drawing.Point(55, 95);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(189, 20);
            this.lbHours.TabIndex = 7;
            this.lbHours.Text = "Enter the Hours Worked: ";
            // 
            // lbEmpID
            // 
            this.lbEmpID.AutoSize = true;
            this.lbEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpID.Location = new System.Drawing.Point(55, 45);
            this.lbEmpID.Name = "lbEmpID";
            this.lbEmpID.Size = new System.Drawing.Size(59, 20);
            this.lbEmpID.TabIndex = 6;
            this.lbEmpID.Text = "EmpID";
            // 
            // fmPromptHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 279);
            this.Controls.Add(this.tbHours);
            this.Controls.Add(this.tbEmpID);
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.bnSave);
            this.Controls.Add(this.lbHours);
            this.Controls.Add(this.lbEmpID);
            this.Name = "fmPromptHours";
            this.Text = "Hourly Employee";
            this.Load += new System.EventHandler(this.fmPromptHours_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHours;
        private System.Windows.Forms.TextBox tbEmpID;
        private System.Windows.Forms.Button bnCancel;
        private System.Windows.Forms.Button bnSave;
        private System.Windows.Forms.Label lbHours;
        private System.Windows.Forms.Label lbEmpID;
    }
}