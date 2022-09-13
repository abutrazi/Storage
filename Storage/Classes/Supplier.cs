using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Classes
{
    /*This class to describe supplier info */
    public class Supplier
    {
        //varibales
        private int Supid_auto;
        private int supCode;
        private string supName;
        private string supTelphone;
        private string supEmail;
        private string supAddress;
        private bool supActive;
   

        //C'tor
        public Supplier()
        {
        }

        public Supplier( int supCode, string supName, string supTelphone, string supEmail, string supAddress,bool supAvtive)
        {
            
            this.supCode = supCode;
            this.supName = supName;
            this.supTelphone = supTelphone;
            this.supEmail = supEmail;
            this.supAddress = supAddress;
            this.supActive = supActive;
       
        }
        //Getter / Setter for Suplier ID_AUTO
        public int SUPID_AUTO
        {
            get { return this.Supid_auto; }
            set
            {
                if (value > 0)
                    this.Supid_auto = value;
            }
        }
        
        //Getter / Setter for Supplier Code
        public int SupCode
        {
            get { return this.supCode; }
            set
            {
                if (value > 0)
                    this.supCode = value;
            }
        }
        
        //Getter / Setter for Supplier Name
        public string SupName
        {
            get { return this.supName; }
            set
            {
                if (value != "")
                    this.supName=value;
            }
        }

        //Getter / Setter for Supplier Telphone
        public string SupTel
        {
            get { return this.supTelphone;}
            set
            {
                if (value != "")
                    this.supTelphone = value;
            }
        }

        //Getter / Setter for Supplier Email
        public string SupEmail
        {
            get { return this.supEmail; }
            set
            {
                if (value != "")
                    this.supEmail = value;
            }
        }

        //Getter / Setter for Supplier Address
        public string SupAdd
        {
            get { return this.supAddress; }
            set
            {
                if (value != "")
                    this.supAddress = value;
            }
        }
        public bool SupActive
        {
            get { return this.supActive; }
            set
            {
                if (value)
                    this.supActive = value;
                else
                    this.supActive = value;
            }
        }

    }
}
