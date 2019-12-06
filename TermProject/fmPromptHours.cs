using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermProject
{
    public partial class fmPromptHours : Form
    {
        private double pfvHours;
        private int pfvEmpID;

        public fmPromptHours()
        {
            InitializeComponent();
        }

        public double Hours
        {
            get { return pfvHours; }
            set
            {
                pfvHours = value;
            }
        }

        public int EmpID
        {
            get { return pfvEmpID; }
            set
            {
                pfvEmpID = value;
            }
        }

        private void bnSave_Click(object sender, EventArgs e)
        {
            Hours = Convert.ToDouble(this.tbHours.Text);
            this.Close();
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmPromptHours_Load(object sender, EventArgs e)
        {
            tbEmpID.Text = EmpID.ToString();
        }
    }
}
