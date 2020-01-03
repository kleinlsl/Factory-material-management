using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂物资管理.Face
{
    public class Location
    {
        public string left { get; set; }
        public string top { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string rotation { get; set; }
    }

    public class Resultadd
    {
        public string face_token { get; set; }
        public Location location { get; set; }
    }

    public class AddResult
    {
        public string error_code { get; set; }
        public string error_msg { get; set; }
        public string log_id { get; set; }
        public string timestamp { get; set; }
        public string cached { get; set; }
        public Resultadd result { get; set; }
    }
}
