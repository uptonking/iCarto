using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCodeKing.ActiveButtons.Controls;

namespace iCarto.views
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();

            addSlideToggle();

        }

        public void addSlideToggle(){
            // get an instance of IActiveMenu used to attach
            // buttons to the form
            IActiveMenu menu = ActiveMenu.GetInstance(this);

            // define a new button
            ActiveButton button = new ActiveButton();
            button.Text = "FUCK";
            menu.ToolTip.SetToolTip(button, "Tooltip " + button.Text);
            button.BackColor = this.BackColor;

            // add the button to the menu
            menu.Items.Add(button);

        }

    }
}
