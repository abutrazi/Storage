using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Classes
{
    /*This class to describe Company info */
   public class Company
    {
        private int compID;
        private string compName;
        private string compEmail;
        private string compPass;
        //Ctor 
        public Company()
        {
        }

        public Company(string compName, string compEmail, string compPass)
        {
            this.compName = compName;
            this.compEmail = compEmail;
            this.compPass = compPass;
        }

        public int CompID
        {
            get { return this.compID; }
            set
            {
                if (value > 0)
                    this.compID = value;
            }
        }
        public string CompName
        {
            get { return this.compName; }
            set
            {
                if (value != "")
                    this.compName = value;
            }
        }
        public string CompEmail
        {
            get { return this.compEmail; }
            set
            {
                if (value != "")
                    this.compEmail = value;
            }
        }
        public string CompPass
        {
            get { return this.compPass; }
            set
            {
                if (value != "")
                    this.compPass = value;
            }
        }
                
    }

}
