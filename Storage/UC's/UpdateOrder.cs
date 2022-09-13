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
    /*this  user control for get data for update order */
    public partial class UpdateOrder : UserControl
    {
        //Delgates
        public delegate void OnButtonCellDoubleClickOrder(object sender, DataGridViewCellEventArgs e);
        public event OnButtonCellDoubleClickOrder OnCellDoubleClickOrder;
        public delegate void OnButtonCellDoubleClickOrderDetails(object sender, DataGridViewCellEventArgs e);
        public event OnButtonCellDoubleClickOrderDetails OnCellDoubleClickOrderDetails;
        public delegate void OnButtonCellDoubleClickProducts(object sender, DataGridViewCellEventArgs e);
        public event OnButtonCellDoubleClickProducts OnCellDoubleClickProducts;
        public delegate void OnButtonClickUpdate(object sender, EventArgs e);
        public event OnButtonClickUpdate OnClickUpdate;
        public delegate void OnButtonClickAddToOrder(object sender, EventArgs e);
        public event OnButtonClickAddToOrder OnClickAddToOrder;
        public delegate void OnButtonClickSend(object sender, EventArgs e);
        public event OnButtonClickSend OnClickSend;
        public delegate void OnButtonClickDelete(object sender, EventArgs e);
        public event OnButtonClickDelete OnClickDelete;


        public UpdateOrder()
        {
            InitializeComponent();
        }
        //Getter From components
        public TextBox tbSupplier
        {
            get { return this.tbsupplier; }
        }
        public TextBox tbProductCode
        {
            get { return this.tbproductcode; }
        }
        public TextBox tbProductName
        {
            get { return this.tbproductname; }
        }
        public TextBox tbQty
        {
            get { return this.tbqty; }
        }
        public DataGridView DgvOrder
        {
            get { return this.dgvorder; }
        }
        public DataGridView DgvOrderDetails
        {
            get
            {
                return this.dgvorderdeatils;
            }
        }
        public DataGridView DgvProducts
        {
            get { return this.dgvproducts;}
        }
        public TextBox tbPayment
        {
            get { return this.tbpayment; }
        }
        //double click for choose order
        private void dgvorder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OnCellDoubleClickOrder != null)
                OnCellDoubleClickOrder(this, e);
        }
        //double click for choose product from order
        private void dgvorderdeatils_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OnCellDoubleClickOrderDetails != null)
                OnCellDoubleClickOrderDetails(this, e);
        }
        //n clik for update product
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (OnClickUpdate != null)
                OnClickUpdate(this, e);
        }
        //double click for choose product to add to order
        private void dgvproducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OnCellDoubleClickProducts != null)
                OnCellDoubleClickProducts(this, e);
        }
        //on click to  add product to order
        private void btnaddtoorder_Click(object sender, EventArgs e)
        {
            if (OnClickAddToOrder != null)
                OnClickAddToOrder(this, e);
        }
        //on click for send order to confirme
        private void btnsend_Click(object sender, EventArgs e)
        {
            if (OnClickSend != null)
                OnClickSend(this, e);
        }
        //on click for delete product from order
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (OnClickDelete != null)
                OnClickDelete(this, e);
        }
    }
}
