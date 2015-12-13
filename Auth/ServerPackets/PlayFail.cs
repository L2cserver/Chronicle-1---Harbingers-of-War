namespace Auth.ServerPackets
{
    public class PlayFail : ServerPacket
    {
        // format c
        //
        // 07 
        // 34 0b 00 00 
        // 14 16 0d 00
        // align+chksum  
        // 00 00 00 00 
        // 00 00 67 07 
        // 25 1d 6a 6b 66 6b 64 

        public static int REASON_TOO_MANY_PLAYERS = 0x0f;
        public static int REASON1 = 0x01; // account in use
        public static int REASON2 = 0x02;
        public static int REASON3 = 0x03;
        public static int REASON4 = 0x04;

        public PlayFail(int Reason)
        {
            WriteC(0x06);
            WriteC(Reason); // too many players on server
        }

        public override byte[] GetContent()
        {
            return GetBytes();
        }
    }
}
