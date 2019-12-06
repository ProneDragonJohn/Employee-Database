/*
 * John Velazquez
 * CIS 3343
 * 12/5/2019
 * 
 * Term Project
 * Main Form
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermProject
{
    public partial class fmMain : Form
    {
        List<Employee> EmpList = new List<Employee>();

        public fmMain()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmAbout about = new fmAbout();
            about.ShowDialog();
        }

        private void bnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnLoad_Click(object sender, EventArgs e)
        {
            //Build data table
            dsEmpData.EmployeeDataTable dtEmployees = new dsEmpData.EmployeeDataTable();
            dsEmpData.DeptartmentDataTable dtDept = new dsEmpData.DeptartmentDataTable();

            //Make a table adapter
            dsEmpDataTableAdapters.EmployeeTableAdapter taEmployees = new dsEmpDataTableAdapters.EmployeeTableAdapter();
            dsEmpDataTableAdapters.DeptartmentTableAdapter taDept = new dsEmpDataTableAdapters.DeptartmentTableAdapter();

            //Fill using table adapter
            taEmployees.Fill(dtEmployees);

            //Loop through all of the rows
            foreach (dsEmpData.EmployeeRow dr in dtEmployees)
            {
                taDept.FillByID(dtDept, dr.DeptID);
                StringBuilder sb = new StringBuilder();
                foreach (dsEmpData.DeptartmentRow dr2 in dtDept)
                {
                    //sb.Append(", ");
                    sb.Append(dr2.DeptName);
                }

                lbxEmployee.Items.Add($"EmpID={dr.EmpID}, FirstName={dr.FirstName}, LastName={dr.LastName}, Dept={sb.ToString()}, Type={dr.EmpType}");
            }
        }

        private void tsmiFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiFileLoad_Click(object sender, EventArgs e)
        {
            //Build data table
            dsEmpData.EmployeeDataTable dtEmployees = new dsEmpData.EmployeeDataTable();
            dsEmpData.DeptartmentDataTable dtDept = new dsEmpData.DeptartmentDataTable();

            //Make a table adapter
            dsEmpDataTableAdapters.EmployeeTableAdapter taEmployees = new dsEmpDataTableAdapters.EmployeeTableAdapter();
            dsEmpDataTableAdapters.DeptartmentTableAdapter taDept = new dsEmpDataTableAdapters.DeptartmentTableAdapter();

            //Fill using table adapter
            taEmployees.Fill(dtEmployees);

            //Loop through all of the rows
            foreach (dsEmpData.EmployeeRow dr in dtEmployees)
            {
                taDept.FillByID(dtDept, dr.DeptID);
                StringBuilder sb = new StringBuilder();
                foreach (dsEmpData.DeptartmentRow dr2 in dtDept)
                {
                    //sb.Append(", ");
                    sb.Append(dr2.DeptName);
                }

                lbxEmployee.Items.Add($"EmpID={dr.EmpID}, FirstName{dr.FirstName}, LastName={dr.LastName}, Dept={sb.ToString()}, Type={dr.EmpType}");
            }
        }

        private void bnPrompt_Click(object sender, EventArgs e)
        {
            dsEmpData.EmployeeDataTable dtEmployees = new dsEmpData.EmployeeDataTable();
            dsEmpDataTableAdapters.EmployeeTableAdapter taEmployees = new dsEmpDataTableAdapters.EmployeeTableAdapter();
            taEmployees.Fill(dtEmployees);

            foreach (dsEmpData.EmployeeRow dr in dtEmployees)
            {
                Department dept = new Department();
                StringBuilder sb = new StringBuilder();
                if (dr.EmpType == "Bonus")
                {
                    fmPromptBonus bonus = new fmPromptBonus();
                    bonus.EmpID = dr.EmpID;
                    bonus.ShowDialog();

                    EmployeeBonus bonusEmp = new EmployeeBonus(dr.EmpID, dr.FirstName, dr.LastName, dr.Address, dept, Convert.ToDouble(dr.AnnualSalary));
                    bonusEmp.Bonus = bonus.Bonus/100;

                    lbxPayData.Items.Add($"EmpID={dr.EmpID}, Bonus={bonus.Bonus:F2}%");
                    EmpList.Add(bonusEmp);
                }
                else if (dr.EmpType == "Hourly")
                {
                    fmPromptHours hours = new fmPromptHours();
                    hours.EmpID = dr.EmpID;
                    hours.ShowDialog();

                    EmployeeHourly hourly = new EmployeeHourly(dr.EmpID, dr.FirstName, dr.LastName, dr.Address, dept, Convert.ToDouble(dr.HourlyRate));
                    hourly.Hours = hours.Hours;

                    lbxPayData.Items.Add($"EmpID={dr.EmpID}, Hours={hours.Hours}");
                    EmpList.Add(hourly);
                }
                else if (dr.EmpType == "Adjunct")
                {
                    lbxPayData.Items.Add($"EmpID={dr.EmpID}");
                    EmpList.Add(new EmployeeAdjunct(dr.EmpID, dr.FirstName, dr.LastName, dr.Address, dept, Convert.ToDouble(dr.ContractAmount), dr.ContractWeeks));

                }
                else if (dr.EmpType == "Professor")
                {
                    lbxPayData.Items.Add($"EmpID={dr.EmpID}");
                    EmpList.Add(new EmployeeProfessor(dr.EmpID, dr.FirstName, dr.LastName, dr.Address, dept, Convert.ToDouble(dr.AnnualSalary)));
                }

            }
        }

        private void enterPayrollDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dsEmpData.EmployeeDataTable dtEmployees = new dsEmpData.EmployeeDataTable();
            dsEmpDataTableAdapters.EmployeeTableAdapter taEmployees = new dsEmpDataTableAdapters.EmployeeTableAdapter();
            taEmployees.Fill(dtEmployees);

            foreach (dsEmpData.EmployeeRow dr in dtEmployees)
            {
                Department dept = new Department();
                StringBuilder sb = new StringBuilder();
                if (dr.EmpType == "Bonus")
                {
                    fmPromptBonus bonus = new fmPromptBonus();
                    bonus.EmpID = dr.EmpID;
                    bonus.ShowDialog();

                    EmployeeBonus bonusEmp = new EmployeeBonus(dr.EmpID, dr.FirstName, dr.LastName, dr.Address, dept, Convert.ToDouble(dr.AnnualSalary));
                    bonusEmp.Bonus = bonus.Bonus/100;

                    lbxPayData.Items.Add($"EmpID={dr.EmpID}, Bonus={bonus.Bonus:F2}%");
                    EmpList.Add(bonusEmp);
                }
                else if (dr.EmpType == "Hourly")
                {
                    fmPromptHours hours = new fmPromptHours();
                    hours.EmpID = dr.EmpID;
                    hours.ShowDialog();

                    EmployeeHourly hourly = new EmployeeHourly(dr.EmpID, dr.FirstName, dr.LastName, dr.Address, dept, Convert.ToDouble(dr.HourlyRate));
                    hourly.Hours = hours.Hours;

                    lbxPayData.Items.Add($"EmpID={dr.EmpID}, Hours={hours.Hours}");
                    EmpList.Add(hourly);
                }
                else if (dr.EmpType == "Adjunct")
                {
                    lbxPayData.Items.Add($"EmpID={dr.EmpID}");
                    EmpList.Add(new EmployeeAdjunct(dr.EmpID, dr.FirstName, dr.LastName, dr.Address, dept, Convert.ToDouble(dr.ContractAmount), dr.ContractWeeks));

                }
                else if (dr.EmpType == "Professor")
                {
                    lbxPayData.Items.Add($"EmpID={dr.EmpID}");
                    EmpList.Add(new EmployeeProfessor(dr.EmpID, dr.FirstName, dr.LastName, dr.Address, dept, Convert.ToDouble(dr.AnnualSalary)));
                }

            }
        }

        private void bnPay_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Employee emp in EmpList)
            {
                sb.AppendLine($"EmpID={emp.EmpID}, Pay={emp.CalcPay():C}");
            }
            MessageBox.Show(sb.ToString(), "Pay Report");
        }

        private void calculatePayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Employee emp in EmpList)
            {
                sb.AppendLine($"EmpID={emp.EmpID}, Pay={emp.CalcPay():C}");
            }
            MessageBox.Show(sb.ToString(), "Pay Report");
        }

        private void tsmiFileSave_Click(object sender, EventArgs e)
        {
            TextWriter tw = new StreamWriter("EmpPay.txt");
            tw.Write("");

            foreach(Employee emp in EmpList)
            {
                string s = emp.ToString();
                tw.WriteLine(s);
            }

            tw.Close();
        }
    }
}
