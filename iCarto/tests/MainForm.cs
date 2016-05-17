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

            //���ô�������
            changeSkin();

            //�滻���ȵ�ͼģ������ͼ
            updateMpatThumb();

        }

       

        public void changeSkin()
        {
            //������ɫ
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