using Auth.ServerPackets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.LoginServerPackets
{
    public class KickPlayer : ServerPacket
    {
        public KickPlayer(string Account)
        {
            WriteC(0x04);
            WriteS(Account);
        }


        public override byte[] GetContent()
        {
            return GetBytes();
        }
    }
}
