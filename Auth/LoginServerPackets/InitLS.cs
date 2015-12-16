using Auth.ServerPackets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.LoginServerPackets
{
    public class InitLS : ServerPacket
    {
        // ID 0x00
        // format
        // d proto rev
        // d key size
        // b key

        public InitLS(byte[] PublicKey)
        {
            WriteC(0x00);
            
            WriteD(PublicKey.Length);
            WriteB(PublicKey);
        }

        public override byte[] GetContent()
        {
            return GetBytes();
        }
    }
}
