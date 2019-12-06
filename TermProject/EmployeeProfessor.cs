/*
 * John Velazquez
 * CIS 3343
 * 12/5/2019
 * 
 * Term Project
 * EmployeeProfessor Class
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProject
{
    class EmployeeProfessor : Employee
    {
        const double MAX_SALARY = 1000000;
        const double MIN_SALARY = 0;

        protected double pfvAnnualSalary;

        /********************
        * Constructor
        ********************/

        public EmployeeProfessor(int Emp_ID, string First_Name, string Last_Name, string Mailing_Address,
            Department Emp_Dept, double Annual_Salary)
        : base(Emp_ID, First_Name, Last_Name, Mailing_Address, Emp_Dept)
        {
            AnnualSalary = Annual_Salary;
        }

        /********************
        * Public properties 
        ********************/

        public double AnnualSalary
        {
            get { return pfvAnnualSalary; }
            set
            {
                if (value < MIN_SALARY || value > MAX_SALARY)
                {
                    throw new ApplicationException($"Valid values for Annual Salary are between {MIN_SALARY} and {MAX_SALARY}");
                }
                pfvAnnualSalary = value;
            }
        }

        /************
        * Methods 
        ************/

        public override double CalcPay()
        {
            return AnnualSalary / 52.000052;
        }

        public override string ToString()
        {
            return $"EmpId={pfvEmpID}, FirstName={FirstName}, LastName={LastName}, Pay={CalcPay():C}";
        }
    }
}
