/*
 * John Velazquez
 * CIS 3343
 * 12/5/2019
 * 
 * Term Project
 * Employee Class
 */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProject
{
    abstract class Employee
    {
        //Constants for input validation
        public const int MAX_EMPID = 10000;
        public const int MIN_EMPID = 1000;

        //Private field variables for properties
        protected string pfvAddress;
        protected Department pfvDept;
        protected int pfvEmpID;
        protected string pfvFirstName;
        protected string pfvLastName;

        /********************
        * Constructor
        ********************/

        public Employee()
        {

        }

        public Employee(int Emp_ID, string First_Name, string Last_Name, string Mailing_Address, Department Emp_Dept)
        {
            //Variables first go through the properties, for input validation
            EmpID = Emp_ID;
            FirstName = First_Name;
            LastName = Last_Name;
            MailingAddress = Mailing_Address;
            Dept = Emp_Dept;
        }

        /********************
        * Public properties 
        ********************/

        public int EmpID
        {
            get { return pfvEmpID; }
            set
            {
                if (value < MIN_EMPID || value > MAX_EMPID)
                {
                    throw new ApplicationException($"Valid values for EmpID are between {MIN_EMPID} and {MAX_EMPID}");
                }
                pfvEmpID = value;
            }
        }

        //Employee's first name
        public string FirstName
        {
            get { return pfvFirstName; }
            set
            {
                if (value.Length == 0)
                {
                    //"Talks back" to the USL
                    throw new ApplicationException("First Name must not be blank");
                }
                pfvFirstName = value;
            }
        }

        //Employee's last name
        public string LastName
        {
            get { return pfvLastName; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ApplicationException("Last Name must not be blank");
                }
                pfvLastName = value;
            }
        }

        //Mailing Address
        public string MailingAddress
        {
            get { return pfvAddress; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ApplicationException("Address must not be blank");
                }
                pfvAddress = value;
            }
        }

        //Department
        public Department Dept
        {
            get { return pfvDept; }
            set
            {
                pfvDept = value;
            }
        }

        /************
        * Methods 
        ************/

        //calculates their weekly pay
        public abstract double CalcPay();

        //Returns the employee's full name;
        public string FullName()
        {
            return $"{pfvFirstName} {pfvLastName}";
        }

        //Override the ToString Method
        public override string ToString()
        {
            return "";
        }
    }
}
