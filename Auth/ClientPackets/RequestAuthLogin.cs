using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Auth.ClientPackets
{
    public class RequestAuthLogin
    {
        private string User;
        private string Password;

        public string getPassword()
        {
            return Password;
        }

        public string getUser()
        {
            return User;
        }

        public RequestAuthLogin(byte[] RawPacket, RSA Key)
        {
            try
            {
                User = Encoding.ASCII.GetString(RawPacket, 1, 14).Trim();
                User = User.ToLower();
                Password = Encoding.ASCII.GetString(RawPacket, 15, 14).Trim();
                Console.Write("[RequestAuthLogin] RequestAuthLogin от пользователя:" + User);
            }
            catch(SecurityException e)
            {
                Console.Write(e.StackTrace);
            }
        }
    }
}
