using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂物资管理.Face
{
    class Util
    {
        /// <summary>
        /// 图片转换为Base64
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        /*public  static string ImgToBase64String(string image)
        {
            try
            {
                Bitmap bmp = new Bitmap(image, true);
                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arr, 0, (int)ms.Length);
                ms.Close();

                return Convert.ToBase64String(arr);
            }
            catch (Exception ex)
            {
                return null;
            }
        }*/
        public static string ImgToBase64String(Bitmap bmp)
        {
            try
            {
               // Bitmap bmp = image;
                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arr, 0, (int)ms.Length);
                ms.Close();
                

                return Convert.ToBase64String(arr);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
