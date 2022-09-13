using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Storage.Classes;

namespace Storage.UC_s
{
    public partial class Statics : UserControl
    {
        public delegate void OnClickButtonSavemostapp(object sender, EventArgs e);
        public event OnClickButtonSavemostapp Onclicksavemostapp;
        public delegate void Changemonth(object sender, EventArgs e);
        public event Changemonth ChangeM;
        public Statics()
        {
            InitializeComponent();
        }
        
       public DateTimePicker FirstD
        {
            get { return this.firstdate; }
        }
        public DateTimePicker SecD
        {
            get { return this.seconddate; }
        }
        public DateTimePicker DateM
        {
            get { return this.date; }
        }
        //Chart1 quntity of products in orders for specific month
        public void Loadchart1(OrderDetails[] od)
        {
            chart1.Series["Qty"].IsValueShownAsLabel = true;
            if (chart1.Series["Qty"].Points.Count > 0)            
                chart1.Series["Qty"].Points.Clear();
            
                for (int i = 0; i < od.Length; i++)
                {
                    chart1.Series["Qty"].Points.AddXY(od[i].ProductName.ToString(), od[i].Quantity.ToString());
                }
            
        }
        public void LoadChart2(Product[] p)
        {
            chart2.Series["prod"].IsValueShownAsLabel = true;
            for(int i=0;i<p.Length; i++)
            {
                chart2.Series["prod"].Points.AddXY(p[i].ProdName.ToString(), p[i].ProdAmount.ToString());
                
            }
        }

        private void btnmostapp_Click(object sender, EventArgs e)
        {
            if (Onclicksavemostapp != null)
                Onclicksavemostapp(this, e);
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            if (ChangeM != null)
                ChangeM(this, e);
        }
    }
}
