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
    /*this user control for managment of supplier */
    public partial class UCSupplierManagement : UserControl
    {
        //delgates
        public delegate void OnButtonClickAddSupplier(object sender, EventArgs e);
        public event OnButtonClickAddSupplier OnClickAddSupplier;
        public delegate void OnButtonClickUpdateSupplier(object sender, EventArgs e);
        public event OnButtonClickUpdateSupplier OnClickUpdateSupplier;
        public delegate void OnButtonClickDeleteSupplier(object sender, EventArgs e);
        public event OnButtonClickDeleteSupplier OnClickDeleteSupplier;
        public delegate void OnButtonClickRestFileds(object sender, EventArgs e);
        public event OnButtonClickRestFileds OnClickRest;
        public delegate void CellDoubleClickdgvSupplier(object sender, DataGridViewCellEventArgs e);
        public event CellDoubleClickdgvSupplier CellDoubleClickSupplier;
        public delegate void OnButtonClickSearch(object sender, EventArgs e);
        public event OnButtonClickSearch OnClickSearch;
        public delegate void OnButtonClickShowAll(object sender, EventArgs e);
        public event OnButtonClickShowAll OnClickShowAll;



        
        public UCSupplierManagement()
        {
            InitializeComponent();
        }

        // Getter from components
        public TextBox tbCode
        {
            get { return tbSupCode; }
        }

        public TextBox tbName
        {
            get { return tbSupName; }
        }
        public TextBox tbTel
        {
            get { return tbSupTel; }
        }
        public TextBox tbEmail
        {
            get { return tbSupEmail; }
        }
        public TextBox tbAddress
        {
            get { return tbSupAddress; }
        }
        public TextBox tbSearch
        {
            get { return tbsearch; }
        }
        public ComboBox cbSearchBy
        {
            get { return cbBy; }
        }
        public DataGridView DgvSupplier
        {
            get { return dgvSupplier; }
        }

        //Buttons Click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(OnClickAddSupplier!=null)
                OnClickAddSupplier(this,e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (OnClickUpdateSupplier != null)
                OnClickUpdateSupplier(this, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (OnClickDeleteSupplier != null)
                OnClickDeleteSupplier(this, e);
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            if (OnClickRest != null)
                OnClickRest(this, e);
        }

        private void dgvSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CellDoubleClickSupplier != null)
                CellDoubleClickSupplier(this, e);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (OnClickSearch != null)
                OnClickSearch(this, e);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            if (OnClickShowAll != null)
                OnClickShowAll(this, e);
        }
    }
}
