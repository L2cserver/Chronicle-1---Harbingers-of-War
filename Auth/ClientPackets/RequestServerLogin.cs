using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.ClientPackets
{
    public class RequestServerLogin : ClientPacket
    {
        private int _data1;
        private int _data2;
        private int _server_id;

        public int getData1()
        {
            return _data1;
        }

        public int getData2()
        {
            return _data2;
        }

        public int getServerID()
        {
            return _server_id;
        }

        public RequestServerLogin(byte[] RawPacket) : base(RawPacket)
        {
            _data1 = ReadD();
            _data2 = ReadD();

            _server_id = ReadC(); //= rawPacket[9] &0xff;
        }
    }
}
