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
    public partial class fmPromptBonus : Form
    {
        private double pfvBonus;
        private int pfvEmpID;

        public fmPromptBonus()
        {
            InitializeComponent();
        }

        public double Bonus
        {
            get { return pfvBonus; }
            set
            {
                pfvBonus = value;
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

        private void bnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnSave_Click(object sender, EventArgs e)
        {
            Bonus = Convert.ToDouble(this.tbBonus.Text);
            this.Close();
        }

        private void fmPromptBonus_Load(object sender, EventArgs e)
        {
            tbEmpID.Text = EmpID.ToString();
        }
    }
}
