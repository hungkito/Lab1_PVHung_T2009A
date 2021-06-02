using System;

namespace Part4_Exc3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number from 1 to 7: ");
            int a = int.Parse(Console.ReadLine());
                        String dayName;
                        switch (a)
                        {
                            case 1:
                                dayName = "Monday";
                                Console.WriteLine($"Today is {dayName}");
                                break;
                            case 2:
                                dayName = "Tuesday";
                                Console.WriteLine($"Today is {dayName}");
                                break;
                            case 3:
                                dayName = "Wednesday";
                                Console.WriteLine($"Today is {dayName}");
                                break;
                            case 4:
                                dayName = "Thursday";
                                Console.WriteLine($"Today is {dayName}");
                                break;
                            case 5:
                                dayName = "Friday";
                                Console.WriteLine($"Today is {dayName}");
                                break;
                            case 6:
                                dayName = "Saturday";
                                Console.WriteLine($"Today is {dayName}");
                                break;
                            case 7:
                                dayName = "Sunday";
                                Console.WriteLine($"Today is {dayName}");
                                break;
                            default: dayName = "Error! please enter word 1-7";
                                Console.WriteLine(dayName);
                                break;
                        }
                    }
        }
    }