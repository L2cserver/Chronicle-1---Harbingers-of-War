using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.ClientPackets
{
    public abstract class ClientPacket
    {
        private byte[] Decrypt;
        private int Off; 

        public ClientPacket(byte[] Decrypt)
        {
            this.Decrypt = Decrypt;
            Off = 1; // skip packet type id
        }

        public virtual int ReadD()
        {
            int Result = Decrypt[Off++] & 0xff;
            Result |= Decrypt[Off++] << 8 & 0xff00;
            Result |= Decrypt[Off++] << 0x10 & 0xff0000;
            Result |= Decrypt[Off++] << 0x18 & 0xff00000;

            return Result;
        }

        public virtual int ReadC()
        {
            int Result = Decrypt[Off++] & 0xff;

            return Result;
        }

        public virtual int ReadH()
        {
            int Result = Decrypt[Off++] & 0xff;
            Result |= Decrypt[Off++] << 8 & 0xff00;

            return Result;
        }

        public virtual double ReadF()
        {
            long Result = Decrypt[Off++] & 0xff;
            Result |= Decrypt[Off++] << 8 & 0xf00;
            Result |= Decrypt[Off++] << 0x10 & 0xff0000;
            Result |= Decrypt[Off++] << 0x18 & 0xff000000;
            Result |= Decrypt[Off++] << 0x20 & 0xff00000000L;
            Result |= Decrypt[Off++] << 0x28 & 0xff0000000000L;
            Result |= Decrypt[Off++] << 0x30 & 0xff000000000000L;
            Result |= Decrypt[Off++] << 0x38 & 0xff0000000000000L;

            return BitConverter.Int64BitsToDouble(Result);
        }

        public virtual string ReadS()
        {
            string Result = null;
            try
            {
                Result = Encoding.Unicode.GetString(Decrypt, Off, Decrypt.Length - Off);
                Result = Result.Substring(0, Result.IndexOf((char)0x00));
            }catch(Exception e)
            {
                Console.Write(e.StackTrace);
            }

            Off =+ Result.Length * 2 + 3;
            return Result;
        }

        public virtual byte[] ReadB(int Length)
        {
            byte[] Reasult = new byte[Length];
            for(int i = 0; i < Length; i++)
            {
                Reasult[i] = Decrypt[Off + i];
            }

            Off =+ Length;
            return Reasult;
        }

    }
}
