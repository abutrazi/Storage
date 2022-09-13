using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Classes
{
    /*This class to describe Product info */
    public class Product
    {
        //varibales

        private int prodCode;
        private string prodName;
        private string prodSize;
        private int prodPrice;
        private int prodAmount;
        private int miqQty;
        private int suppliercode;

        

        //C'tor
        public Product()
        {
            
        }

      

        public Product(int prodCode, string prodName, string prodSize, int prodPrice,int prodAmount,int minQty ,int suppliercode)
        {
            this.prodCode = prodCode;
            this.prodName = prodName;
            this.prodSize = prodSize;
            this.prodPrice = prodPrice;
            this.prodAmount = prodAmount;
            this.miqQty = minQty;
            this.suppliercode = suppliercode;
        }
        

       



        //Getter /Setter for Product Code
        public int ProdCode
        {
            get { return this.prodCode; }
            set
            {
                if (value > 0)
                {
                    this.prodCode = value;
                }
            }
        }
        //Getter /Setter for product Name
        public string ProdName
        {
            get { return this.prodName; }
            set
            {
                if (value != "")
                {
                    this.prodName = value;
                }
            }
        }

        //Getter /Setter for product Size
        public string ProdSize
        {
            get { return this.prodSize; }
            set
            {
                if(value!="")
                {
                    this.prodSize = value;
                }
            }
        }

        //Getter /Setter for Product Price
        public int ProdPrice
        {
            get { return this.prodPrice; }
            set
            {
                if(value>0)
                {
                    this.prodPrice = value;
                }
            }
        }

        public int ProdAmount
        {
            get { return this.prodAmount; }
            set
            {
                if(value>0)
                {
                    this.prodAmount = value;
                }
            }
        }
        public int MinQty
        {
            get { return this.miqQty; }
            set
            {
                if (value > 0)
                    this.miqQty = value;
            }
        }
        public int SupplierCode
        {
            get { return this.suppliercode; }
            set
            {
                if (value >0)
                    this.suppliercode = value;
            }
        }
    }
}
