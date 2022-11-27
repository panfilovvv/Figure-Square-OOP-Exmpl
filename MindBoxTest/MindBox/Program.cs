using System;
using Figures;

namespace MindBox
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string Command;
                do
                {
                    Console.WriteLine("Type T to create Triangle, C to create Circle.");
                    Command = Console.ReadLine().ToUpper();
                    double a = 0;
                    double b = 0;
                    double c = 0;
                    switch (Command)
                    {
                        case "T":
                            Console.WriteLine("Write 3 triangle's sides' length here: ");
                            a = double.Parse(Console.ReadLine());
                            b = double.Parse(Console.ReadLine());
                            c = double.Parse(Console.ReadLine());
                            Triangle T = new Triangle(a, b, c);
                            Console.WriteLine($"You've created a Triagle. Perimeter = {Math.Round(T.Perimeter, 3)}, Square = {Math.Round(T.Square)}");
                            if (T.IsRight())
                            {
                                Console.WriteLine("This Triangle is right");
                            }
                            else
                            {
                                Console.WriteLine("This Triangle is NOT right");
                            }
                            break;
                        case "C":
                            Console.WriteLine("Write circle's radius here: ");
                            a = double.Parse(Console.ReadLine());
                            Circle C = new Circle(a);
                            Console.WriteLine($"You've created a Cirle. Perimeter = {Math.Round(C.Perimeter, 3)}, Square = {Math.Round(C.Square, 3)}");
                            break;
                        default:
                            Console.WriteLine("Wrong input!");
                            break;
                    }
                }
                while (Convert.ToInt32(Command) != 13);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
