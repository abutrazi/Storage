using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Classes
{
    /*This class to describe order info */
   public class Order 
    {
        //varibales
        private int orderCode;
        private DateTime orderDate;
        private int supplierCode;
        private bool orderOk;
        private int msgId;
        private int payment;
        


        public Order()
        {
        }

        public Order( DateTime orderDate, int supplierCode, bool orderOk ,int msgId,int payment)
        {
            
            this.orderDate = orderDate;
            this.supplierCode = supplierCode;
            this.orderOk = orderOk;
            this.msgId = msgId;
            this.payment = payment;
        }

        public int OrderCode
        {
            get { return this.orderCode; }
            set
            {
                if (value > 0)
                    this.orderCode = value;
            }
        }
        public DateTime OrderDate
        {
            get { return this.orderDate; }
            set
            {
                this.orderDate = value;
            }
        }

        public int SupplierCode
        {
            get { return this.supplierCode; }
            set
            {
                if (value > 0)
                    this.supplierCode = value;
            }
        }
        public bool OrderOK
        {
            get { return this.orderOk; }
            set
            {
                if (value)
                    this.orderOk = value;
                else
                    this.orderOk = value;
            }
        }
        public int MsgId
        {
            get { return this.msgId; }
            set
            {
                if (value > 0)
                    this.msgId = value;
            }
        }
        public int Payment
        {
            get { return this.payment; }
            set
            {
                if (value > 0)
                    this.payment = value;
            }
        }
       

    }
}
