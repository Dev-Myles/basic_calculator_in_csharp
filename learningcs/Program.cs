using System;

    public class Program
{
    public static void Main(string[] args)
    {
        Console.ForegroundColor= ConsoleColor.Yellow;
        Console.WriteLine("Basic Calculator - Exit with CTRL + C");
        while (true)
        {
            Functions.Math.Calculate(
                Functions.Math.GetOperator(),
                Functions.Math.GetFirstNumber(),
                Functions.Math.GetSecondNumber()
                );

        }

    }

  
}

namespace Functions
{

    public class Math
    {

       public enum Operators
        {
           divide,
           multiply,
           add, 
            subtract
        }

    
        public static string GetOperator()
        {
            Console.ForegroundColor= ConsoleColor.DarkBlue;
            Console.WriteLine("Please enter divide, multiply, add, or subtract");
            Console.ForegroundColor= ConsoleColor.White;
            string? input;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Please enter a valid operator");
                Console.ForegroundColor = ConsoleColor.White;
                input = Console.ReadLine();

            } while (!Enum.IsDefined(typeof(Operators), input) | input == null);

            return input;

        }

        public static float GetSecondNumber()
        {
            Console.WriteLine("Second number:");
            string? x;

            do
            {
                Console.WriteLine("Please enter a valid integer");
                x = Console.ReadLine();
            } while (float.TryParse(x, out _) != true);

                   return float.Parse(x);
        }

        public static float GetFirstNumber()
        {
            Console.WriteLine("First number:");
            string? x;
            do
            {
                Console.WriteLine("Please enter a valid integer");
                x = Console.ReadLine();
            } while (float.TryParse(x, out _) != true);

            return float.Parse(x);
        }

        public static void Calculate(string op, float x, float y)
        {
                switch (op)
                {
                    case "divide":
                        {
                            if(y == 0)
                        {
                            Console.ForegroundColor= ConsoleColor.DarkRed;
                            Console.WriteLine("You cannot divide by zero, please enter a valid number");
                            return;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                       ;  
                            Console.WriteLine($"Anwser: {x / y}");
                            return;
                        }

                           

                        }
                    case "add":
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{x + y}");
                            return;

                        }
                    case "multiply":
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{x * y}");
                            return;

                        }
                    case "subtract":
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"{x - y}");
                            return;
                        }
                    default:
                        {
                            return;
                        }
                }
            }


        }
        
    }

  
