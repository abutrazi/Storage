using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage
{
    public partial class Dialog : Form
    {
        
        public Dialog()
        {
            InitializeComponent();
        }
       
        public TextBox tbEmail
        {
            get { return this.tbemail; }
        }
        public TextBox tbPass
        { 
            get { return this.tbpassword; }
        }

       
    }
}
