using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂物资管理.DB
{
    class DBConnStr
    {

        public static string ConnStr
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["LSL"].ConnectionString;
            }
        }

        public static string DES_MD5_Key
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["DES_MD5_Key"].ConnectionString;
            }
        }
    }
}
