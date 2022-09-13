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
    /*this user control to show all orders that have cinfirmed */
    public partial class AllOrders : UserControl
    {
        public delegate void OnButtonClickSavePdf(object sender, EventArgs e);
        public event OnButtonClickSavePdf OnClickSavePdf;
        public delegate void CellDoubleClickOrder(object sender, DataGridViewCellEventArgs e);
        public event CellDoubleClickOrder CellDoubleOrder;
        public delegate void Changemonth(object sender, EventArgs e);
        public event Changemonth ChangeM;
        public delegate void OnButtonClickOrderReport(object sender, EventArgs e);
        public event OnButtonClickOrderReport OnClickOrderReport;
        public delegate  void OnButtonclickOrderY(object sender, EventArgs e);
        public event OnButtonclickOrderY OnClickOrderY;
        public AllOrders()
        {
            InitializeComponent();
        }
        //Getter From components
        public DataGridView DgvOrders
        {
            get { return this.dgvorders; }
        }
        public DataGridView DgvOrderDetails
        {
            get { return this.dgvorderdetails; }
        }
        public   TextBox tbMonth
        {
            get { return this.tbmonth; }
        }
        public DateTimePicker dtOrderMonth
        {
            get { return this.month; }
        }
        public DateTimePicker dtOrderdetailsY
        {
            get { return this.dtorderdetailsreporty; }
        }
        //on click for save Pdf file
        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (OnClickSavePdf != null)
                OnClickSavePdf(this,e);
        }
        //double click for choose order
        private void dgvorders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CellDoubleOrder != null)
                CellDoubleOrder(this, e);
        }
        //Change month 
        private void month_ValueChanged(object sender, EventArgs e)
        {
            if (ChangeM != null)
                ChangeM(this, e);
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (OnClickOrderReport != null)
                OnClickOrderReport(this, e);
        }

        private void btnOrderY_Click(object sender, EventArgs e)
        {
            if (OnClickOrderY != null)
                OnClickOrderY(this, e);
        }
    }
}
