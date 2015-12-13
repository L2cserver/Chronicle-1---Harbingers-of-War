namespace Auth.ServerPackets
{
    public class LoginFail : ServerPacket
    {
        public static int REASON_ACCOUNT_BANNED = 0x09;
        public static int REASON_ACCOUNT_IN_USE = 0x07;
        public static int REASON_ACCESS_FAILED = 0x04;
        public static int REASON_USER_OR_PASS_WRONG = 0x03;
        public static int REASON_PASS_WRONG = 0x02;
        public static int REASON_SYSTEM_ERROR = 0x01;

        public LoginFail(int Reason)
        {
            WriteC(0x01);
            WriteD(Reason);
        }

        public override byte[] GetContent()
        {
            return GetBytes();
        }
    }
}
