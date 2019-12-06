using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProject
{
    class Department
    {
        //Constants
        public const int MAX_DEPTID = 1000;
        public const int MIN_DEPTID = 100;

        //Private field variables
        protected int pfvDeptID;
        protected string pfvDeptName;
        protected string pfvLocation;
        protected int pfvSupvID;

        /********************
        * Constructor
        ********************/

        public Department()
        {

        }

        public Department(int Dept_ID, string Dept_Name, int Dept_SupvID, string Dept_Location)
        {
            DeptID = Dept_ID;
            DeptName = Dept_Name;
            SupvID = Dept_SupvID;
            Location = Dept_Location;
        }

        /********************
        * Public properties 
        ********************/

        public int DeptID
        {
            get { return pfvDeptID; }
            set
            {
                if (value < MIN_DEPTID || value > MAX_DEPTID)
                {
                    throw new ApplicationException($"Valid values for EmpID are between {MIN_DEPTID} and {MAX_DEPTID}");
                }
                pfvDeptID = value;
            }
        }

        public string DeptName
        {
            get { return pfvDeptName; }
            set
            {
                pfvDeptName = value;
            }
        }

        public string Location
        {
            get { return pfvLocation; }
            set
            {
                pfvLocation = value;
            }
        }

        public int SupvID
        {
            get { return pfvSupvID; }
            set
            {
                pfvSupvID = value;
            }
        }

        /************
        * Methods 
        ************/

        public override string ToString()
        {
            return $"DeptID={pfvDeptID}, DeptName={pfvDeptName}, Location={pfvLocation}, SupvID={pfvSupvID}";
        }
    }
}
