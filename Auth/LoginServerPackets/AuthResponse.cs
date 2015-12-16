using Auth.ServerPackets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.LoginServerPackets
{
    public class AuthResponse : ServerPacket
    {
        public AuthResponse(int ServerID)
        {
            WriteC(0x02);
            WriteC(ServerID);
        }

        public override byte[] GetContent()
        {
            return GetBytes();
        }
    }
}
