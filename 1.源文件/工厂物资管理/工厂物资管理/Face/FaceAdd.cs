using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace 工厂物资管理.Face
{
    class FaceAdd
    {
        // 人脸注册
        //
        // error 已存在
        //  
        public static AddResult add(string image,string userid)
        {

            String strJson = AuthService.getAccessToken();
    
            Token token = JsonConvert.DeserializeObject<Token>(strJson);
          
            string host = "https://aip.baidubce.com/rest/2.0/face/v3/faceset/user/add?access_token=" + token.access_token;
            Encoding encoding = Encoding.Default;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(host);
            request.Method = "post";
            request.KeepAlive = true;
            String str = "{" +
                "\"image\":\""+image+"\"," +
                "\"image_type\":\"BASE64\"," +
                "\"group_id\":\"user\"," +
                "\"user_id\":\""+userid+"\"," +
                "\"user_info\":\"null\"," +
                "\"quality_control\":\"NORMAL\"," +
                "\"liveness_control\":\"NORMAL\"" +
                "}";
            byte[] buffer = encoding.GetBytes(str);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default);
            string result = reader.ReadToEnd();
            AddResult addResult = JsonConvert.DeserializeObject<AddResult>(result);
            return addResult;
        }

    }
}
