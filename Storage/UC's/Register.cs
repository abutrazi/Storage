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
    /*this user control to get data of Employee*/
    public partial class Register : UserControl
    {
        public delegate void OnButtonRegister(object sender, EventArgs e);
        public event OnButtonRegister OnclickRegister;
       
        public Register()
        {
            InitializeComponent();
        }
        // Getters form components
        public TextBox tbid
        {
            get  { return tbID; }
        }
        public TextBox tbFName
        {
            get { return tbFname; }
        }
        public TextBox tbLName
        {
            get { return tbLname; }
        }
        public TextBox tbTel
        {
            get { return tbTelphone; }
        }
        public TextBox tbEMAIL
        {
            get { return tbEmail; }
        }
        public TextBox tbAdd
        {
            get { return tbAddress; }
        }

        public TextBox tbUserName
        {
            get { return tbUsername; }
        }

        public TextBox tbPass1
        {
            get { return tbPassword; }
        }

        public TextBox tbPass2
        {
            get { return tbConfirmPassword; }
        }
        public TextBox tbCompName
        {
            get { return this.tbcompanyname; }
        }
        public TextBox tbCompEmail
        {
            get { return this.tbcompanyemail; }
        }
        public TextBox tbCompPass
        {
            get { return this.tbcompanyassword; }
        }

        //On click for Register
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (OnclickRegister != null)
                OnclickRegister(this, e);
        }
    }
}
