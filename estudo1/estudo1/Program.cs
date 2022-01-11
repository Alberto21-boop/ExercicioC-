using System;

namespace estudo1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool a = 3 > 5 && 10 != 9;
            bool b = 3 < 5 || 10 > 9;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}