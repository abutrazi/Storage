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
    /*this user control to managment data of employee*/
    public partial class UCEmployeeManagement : UserControl
    {

        //Delegates buttons 
        public delegate void OnButtonInsertEmployee(object sender, EventArgs e);
        public event OnButtonInsertEmployee OnclickInsertEmployee;
        public delegate void OnButtonUpdateEmployee(object sender, EventArgs e);
        public event OnButtonUpdateEmployee OnclickUpdateEmployee;
        public delegate void OnButtonDeleteEmployee(object sender, EventArgs e);
        public event OnButtonDeleteEmployee OnClickDeleteEmployee;
        public delegate void OnButtonResetTbs(object sender, EventArgs e);
        public event OnButtonResetTbs OnClickResetTbs;
        public delegate void CellDoubleClickDgvEmployee(object sender, DataGridViewCellEventArgs e);
        public event CellDoubleClickDgvEmployee CellDoubleClick;
        
        

        public UCEmployeeManagement()
        {
            InitializeComponent();
        }
        // Getters form components
        public TextBox tbId
        {
            get
            {
                return tbEmpID;
            }
        }

        public TextBox tbFname
        {
            get
            {
                return tbEmpFname;
            }
        }
        public TextBox tbLname
        {
            get
            {
                return tbEmpLname;
            }
        }
        public TextBox tbTel
        {
            get
            {
                return tbEmpTel;
            }
        }
        public TextBox tbEmail
        {
            get
            {
                return tbEmpEmail;
            }
        }
        public TextBox tbAddress
        {
            get
            {
                return tbEmpAddress;
            }
        }
        public TextBox tbUsername
        {
            get { return tbEmpUsername; }
        }

        public TextBox tbPassword
        {
            get { return tbEmpPassword; }
        }
        public DataGridView DgvEmployees
        {
            get
            {
                return dgvEmp;
            }
        }
        public ComboBox cbRole
        {
            get { return cbrole; }
        }

        // On Click for insert Employee button
        private void btnInsertEmployee_Click(object sender, EventArgs e)
        {
            if(OnclickInsertEmployee!=null)
            {
                OnclickInsertEmployee(this, e);
            }
        }

        //On Click for Update Employee button 
        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (OnclickUpdateEmployee != null)
            {
                OnclickUpdateEmployee(this, e);
            }
        }

        //Button that delete Employee
        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (OnClickDeleteEmployee != null)
            {
                OnClickDeleteEmployee(this, e);
            }
        }

        //button that Reset Fields
        private void btnResetF_Click(object sender, EventArgs e)
        {
            if(OnClickResetTbs!=null)
            {
                OnClickResetTbs(this, e);
            }
        }

        //Data Grid View  
        private void dgvEmp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           if(CellDoubleClick!=null)
            {
                CellDoubleClick(this, e);
            }
        }
    }
}
