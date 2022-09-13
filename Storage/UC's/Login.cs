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
    /*this user control to get data for login */
    public partial class Login : UserControl
    {
        //Delgates
        public delegate void OnButtonLogin(object sender, EventArgs e);
        public event OnButtonLogin OnclickLogin;
        public Login()
        {
            InitializeComponent();
        }
        // Getters form components
        public TextBox tbUserName
        {
            get { return tbUsername; }
        }
        public TextBox tbPassWord
        {
            get { return tbPassword; }
        }
        //on click to login
        private void button1_Click(object sender, EventArgs e)
        {
            if(OnclickLogin!=null)
            {
                OnclickLogin(this, e);
            }
        }
    }
}
