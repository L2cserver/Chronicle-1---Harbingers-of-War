using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Сollection
{
    internal class ServerData
    {
        internal string Ip;
        internal int Port;
        internal bool Pvp;
        internal int CurrentPlayers;
        internal int MaxPlayers;
        internal bool TestServer;

        internal ServerData(string Ip, int Port, bool Pvp, bool TestServer, int CurrentPlayers, int MaxPlayers)
        {
            this.Ip = Ip;
            this.Port = Port;
            this.Pvp = Pvp;
            this.TestServer = TestServer;
            this.CurrentPlayers = CurrentPlayers;
            this.MaxPlayers = MaxPlayers;
        }
    }
}
