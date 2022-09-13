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
    /*This user control to get data and generate events of produts in storage*/
    public partial class Products : UserControl
    {
        //delegates
        public delegate void OnButtonSubmitAmount(object sender, EventArgs e);
        public event OnButtonSubmitAmount OnClickSubmitAmount;
        public delegate void CellDoubleClickDgvProduct(object sender, DataGridViewCellEventArgs e);
        public event CellDoubleClickDgvProduct CellDoubleClickAmount;
        public delegate void OnButtonClickSearch(object sender, EventArgs e);
        public event OnButtonClickSearch OnClickSearch;
        public delegate void OnButtonClickShowAll(object sender, EventArgs e);
        public event OnButtonClickShowAll OnClickShowAll;

        public Products()
        {
            InitializeComponent();
        }
        //Getter From components
        public TextBox tbCode
        {
            get { return tbcode; }
        }

        public TextBox tbName
        {
            get { return tbname; }
        }

        public TextBox tbSize
        {
            get { return tbsize; }
        }

        public TextBox tbAmount
        {
            get { return tbamount; }
        }

        public RadioButton RbImport
        {
            get { return rbimport; }
        }

        public RadioButton RbExport
        {
            get { return rbexport; }
        }
        public TextBox tbSearch
        {
            get { return tbsearch; }
        }
        public ComboBox cbSearchBy
        {
            get { return cbBy; }
        }
        public DataGridView DgvProduct
        {
            get { return dgvproduct; }
        }
        //on click submit
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (OnClickSubmitAmount != null)
                OnClickSubmitAmount(this, e);
        }

        private void dgvproduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CellDoubleClickAmount != null)
                CellDoubleClickAmount(this, e);
        }
        //on click to search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (OnClickSearch != null)
                OnClickSearch(this, e);
        }
        //on click show all
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            if (OnClickShowAll != null)
                OnClickShowAll(this, e);
        }
    }
}
