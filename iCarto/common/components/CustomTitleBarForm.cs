using FontAwesomeIcons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCarto.common.components
{
    /// <summary>
    /// 自定义标题栏的窗体
    /// </summary>
    public partial class CustomTitleBarForm : Form
    {
        private bool moving = false;
        private Point oldMousePosition;

        public CustomTitleBarForm()
        {
            InitializeComponent();

            ResettitlePanel();

        }

        public new FormBorderStyle FormBorderStyle
        {
            get
            {
                return base.FormBorderStyle;
            }
            set
            {
                base.FormBorderStyle = value;
            }
        }

        #region 隐藏父类的属性，使其不可见

        [Browsable(false)]
        public new string Text
        {
            get
            {
                return titleLabel.Text;
            }
            set
            {
                titleLabel.Text = value;
            }
        }

        [Browsable(false)]
        public new bool ControlBox
        {
            get
            {
                return false;
            }
            set
            {
                base.ControlBox = false;
            }
        }

        #endregion

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("窗体标题")]
        public string Title
        {
            get
            {
                return titleLabel.Text;
            }
            set
            {
                titleLabel.Text = value;
            }
        }



        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("窗体标题字体样式")]
        public Font TitleFont
        {
            get
            {
                return titleLabel.Font;
            }
            set
            {
                titleLabel.Font = value;
            }
        }


        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("窗体标题字体颜色")]
        public Color TitleColor
        {
            get
            {
                return titleLabel.ForeColor;
            }
            set
            {
                titleLabel.ForeColor = value;
            }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("窗体标题栏背景色")]
        public Color TitleBarBackColor
        {
            get
            {
                return titlePanel.BackColor;
            }
            set
            {
                titlePanel.BackColor = value;
            }
        }

        private void ResettitlePanel()
        {
            base.ControlBox = false;
            base.Text = null;
            SetToolTip(closeBtn, "关闭");
            maxBtn.Size = closeBtn.Size;
            SetToolTip(maxBtn, "最大化或还原");
            minBtn.Size = closeBtn.Size;
            SetToolTip(minBtn, "最小化");
        }

        private void SetToolTip(Control ctrl, string tip)
        {
            new ToolTip().SetToolTip(ctrl, tip);
        }

        private void Titlebutton_Click(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            switch (btn.Tag.ToString())
            {
                case "close":
                    {
                        this.Close();
                        break;
                    }
                case "max":
                    {
                        if (this.WindowState == FormWindowState.Maximized)
                        {
                            this.WindowState = FormWindowState.Normal;
                        }
                        else
                        {
                            this.WindowState = FormWindowState.Maximized;
                        }

                        break;
                    }
                case "min":
                    {
                        if (this.WindowState != FormWindowState.Minimized)
                        {
                            this.WindowState = FormWindowState.Minimized;
                        }

                        break;
                    }
            }
        }

        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                return;
            }
            //titlePanel.Cursor = Cursors.NoMove2D;
            oldMousePosition = e.Location;
            moving = true;
        }

        private void titlePanel_MouseUp(object sender, MouseEventArgs e)
        {
            //titlePanel.Cursor = Cursors.Default;
            moving = false;
        }

        private void titlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && moving)
            {
                Point newPosition = new Point(e.Location.X - oldMousePosition.X, e.Location.Y - oldMousePosition.Y);
                this.Location += new Size(newPosition);
            }
        }

        private void titlePanel_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }





    }
}
