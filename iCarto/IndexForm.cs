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

namespace iCarto
{
    public partial class IndexForm : MaterialForm
    {

        Timer timer;
        int initialLocation = 0;
        int padding = 50;

        public IndexForm()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += new EventHandler(timer_Tick);

            initialLocation = this.indexPanel.Location.X;

        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (initialLocation + this.indexPanel.Location.X < this.indexPanel.Size.Width)
            {
                this.indexPanel.Location = new Point(this.indexPanel.Location.X + padding, this.indexPanel.Location.Y);
                this.editPanel.Location = new Point(this.editPanel.Location.X + padding, this.editPanel.Location.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }


    }
}
