using Auth.Сollection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Auth.ServerPackets
{
    public class ServerList : ServerPacket
    {
        // cc (cddcchhcd)

        // 04 
        // 10
        // 05

        // 01 
        // dc 4c 0c 33 
        // 61 1e 00 00 
        // 0f 
        // 01 
        // f7 0a 
        // 7c 15 
        // 01 

        // 02 
        // dc 4c 0c 69 
        // 61 1e 00 00 
        // 0f 
        // 01 
        // 3c 09
        // 7c 15
        // 01
        private ArrayList Servers;

        //	    private byte[] _content = {
        //		(byte)0x04,
        //		(byte)0x02,			// number of servers in list
        //		(byte)0x00,			// login server num ... seems to be unused
        //				
        //		(byte)0x01,									// server id
        //		(byte)0xc0,(byte)0xa8,(byte)0x00,(byte)0x01,   // 192.68.0.1
        //		
        //		(byte)0x61,(byte)0x1e,(byte)0x00,(byte)0x00,   // port 7777
        //		(byte)0x12,
        //		(byte)0x01,
        //		(byte)0xf7,(byte)0x0a,
        //		
        //		(byte)0x7c,(byte)0x15,
        //		(byte)0x01,
        //
        //		(byte)0x02,									// server id
        //		(byte)0xc0,(byte)0xa8,(byte)0x00,(byte)0x01,   // 192.68.0.1
        //		
        //		(byte)0x61,(byte)0x1e,(byte)0x00,(byte)0x00,   // port 7777
        //		(byte)0x0f,				// age limit
        //		(byte)0x00,				// pvp possible
        //		(byte)0x00,(byte)0x00,	// current player count
        //
        //		(byte)0x10,(byte)0x27,  // max players
        //		(byte)0x01,		// testing == 0
        //		
        //		0x00,0x00,0x00,0x00,	// align and checksum
        //		0x00,
        //		
        //		0x00,0x00,0x00,
        //		0x00,0x00,0x00,0x00,
        //		0x00
        //	};	

        public ServerList()
        {
            Servers = new ArrayList();
        }

        public virtual void addServer(string Ip, int Port, bool Pvp, bool TestServer, int CurrentPlayer, int MaxPlayer)
        {
            Servers.Add(new ServerData(Ip, Port, TestServer, Pvp, CurrentPlayer, MaxPlayer));
        }

        public override byte[] GetContent()
        {
            WriteC(0x04);
            WriteC(Servers.Count);
            WriteC(0x00);
            for(int i = 0; i < Servers.Count; i++)
            {
                ServerData server = (ServerData)Servers[i];
                WriteC(i + 1);// Server Id
                try
                {
                    IPAddress i4 = IPAddress.Parse(server.Ip);
                    Console.Write(i4.ToString());
                }
                catch(FormatException e)
                {
                    Console.Write(e.Message);
                    IPAddress i4 = IPAddress.Parse(server.Ip);
                    WriteD((int)(i4.Address));

                }

                WriteD(server.Port);
                WriteC(0x0f);// age limit
                if (server.Pvp)
                {
                    WriteC(0x01);
                }
                else
                {
                    WriteC(0x00);
                }

                WriteH(server.CurrentPlayers);
                WriteH(server.MaxPlayers);
                WriteC(0x01);// testing - nope
                if (server.TestServer)
                {
                    WriteD(0x04);
                }
                else
                {
                    WriteD(0x00);
                }
            }
            return GetBytes();
        }

    }
}

