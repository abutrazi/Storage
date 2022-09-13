using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Classes
{
   public class Supp
    {
        //Varibales
        private int cSuppCode;
        private string cSuppName;
        //C'tor
        public Supp()
        {
        }

        public Supp(int cSuppCode, string cSuppName)
        {
            this.cSuppCode = cSuppCode;
            this.cSuppName = cSuppName;
        }
        //Getter /Setter for Copy Supp Code
        public int CSuppCode
        {
            get { return this.cSuppCode; }
            set
            {
                if (value > 0)
                    this.cSuppCode = value;
            }
        }
        //Getter /Setter for Copy Spp Name
        public string CSuppName
        {
            get { return this.cSuppName; }
            set
            {
                if (value != "")
                    this.cSuppName = value;
            }
        }
    }
}
