using System;

namespace _5._17._21
{
    class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car("BMW", "M5", 50, 80, 15);
            string input;
            do
            {
                Console.WriteLine("please select number");
                Console.WriteLine("1.Go");
                Console.WriteLine("2.Top Up");
                Console.WriteLine("2.Top Up");

                Console.WriteLine("3.Stop");
                Console.WriteLine("4.Exit");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        car1.Go();
                        break;
                    case "2":
                        car1.TopUp();
                        break;
                    case "3":
                        Console.WriteLine("Stop");
                        break;
                    case "4":
                        Console.WriteLine("Yaxsi yol");
                        break;

                    default:
                        Console.WriteLine("Please selecet number from 1 to 4");
                        break;
                }
            } while (input !="4");



        }
    }
    
}
