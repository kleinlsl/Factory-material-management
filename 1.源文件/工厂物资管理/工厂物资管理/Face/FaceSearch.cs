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
   
    public class FaceSearch
    {
        // 人脸搜索
        public static SearchResult faceSearch(string image)
        {
            String strJson = AuthService.getAccessToken();

            Token token = JsonConvert.DeserializeObject<Token>(strJson);

            string host = "https://aip.baidubce.com/rest/2.0/face/v3/search?access_token=" + token.access_token;
            Encoding encoding = Encoding.Default;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(host);
            request.Method = "post";
            request.KeepAlive = true;
            String str = "{" +
                "\"image\":\""+image+"\"," +
                "\"image_type\":\"BASE64\"," +
                "\"group_id_list\":\"user\"," +
                "\"quality_control\":\"NORMAL\"," +
                "\"liveness_control\":\"NORMAL\"" +
                "}";
            byte[] buffer = encoding.GetBytes(str);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default);
            string result = reader.ReadToEnd();
            //            Console.WriteLine("人脸搜索:");
            //           Console.WriteLine(result);
            SearchResult searchResult = JsonConvert.DeserializeObject<SearchResult>(result);
            return searchResult;
        }
    }
    
}
