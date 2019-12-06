/*
 * John Velazquez
 * CIS 3343
 * 12/5/2019
 * 
 * Term Project
 * EmployeeAdjunct Class
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProject
{
    class EmployeeAdjunct : Employee
    {
        public const double MAX_CONTRACT = 16000;
        public const int MAX_WEEK = 16;
        public const double MIN_CONTRACT = 3000;
        public const int MIN_WEEK = 6;

        protected double pfvContractAmount;
        protected int pfvNumWeeks;

        /********************
        * Constructor
        ********************/

        public EmployeeAdjunct(int Emp_ID, string First_Name, string Last_Name, string Mailing_Address, 
            Department Emp_Dept, double Contract_Amount, int Num_Weeks) 
        : base(Emp_ID, First_Name, Last_Name, Mailing_Address, Emp_Dept)
        {
            ContractAmount = Contract_Amount;
            NumWeeks = Num_Weeks;
        }

        /********************
        * Public properties 
        ********************/

        public double ContractAmount
        {
            get { return pfvContractAmount; }
            set
            {
                if(value < MIN_CONTRACT || value > MAX_CONTRACT)
                {
                    throw new ApplicationException($"Valid values for Contract are between {MIN_CONTRACT} and {MAX_CONTRACT}");
                }
                pfvContractAmount = value;
            }
        }

        public int NumWeeks
        {
            get { return pfvNumWeeks; }
            set
            {
                if(value < MIN_WEEK || value > MAX_WEEK)
                {
                    throw new ApplicationException($"Valid values for NumWeeks are between {MIN_WEEK} and {MAX_WEEK}");
                }
                pfvNumWeeks = value;
            }
        }

        /************
        * Methods 
        ************/

        public override double CalcPay()
        {
            return ContractAmount/NumWeeks;
        }

        public override string ToString()
        {
            return $"EmpId={pfvEmpID}, FirstName={FirstName}, LastName={LastName}, Pay={CalcPay():C}";
        }
    }
}
