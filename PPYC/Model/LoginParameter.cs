using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPYC.Model
{
    public class LoginParameter
    {
        public static string LoginPhoneNumber;
        public static string LoginPassword;

        static LoginParameter()
        {
            LoginPhoneNumber = ConfigurationManager.AppSettings["Login_PhoneNumber"];
            LoginPassword = ConfigurationManager.AppSettings["Login_Password"];
        }
    }
}
