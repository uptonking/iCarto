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
    public partial class TESTForm1 : Form
    {
        public TESTForm1()
        {
            InitializeComponent();
        }

        //获取Form的宽度和高度
        private void button1_Click(object sender, EventArgs e)
        {
            this.lollipopLabel3.Text = this.ClientSize.Width.ToString();
            this.lollipopLabel4.Text = this.ClientSize.Height.ToString();
            this.lollipopLabel5.Text = this.Size.Width.ToString();
            this.lollipopLabel6.Text = this.Size.Height.ToString();
        }
    }
}
