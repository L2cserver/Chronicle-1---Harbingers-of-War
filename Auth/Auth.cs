using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Auth
{
    public class Auth 
    {
        public static Logger log;
        private static Auth _instance;
        private Socket ClientServerSocket;
        private IPAddress ClientListeningIP;

        private string _externalHostname;
        private string _internalHostname;

        public static int PROTOCOL_REV = 0x0101;

        public static void Main(string[] args)
        {

            string LOG_FOLDER = "log"; // Name of folder for log file
            string LOG_NAME = "/log.cfg"; // Name of log file


        }
    }
}
