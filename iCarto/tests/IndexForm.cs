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
using MaterialSkin;
using iCarto.common.consts;
using iCarto.service;

namespace iCarto
{
    public partial class IndexForm : MaterialForm
    {

        public IndexForm()
        {
            InitializeComponent();

            //设置窗体皮肤
            changeSkin();

            //替换最热地图模板缩略图
            updateMpatThumb();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SlidingManager slidingMgr = new SlidingManager(this.indexPanel, this.editPanel);
            slidingMgr.startSliding(DirectionEnum.LEFT_TO_RIGHT);

            slidingMgr = null;
            GC.Collect();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            SlidingManager slidingMgr = new SlidingManager(this.indexPanel, this.editPanel);
            slidingMgr.startSliding(DirectionEnum.RIGHT_TO_LEFT);

            slidingMgr = null;
            GC.Collect();
        }

        //方法：Form改变大小时，Panel填充Form
        private void IndexForm_SizeChanged(object sender, EventArgs e)
        {
            this.indexPanel.Width = this.ClientSize.Width;
            this.indexPanel.Height = this.ClientSize.Height - 65;
            this.editPanel.Width = this.ClientSize.Width;
            this.editPanel.Height = this.ClientSize.Height - 65;
            this.editPanel.Location = new Point(-this.ClientSize.Width, this.editPanel.Location.Y);
            //调试panel的坐标Location.X
            //MessageBox.Show("this.editPanel.Width: " + this.editPanel.Width + ";" + "this.editPanel.X: " + this.editPanel.Location.X);

        }


        public void changeSkin()
        {
            MaterialSkinManager materialSkinManager;

            //更改颜色
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);

        }


        public void updateMpatThumb()
        {
            this.pictureBox1.Load(new MaptThumbService().getMaptThumb(11));
        }



    }
}
