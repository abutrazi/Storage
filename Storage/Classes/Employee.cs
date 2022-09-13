using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Classes
{
    /*This class to describes Employye info */
    public class Employee
    {
        //varibales
        private int empID;
        private string empFname;
        private string empLname;
        private string empTephone;
        private string empEmail;
        private string empAddress;
        private string empUsername;
        private string empPassword;
        private string empRole;
        private bool empActive;

        //C'tor
        public Employee() { }

        public Employee(int empID, string empFname, string empLname, string empTephone, string empEmail, string empAddress, string empUsername, string empPassword, string empRole,bool empActive)
        {
            this.empID = empID;
            this.empFname = empFname;
            this.empLname = empLname;
            this.empTephone = empTephone;
            this.empEmail = empEmail;
            this.empAddress = empAddress;
            this.empUsername = empUsername;
            this.empPassword = empPassword;
            this.empRole = empRole;
            this.empActive = empActive;
        }
        //Getter/Stter for Employee ID
        public int EmpID
        {
            get { return this.empID; }
            set
            {
                if (value >0)
                {
                    this.empID = value;
                }
            }

        }
        //Getter/Setter for Employee first name
        public string EmpFname
        {
            get { return this.empFname; }
            set
            {
                if (value != "")
                {
                    this.empFname = value;
                }
            }
        }

        //Getter/Setter for Employee last name
        public string EmpLname
        {
            get { return this.empLname; }
            set
            {
                if (value != "")
                {
                    this.empLname = value;
                }
            }
        }

        //Getter/Setter for Employee Telphone 
        public string EmpTel
        {
            get { return this.empTephone; }
            set
            {
                if (value != "")
                {
                    this.empTephone = value;
                }
            }
        }

        //Getter/Setter for Employee Email
        public string EmpEmail
        {
            get { return this.empEmail; }
            set
            {
                if (value != "")
                {
                    this.empEmail = value;
                }
            }
        }
        //Getter/Setter for Employee Address
        public string EmpAddress
        {
            get { return this.empAddress; }
            set
            {
                if (value != "")
                {
                    this.empAddress = value;
                }
            }
        }

        //Getter /setter for Employee Username
        public string EmpUsername
        {
            get { return this.empUsername; }
            set
            {
                if(value != "")
                {
                    this.empUsername = value;
                }
            }
        }

        //Getter /Setter for Employee Password
        public string EmpPassword
        {
            get { return this.empPassword; }
            set
            {
                if(value != "")
                {
                    this.empPassword = value;
                }
            }
        }
        public string EmpRole
        {
            get { return this.empRole; }
            set
            {
                if (value !="")
                    this.empRole = value;
               
            }
        }
        public bool EmpActive
        {
            get { return this.empActive; }
            set
            {
                if (value)
                    this.empActive = value;
                else
                    this.empActive = value;
            }
        }
    }



}

