using System;
using System.Collections;
namespace ConsoleApplication1
{
    
    internal class Program
    {
        private static byte[] cos2 = new byte[]{1,0,1,0,1,0,0,0,1,1,1};
        public static int GetBit(byte b, int bitNumber)
        {
            return (int) (b & (1 << bitNumber - 1));
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(cos2);
        }

        public static int Crc(byte[] cos2)
        {
            var crc16 = 0xFFFF;
            

            for (int i = 0; i < cos2.Length; i++)
            {
                crc16 = cos2[i] ^ crc16;
                for (int j = 0; j < 8; j++)
                {
                    if (1 == Program.GetBit((byte) crc16, 1))
                    {
                        crc16 = crc16 >> 1;
                        crc16 = crc16 ^ 0xA001;

                    }
                    else
                    {
                        crc16 = crc16>>1;
                    }
                }
            }
//            byte b, a, p;
//            //byte m;
//            char[] cos2 = new char[]{'a','b','o','r'};
//            char[] m = new char[] {'b'};
//            a = 0;
            
            
//            foreach (var v in cos2)
//            {
//                for (int j = 0; j < 8; j++)
//                {
//                    m = (byte) (1 << (j - 1));
//                    b = (byte) ((v & m) >> (j - 1));
//                    a ^= b;
//                }
//            }
//            
//            foreach (var v in cos2)
//            {
//                
//                a ^= (byte)(v$cos2);
//                Console.WriteLine(a);
//            }
//            for (int i = 0; i < cos2.Length ; i++)
//            {
//                for (int j = 0; j < 8; j++)
//                {
//                   // p=Convert.ToByte(j);
//                    m= (byte)(1<<(j-1));
//                    b = (byte)((cos2[i] & m) >> (j - 1));
//                    a ^= b;
//                    
//
//                }
//            }
            
//            Console.WriteLine(a);
        }
    }
}