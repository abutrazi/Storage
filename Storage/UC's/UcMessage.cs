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
    /*this user control to show all messages and confirm order for send to supplier*/
    public partial class UcMessage : UserControl
    {
        public delegate void OnButtonClickOK(object sender, EventArgs e);
        public event OnButtonClickOK OnClickOk;
        public delegate void OnbuttonCellDoubleClickMsg(object sender, DataGridViewCellEventArgs e);
        public event OnbuttonCellDoubleClickMsg OnCellDoubleClickMsg;
        public delegate void OnCellDoubleClickMsgOrderDetails(object sender, DataGridViewCellEventArgs e);
        public event OnCellDoubleClickMsgOrderDetails OnCellDoubleClickMOD;


        public UcMessage()
        {
            InitializeComponent();
        }
        //Getter From components
        public TextBox tbOrdercode
        {
            get { return this.tbordercode; }
            set
            {
                if (value.Text != "")
                    this.tbordercode = value;
            }
        }
        public TextBox tbOrderDate
        {
            get { return this.tborderdate; }
            set
            {
                if (value.Text != "")
                    this.tborderdate = value;
            }
        }
        public TextBox tbSupplierName
        {
            get { return this.tbsuppliername; }
            set
            {
                if (value.Text != "")
                    this.tbsuppliername = value;
            }
        }
        public TextBox tbPayment
        {
            get { return this.tbpayment; }
            set
            {
                if (value.Text != "")
                    this.tbpayment = value;
            }
        }

        public DataGridView DgvMsg
        {
            get { return this.dgvmsgs; }
        }
        public DataGridView DgvmsgOrderDetails
        {
            get { return this.dgvorderdtls; }
        }


        //on click for send order
        private void btnok_Click(object sender, EventArgs e)
        {
            if (OnClickOk != null)
                OnClickOk(this, e);
        }

        private void dgvmsgs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OnCellDoubleClickMsg != null)
                OnCellDoubleClickMsg(this, e);
        }

        private void dgvorderdtls_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OnCellDoubleClickMOD != null)
                OnCellDoubleClickMOD(this, e);
        }
    }
}
