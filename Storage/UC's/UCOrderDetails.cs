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
    /*this user control for get data of new order*/
    public partial class UCOrderDetails : UserControl
    {
        // Delegates
        public delegate void OnButtonClickAddToOrder(object sender, EventArgs e);
        public event OnButtonClickAddToOrder OnclickAddToOrder;
        public delegate void OnButtonClickDeleteToOrder(object sender, EventArgs e);
        public event OnButtonClickDeleteToOrder OnclickDeletefromOrder;
        public delegate void OnButtonClickUpdateOrder(object sender, EventArgs e);
        public event OnButtonClickUpdateOrder OnclickUpdateOrder;
        public delegate void OnButtonCellDoubleClickdgvPrdouctList(object sender, DataGridViewCellEventArgs e);
        public event OnButtonCellDoubleClickdgvPrdouctList OnCellDoubleClickdgvProductList;
        public delegate void OnButtonCellDoubleClickdgvOrderList(object sender, DataGridViewCellEventArgs e);
        public event OnButtonCellDoubleClickdgvOrderList OnCellDoubleClickdgvOrderList;
        public delegate void OnButtonClickSend(object sender, EventArgs e);
        public event OnButtonClickSend OnClickSend;
        public delegate void SelectedIndex(object sender, EventArgs e);
        public event SelectedIndex SelectedIndexSupplier;


        public UCOrderDetails()
        {
            InitializeComponent();
        }
        //Getter From components
        public TextBox tbProductCode
        {
            get { return this.tbproductcode; }
        }

        public TextBox tbProductName
        {
            get { return this.tbproductname; }
        }

        public TextBox tbProductQty
        {
            get { return this.tbprodqty; }
        }
        public TextBox tbPayment
        {
            get { return this.tbpayment; }
        }
        public DataGridView dgvOrderDetails
        {
            get { return this.dgvorder; }
        }

        public DataGridView dgvProdList
        {
            get { return this.dgvorderproductList; }
        }

        public ComboBox cbSupplier
        {
            get { return this.cbsupplier; }
            set
            {
                if (value.Text != "")
                    this.cbsupplier = value;
            }
        }
        //on click add product to order
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (OnclickAddToOrder != null)
                OnclickAddToOrder(this, e);
        }
        //on click to send order for confirme
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (OnClickSend != null)
                OnClickSend(this, e);
        }
        //on double click to choose product for add to order
        private void dgvorderproductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OnCellDoubleClickdgvProductList != null)
                OnCellDoubleClickdgvProductList(this, e);
        }
        //on click to delete product from order
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (OnclickDeletefromOrder != null)
                OnclickDeletefromOrder(this, e);
        }
        //double click on product fromorder to update quntity
        private void dgvorder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OnCellDoubleClickdgvOrderList != null)
                OnCellDoubleClickdgvOrderList(this, e);
        }
        //on click for update data 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (OnclickUpdateOrder != null)
                OnclickUpdateOrder(this, e);
        }
        //for choose supllier
        private void cbsupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedIndexSupplier != null)
                SelectedIndexSupplier(this, e);
        }
    }
}
