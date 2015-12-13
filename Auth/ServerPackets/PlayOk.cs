using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.ServerPackets
{
    public class PlayOk : ServerPacket
    {
        // format 	dd
        //
        // 07 
        // 34 0b 00 00 
        // 14 16 0d 00
        // align+chksum  
        // 00 00 00 00 
        // 00 00 67 07 
        // 25 1d 6a 6b 66 6b 64

        public PlayOk (int SessionKey)
        {
            WriteC(0x07);
            WriteD(SessionKey); // session key ?
            WriteD(0x55667788);
        }
        public override byte[] GetContent()
        {
            return GetBytes();
        }
    }
}
