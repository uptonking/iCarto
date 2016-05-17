using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using iCarto.service;

namespace iCarto
{
    public partial class MainForm : MaterialForm
    {
        private  MaterialSkinManager materialSkinManager;


        public MainForm()
        {
            InitializeComponent();

            //设置窗体主题
            changeSkin();

            //替换最热地图模板缩略图
            updateMpatThumb();

        }

       

        public void changeSkin()
        {
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