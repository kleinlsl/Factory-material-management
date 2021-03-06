﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace 工厂物资管理.Face
{
    class FaceDetect
    {
        // 人脸检测与属性分析
        public static string faceDetect(string image)
        {
            String strJson = AuthService.getAccessToken();

            Token token = JsonConvert.DeserializeObject<Token>(strJson);


            string host = "https://aip.baidubce.com/rest/2.0/face/v3/detect?access_token=" + token.access_token;
            Encoding encoding = Encoding.Default;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(host);
            request.Method = "post";
            request.KeepAlive = true;
            String str = "{" +
                "\"image\":\"027d8308a2ec665acb1bdf63e513bcb9\"," +
                "\"image_type\":\"FACE_TOKEN\"," +
                "\"face_field\":\"faceshape,facetype\"" +
                "}";
            byte[] buffer = encoding.GetBytes(str);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default);
            string result = reader.ReadToEnd();
            Console.WriteLine("人脸检测与属性分析:");
            Console.WriteLine(result);
            return result;
        }
    }
}
