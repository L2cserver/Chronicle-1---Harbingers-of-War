using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Auth.ServerPackets
{
    public abstract class ServerPacket
    {
        internal MemoryStream Stream;
        protected internal ServerPacket()
        {
            Stream = new MemoryStream();
        }

        protected internal virtual void WriteD(int Value)
        {
            Stream.WriteByte((byte)((Value & 0xff)));
            Stream.WriteByte((byte)((Value >> 8 & 0xff)));
            Stream.WriteByte((byte)((Value >> 16 & 0xff)));
            Stream.WriteByte((byte)((Value >> 24 & 0xff)));
        }
        protected internal virtual void WriteH(int Value)
        {
            Stream.WriteByte((byte)((Value & 0xff)));
            Stream.WriteByte((byte)((Value >> 8 & 0xff)));
        }

        protected internal virtual void WriteC(int Value)
        {
            Stream.WriteByte((byte)((Value & 0xff)));
        }

        protected internal virtual void WriteF(double org)
        {
            byte[] Value = BitConverter.GetBytes(org);
            Stream.Write(Value, 0, Value.Length);

        }

        protected internal virtual void WriteS(string text)
        {
            try
            {
                if (text != null)
                {
                    byte[] byteText = Encoding.Unicode.GetBytes(text);
                    Stream.Write(byteText, 0, byteText.Length);
                }
            }
            catch(Exception e)
            {
                StackTrace st = new StackTrace(true);
                for (int i = 0; i < st.FrameCount; i++)
                {
                    StackFrame sf = st.GetFrame(i);
                    Console.WriteLine();
                    Console.WriteLine("Вызвать стек метода : {0}", sf.GetMethod());
                    Console.WriteLine("Стек вызова. Номер строки: {0}", sf.GetFileLineNumber());
                }
            }

            Stream.WriteByte(0);
            Stream.WriteByte(0);
        }



        public virtual int GetLength()
        {
            return ((int)Stream.Length - 2);
        }

        public virtual byte[] GetBytes()
        {

                WriteD(0x00); // reserve for checksum

                int padding = (int)(Stream.Length) % 8;
                if(padding != 0)
                {
                    for (int i = padding; i < 8; i++)
                    {
                        WriteC(0x00);
                    }
                }

                return Stream.ToArray();
            
        }

        public abstract byte[] GetContent();

    }
}
