using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.ServerPackets
{
    public class LoginOk : ServerPacket
    {
        private int SessionKey;

        public LoginOk(int SessionKey)
        {
            this.SessionKey = SessionKey;
        }

        public override byte[] GetContent()
        {
            WriteC(3);
            WriteD(1431655765);
            WriteD(SessionKey);
            WriteD(0);
            WriteD(0);
            WriteD(1002);
            WriteD(0);
            WriteD(0);
            WriteD(2);
            return GetBytes();
        }
    }
}
