using iCarto.common.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCarto.tests
{
    public partial class TESTSwitchContents : Form
    {
        public TESTSwitchContents()
        {
            InitializeComponent();
        }

        private void lollipopFlatButton1_Click(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.Orange;
            Animate.AnimateWindow(this.panel1.Handle, 5000, Animate.AW_SLIDE + Animate.AW_HOR_POSITIVE);
            this.panel1.Visible = false;
            this.panel2.Visible = true;

        }

        private void lollipopFlatButton2_Click(object sender, EventArgs e)
        {
            this.panel2.Visible = false;
            this.panel1.Visible = true;
        }

      

       
    }
}
