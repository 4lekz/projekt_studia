using System;
using System.Collections;
namespace ConsoleApplication1
{
    
    internal class Program
    {
       

        public static void Main(string[] args)
        {
            Console.WriteLine("CRC");
            Console.WriteLine(Program.Crc(dane));
        }

        private static byte[] dane = new byte[] {0xFF};
        
        public static int GetBit(byte b, int bitNumber)
        {
            return (int) (b & (1 << bitNumber - 1));
        }
        public static int Crc(byte[] dane)
        {
            var crc16 = 0xF;
            

            foreach (byte t in dane)
            {
                crc16 ^= t;
                for (int j = 8; j > 0; j--)
                {
                    if (1 == Program.GetBit((byte) crc16, j))
                    {
                        Console.WriteLine("koncowy wynik");
                        Console.WriteLine(crc16);
                        crc16 ^= 0x0D;
                        //crc16 >>= 1;
                        Console.WriteLine(crc16);
                    }
                    else
                    {
                       // crc16 >>= 1;
                    }
                }
            }
            Console.WriteLine("koncowy wynik");
            return crc16;
            
            //bit parz. XOR przez 0 dla całego wyrazu np 1010 daje nam 0. Czemu?
            //bo 1 xor 0, 0 xor wynik poprzedniego działania itp
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