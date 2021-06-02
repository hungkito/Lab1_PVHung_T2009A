using System;
using System.Text;

namespace Part4_Exc2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Enter the number 1: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number 2: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number 3: ");
            int c = int.Parse(Console.ReadLine());
            int max = a;
            max = a > b ? (a > c ? a : c) : (b > c ? b : c);
            Console.WriteLine("Max in 3 numbers {0}, {1}, {2} is {3}",a,b,c,max);
            Console.ReadKey();
        }
    }
}