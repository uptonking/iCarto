using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iCarto.common.utils;

namespace iCarto
{
    public partial class IndexForm : MaterialForm
    {


        public IndexForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SlidingManager slidingMgr = new SlidingManager(this.indexPanel, this.editPanel);
            slidingMgr.SlidingRight();
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SlidingManager slidingMgr = new SlidingManager(this.indexPanel, this.editPanel);
            slidingMgr.SlidingLeft();
            
        }

        //方法：Form改变大小时，Panel填充Form
        private void IndexForm_SizeChanged(object sender, EventArgs e)
        {
            this.indexPanel.Width = this.ClientSize.Width;
            this.indexPanel.Height = this.ClientSize.Height - 65;
            this.editPanel.Width = this.ClientSize.Width;
            this.editPanel.Height = this.ClientSize.Height - 65;
        }





    }
}
