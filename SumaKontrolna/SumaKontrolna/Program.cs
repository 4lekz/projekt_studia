using System;
using System.Collections;
namespace ConsoleApplication1
{
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            byte b, a, p;
            byte m;
            char[] cos2 = new char[]{'a','b','o','r'}    ;
            //byte[] m = new byte[] {1, 0, 1, 1};
            a = 0;
            foreach (var v in cos2)
            {
                for (int j = 0; j < 8; j++)
                {
                    m = (byte) (1 << (j - 1));
                    b = (byte) ((v & m) >> (j - 1));
                    a ^= b;
                }
            }
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
            Console.WriteLine(a);
        }
    }
}