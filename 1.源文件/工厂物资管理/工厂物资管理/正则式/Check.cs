using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂物资管理.正则式
{
    class Check
    {
       // 验证电话号码的主要代码如下：

        public static bool IsTelephone(string str_telephone)
        {

            return System.Text.RegularExpressions.Regex.IsMatch(str_telephone, @"^(\d{3,4}-)?\d{6,8}$");

        }

        // 验证手机号码的主要代码如下：

        public static bool IsHandset(string str_handset)
        {

            return System.Text.RegularExpressions.Regex.IsMatch(str_handset, @"^[1](([3][0-9])|([4][5-9])|([5][0-3,5-9])|([6][5,6])|([7][0-8])|([8][0-9])|([9][1,8,9]))[0-9]{8}$");

        }

       // 验证身份证号的主要代码如下：

        public static bool IsIDcard(string str_idcard)
        {

            return System.Text.RegularExpressions.Regex.IsMatch(str_idcard, @"(^\d{18}$)|(^\d{15}$)");

        }

       // 验证输入为数字的主要代码如下：

          public static bool IsNumber(string str_number)

        {

            return System.Text.RegularExpressions.Regex.IsMatch(str_number, @"^[0-9]*$");

        }

       // 验证邮编的主要代码如下：

          public static bool IsPostalcode(string str_postalcode)

        {

            return System.Text.RegularExpressions.Regex.IsMatch(str_postalcode, @"^\d{6}$");

        }

        /// <summary>
        /// 验证邮箱
        /// </summary>
        /// <param name="str_Email"></param>
        /// <returns></returns>
        public static bool IsEmail(string str_Email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(str_Email, @"\\w{1,}@\\w{1,}\\.\\w{1,}");
        }
    }
}
