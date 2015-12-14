using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.ServerPackets
{
    public class Init
    {
        private static byte[] Content =
        {
            0x00,
            0x9c,
            0x77,
            0xed,
            0x03,
            0x5a,
            0x78,
            0x00,
            0x00 };

        public virtual byte[] GetContent()
        {
            return Content;
        }
        public virtual int GetLength()
        {
            return Content.Length + 2;
        }
    }
}
