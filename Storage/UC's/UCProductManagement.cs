using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage.UC_s
{
    /*this user control of mangment the products data */
    public partial class UCProductManagement : UserControl
    {
        //Delegates
        public delegate void OnButtonInsertProduct(object sender, EventArgs e);
        public event OnButtonInsertProduct OnClickInsertProduct;
        public delegate void OnButtonUpdateProduct(object sender, EventArgs e);
        public event OnButtonUpdateProduct OnClickUpdateProduct;
        public delegate void OnButtonDeleteProduct(object sender, EventArgs e);
        public event OnButtonDeleteProduct OnClickDeleteProduct;
        public delegate void OnButtonResetTbs (object sender, EventArgs e);
        public event OnButtonResetTbs OnClickResetTbs;
        public delegate void CellDoubleClickDgvProduct(object sender, DataGridViewCellEventArgs e);
        public event CellDoubleClickDgvProduct CellDoubleClick;
        public delegate void OnButtonClickMostApp(object sender, EventArgs e);
        public event OnButtonClickMostApp OnlClickMostApp;
        public delegate void OnButtonClickSupp(object sender, EventArgs e);
        public event OnButtonClickSupp OnClickSupp;
        public delegate void SelectedIndex(object sender, EventArgs e);
        public event SelectedIndex SelectedIndexSupplier;
        public delegate void OnButtonClickShowAll(object sender, EventArgs e);
        public event OnButtonClickShowAll OnClickShowAll;
        public UCProductManagement()
        {
            InitializeComponent();
        }

        //Getter From components
        public TextBox tbCode
        {
            get
            {
                return tbProdCode;
            }
        }

        public TextBox tbName
        {
            get
            {
                return tbProdName;
            }
        }

        public TextBox tbSize
        {
            get
            {
                return tbProdSize;
            }
        }

        public TextBox tbPrice
        {
            get
            {
                return tbProdPrice; 
            }
        }
        public TextBox tbMinQty
        {
            get { return tbminqty; }
        }
        //combo box to choose supplier for add new product
        public ComboBox cbSupplierName
        {
            get { return this.cbsuppliername; }
            set
            {
                if (value.Text != "")
                    this.cbsuppliername = value;
            }
        }
        //combo box to fill products by supplier
        public ComboBox cbSupplier
        {
            get { return this.cbsupplier; }
        }
        public DataGridView DgvProduct
        {
            get { return dgvProducts; }
        }

        //On click for insert product
        private void btnInsertProd_Click(object sender, EventArgs e)
        {
            if (OnClickInsertProduct != null)
            {
                OnClickInsertProduct(this, e);
            }
            
        }
        //On click for update product
        private void btnUpdateProd_Click(object sender, EventArgs e)
        {
            if (OnClickUpdateProduct != null)
            {
                OnClickUpdateProduct(this, e);
            }
        }
        //On click for delete product
        private void btnDeleteProd_Click(object sender, EventArgs e)
        {
            if(OnClickDeleteProduct!=null)
            {
                OnClickDeleteProduct(this, e);
            }
        }
        //On click for Reset Text boxes
        private void btnReset_Click(object sender, EventArgs e)
        {
            if(OnClickResetTbs!=null)
            {
                OnClickResetTbs(this, e);
            }
        }
        //Cell double click event for products datagrid view
        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CellDoubleClick != null)
                CellDoubleClick(this, e);
        }

     

      
        //on click save pdf file of products of supplier
        private void btnsupplier_Click(object sender, EventArgs e)
        {
            if (OnClickSupp != null)
                OnClickSupp(this, e);
        }
        //to select supplier from combobox
        private void cbsupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedIndexSupplier != null)
                SelectedIndexSupplier(this, e);
        }
        //on click to show all products
        private void btnshowall_Click(object sender, EventArgs e)
        {
            if (OnClickShowAll != null)
                OnClickShowAll(this, e);
        }
    }
}
