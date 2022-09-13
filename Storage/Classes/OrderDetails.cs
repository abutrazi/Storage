using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Classes
{
    /*This Class to describe order details info*/
    public class OrderDetails 
    {
        private int orderid;
        private int orderCode;
        private int productCode;
        private string productName;
        private int quantity;
        

        public OrderDetails()
        {
        }

        public OrderDetails(int orderCode, int productCode, string productName, int quantity)
        {
            this.orderCode = orderCode;
            this.productCode = productCode;
            this.productName = productName;
            this.quantity = quantity;
        }

        public int Orderid
        {
            get { return this.orderid; }
            set
            {
                if (value > 0)
                    this.orderid = value;
            }
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
      public int ProductCode
        {
            get { return this.productCode; }
            set
            {
                if (value > 0)
                    this.productCode = value;
            }
        }

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if (value != "")
                    this.productName = value;
            }
        }
      


        public int Quantity
        {
            get { return this.quantity; }
            set
            {
                if (value > 0)
                    this.quantity = value;
            }
        }

        
    }
    
   

}
