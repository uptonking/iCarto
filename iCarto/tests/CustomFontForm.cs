using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCarto.tests
{
    public partial class CustomFontForm : Form
    {
        public CustomFontForm()
        {
            InitializeComponent();

            Setfont();
        }

        public void Setfont()
        {

            try
            {
                PrivateFontCollection pfc = new PrivateFontCollection();

                //string path = System.Windows.Forms.Application.StartupPath + @"../../../";
                //System.IO.Directory.SetCurrentDirectory(path);
                //string fontPath = System.IO.Directory.GetCurrentDirectory() + @"\res\fonts\SourceHanSansSC-Regular.ttf";

                string fontPath1 = @"C:\Users\Yao\Documents\Visual Studio 2012\Projects\iCarto\iCarto\res\fonts\SourceHanSansSC-Normal.ttf";
                string fontPath2 = @"C:\Users\Yao\Documents\Visual Studio 2012\Projects\iCarto\iCarto\res\fonts\SourceHanSansSC-Regular.ttf";

                pfc.AddFontFile(fontPath1);//字体的路径及名字 
                pfc.AddFontFile(fontPath2);//字体的路径及名字 



                Font f1 = new Font(pfc.Families[0], 14);

                //Font myFont = new Font(font.Families[0].Name, 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));


                //设置窗体控件字体，哪些控件要更改都写到下面
                label1.Font = f1;
                label1.Text += "\r\n" + pfc.Families[0].Name;
                label1.Text += "\r\n" + "For both Android and web properties, the font stack should specify Roboto, Noto, ... Font size: For Title through Caption styles, the font size is 1px larger than that";

                Font f2 = new Font(pfc.Families[1], 14);
                label2.Font = f2;
                label2.Text += "\r\n" + pfc.Families[1].Name;
                label2.Text += "\r\n" + "For both Android and web properties, the font stack should specify Roboto, Noto, ... Font size: For Title through Caption styles, the font size is 1px larger than that";



                //label3.Text.Font.Size = 14.0;
                label3.Text += "\r\n" + label3.Font.Name;
                label3.Font = new Font(label3.Font.Name, 14);




            }
            catch
            {
                MessageBox.Show("字体不存在或加载失败\n程序将以默认字体显示", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
