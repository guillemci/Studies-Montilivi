using System;
using System.Reflection;
using System.Reflection.Metadata;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int any = Convert.ToInt32(Console.ReadLine());


            if (!(any >= 2001 && any <= 2100) && ((any % 400 == 0) || (any % 4 == 0 && any % 100 != 0)))
            {
                Console.WriteLine(any);
            }
        }
    }
}
