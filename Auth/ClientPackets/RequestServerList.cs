using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.ClientPackets
{
    public class RequestServerList : ClientPacket
    {
        private int _data1;
        private int _data2;
        private int _data3;

        public int getData1()
        {
            return _data1;
        }

        public int getData2()
        {
            return _data2;
        }

        public int getData3()
        {
            return _data3;
        }

        public RequestServerList(byte[] RawPacket) : base(RawPacket)
        {
            _data1 = ReadD();
            _data2 = ReadD();
            _data3 = ReadC();
        }



    }
}
