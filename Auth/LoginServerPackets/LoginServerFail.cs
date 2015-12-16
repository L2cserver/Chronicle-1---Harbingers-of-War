using Auth.ServerPackets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.LoginServerPackets
{
    public class LoginServerFail : ServerPacket
    {
        public LoginServerFail(int Reason)
        {
            WriteC(0x01);
            WriteC(Reason);
        }

        public override byte[] GetContent()
        {
            return GetBytes();
        }

        public static int REASON_IP_BANNED = 1;
        public static int REASON_IP_RESERVED = 2;
        public static int REASON_WRONG_HEXID = 3;
        public static int REASON_ID_RESERVED = 4;
        public static int REASON_NO_FREE_ID = 5;
        public static int NOT_AUTHED = 6;
        public static int REASON_ALREADY_LOGGED8IN = 7;
    }
}
