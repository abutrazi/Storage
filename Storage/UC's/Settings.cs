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
    /*this user control for change info of company*/
    public partial class Settings : UserControl
    {
        public delegate void OnButtonClickSave(object sender, EventArgs e);
        public event OnButtonClickSave OnClickSave;
        public Settings()
        {
            InitializeComponent();
        }
        //Getter From components
        public TextBox tbName
        {
            get { return this.tbname; }
        }
        public TextBox tbEmail
        {
            get { return this.tbemail; }
        }
        public TextBox tbNewName
        {
            get { return this.tbnewname; }
        }
        public TextBox tbNewEmail
        {
            get { return this.tbnewemail; }
        }
        public TextBox tbNewPassword
        {
            get { return this.tbnewpassord; }
        }
        //on click for save info 
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (OnClickSave != null)
                OnClickSave(this, e);
        }
    }
}
