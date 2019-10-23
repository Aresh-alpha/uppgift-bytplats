using System;

namespace uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 10;
            BytPlats(ref a, ref b);
            Console.WriteLine(a + " " + b);
        }

        public static void BytPlats(ref int a, ref int b)
        {
            int byt = a;
            a = b;
            b = byt;

        }
    }
}
