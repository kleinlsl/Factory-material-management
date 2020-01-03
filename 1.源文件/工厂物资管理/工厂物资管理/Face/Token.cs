using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂物资管理.Face
{
    class Token
    {
     
        public string refresh_token { get; set; }
        public string expires_in { get; set; }
        public string session_key { get; set; }
        public string access_token { get; set; }
        public string scope { get; set; }
        public string session_secret { get; set; }
        
    }
}
