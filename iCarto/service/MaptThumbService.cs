using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iCarto.common.consts;
using System.Net;
using System.IO;
using iCarto.model;
using Newtonsoft.Json;

namespace iCarto.service
{
    public class MaptThumbService
    {
        string basicServerUrl = ServerConst.BASIC_SERVER;
        string imgServerUrl = ServerConst.IMG_SERVER;

        public string getMaptThumb(int id)
        {
            int imgId = id;
            string imgGetUrl = basicServerUrl + "mapt/thumb/id/" + imgId;

            HttpWebRequest request = WebRequest.Create(imgGetUrl) as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string imgResponse = reader.ReadToEnd();

            MaptThumbResponse maptThumbJson = JsonConvert.DeserializeObject<MaptThumbResponse>(imgResponse);



            string maptThumbUrl = imgServerUrl + maptThumbJson.data.maptThumbPath;


            return maptThumbUrl;

        }


    }
}
