using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂物资管理.Face
{

    public class User_list
    {
        public string group_id { get; set; }
        public string user_id { get; set; }
        public string user_info { get; set; }
        public string score { get; set; }
    }

    public class Result
    {
        public string face_token { get; set; }
        public List<User_list> user_list { get; set; }
    }

    public class SearchResult
    {
        public string error_code { get; set; }
        public string error_msg { get; set; }
        public string log_id { get; set; }
        public string timestamp { get; set; }
        public string cached { get; set; }
        public Result result { get; set; }
    }
    
}
