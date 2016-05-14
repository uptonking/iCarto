using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCarto.Tests.tests
{
    public partial class TESTForm : Form
    {
        public TESTForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5000; i++)
            {
                label1.Text = i.ToString();
                //
                Application.DoEvents();//让win form执行代码时同时处理其他事情
            }
        }  
    }
}
