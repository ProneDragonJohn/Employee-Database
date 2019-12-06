/*
 * John Velazquez
 * CIS 3343
 * 12/5/2019
 * 
 * Term Project
 * EmployeeHourly Class
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProject
{
    class EmployeeHourly : Employee
    {
        const double MAX_HOURLYRATE = 100.00;
        const double MAX_HOURS = 80.00;
        const double MIN_HOURLYRATE = 7.45;
        const double MIN_HOURS = 0;

        protected double pfvHourlyRate;
        protected double pfvHours;

        /********************
        * Constructor
        ********************/

        public EmployeeHourly(int Emp_ID, string First_Name, string Last_Name, string Mailing_Address,
            Department Emp_Dept, double Hourly_Rate)
        : base(Emp_ID, First_Name, Last_Name, Mailing_Address, Emp_Dept)
        {
            HourlyRate = Hourly_Rate;
        }

        /********************
        * Public properties 
        ********************/

        public double HourlyRate
        {
            get { return pfvHourlyRate; }
            set
            {
                if(value < MIN_HOURLYRATE || value > MAX_HOURLYRATE)
                {
                    throw new ApplicationException($"Valid values for Hourly Rate are between {MIN_HOURLYRATE} and {MAX_HOURLYRATE}");
                }
                pfvHourlyRate = value;
            }
        }

        public double Hours
        {
            get { return pfvHours; }
            set
            {
                if(value < MIN_HOURS || value > MAX_HOURS)
                {
                    throw new ApplicationException($"Valid values for Hours are between {MIN_HOURS} and {MAX_HOURS}");
                }
                pfvHours = value;
            }
        }

        /************
        * Methods 
        ************/

        public override double CalcPay()
        {
            return HourlyRate * Hours;
        }

        public override string ToString()
        {
            return $"EmpId={pfvEmpID}, FirstName={FirstName}, LastName={LastName}, Pay={CalcPay():C}";
        }
    }
}
