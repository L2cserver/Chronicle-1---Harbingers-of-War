using Auth.ServerPackets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.LoginServerPackets
{
    public class PlayerAuthResponse : ServerPacket
    {
        public PlayerAuthResponse(string Account, bool Response)
        {
            WriteC(0x03);
            WriteS(Account);
            WriteC(Response ? 1 : 0);
        }

        public override byte[] GetContent()
        {
            return GetBytes();
        }
    }
}
