using System;

namespace Part4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Information information = new Information();
            Console.WriteLine("Please enter your information");
            Console.WriteLine("Name: ");
            information.name = Console.ReadLine();
            Console.WriteLine("Address: ");
            information.address = Console.ReadLine();
            Console.WriteLine("phone: ");
            information.phone = Console.ReadLine();
            Console.WriteLine($"The information just entered is: {information.name}, {information.address}, {information.phone}");
        }
    }
}