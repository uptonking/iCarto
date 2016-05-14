
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

using iCarto.Tests.consts;

namespace iCarto.Tests
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            getImage();

        }

        public void getImage()
        {
            string basicServerUrl = ServerConst.ICARTO_BASIC_SERVER;
            string thumbServerUrl = ServerConst.MAPTTHUMB_SERVER;
            string imgGetUrl = basicServerUrl + "mapt/images/12";


            HttpWebRequest request = WebRequest.Create(imgGetUrl) as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string imgResponse = reader.ReadToEnd();

            MaptThumbResponse maptThumbJson = JsonConvert.DeserializeObject<MaptThumbResponse>(imgResponse);



            string maptThumbUrl = thumbServerUrl + maptThumbJson.data.maptThumbPath;



            //方法1：直接加载网络图片
            pictureBox1.Load(maptThumbUrl);


            //方法2：通过请求加载
            //Image newImg = Image.FromStream(WebRequest.Create("http://www.cma.gov.cn/tqyb/img/city/54823.jpg").GetResponse().GetResponseStream());
            //pictureBox1.BackgroundImage = newImg;

        }
    }
}
