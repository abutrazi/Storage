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
    public partial class UpdateQtyDialog : Form
    {
        public UpdateQtyDialog()
        {
            InitializeComponent();
        }
        public TextBox TbNewQty
        {
            get { return this.tbnewqty; }
        }
    }
}
