using iCarto.model.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCarto.model
{
    public class MaptThumbResponse
    {
        public MaptThumbData data { get; set; }
        public string errorCode { get; set; }
        public string errDesc { get; set; }
        public  string elapsedMilliseconds { get; set; }
        public string sussecc { get; set; }
    }
}
