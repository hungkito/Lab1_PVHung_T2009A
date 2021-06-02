using System;

namespace Part4_Exc5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int i, number, fact;
            number = 1;
            fact = number;
            for (i = number; i < 20; i++)
            {
                Console.WriteLine(fact = fact * i);
            }
        }
    }
}