using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Classes
{
    /*This class to describe message info */
    
    public class MSG
    {
        private int msgId;
        private string msgSubject;

        public MSG()
        {
        }

        public MSG(string mssSubject)
        {
            this.msgSubject = mssSubject;

        }

        public int MsgID
        {
            get { return this.msgId; }
            set
            {
                if (value > 0)
                    this.msgId = value;
            }
        }
        public string MsgSubject
        {
            get { return this.msgSubject; }
            set
            {
                if (value != "")
                    this.msgSubject = value;
            }
        }
     
    }

}
