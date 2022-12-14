using System;

    public class Program
{
    public static void Main(string[] args)
    {
        Console.ForegroundColor= ConsoleColor.Yellow;
        Console.WriteLine("Basic Calculator - Exit with CTRL + C");
        while (true)
        {
            Functions.Math.GetOperator();

        }

    }

  
}

namespace Functions
{
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;

    public class Math
    {

       public enum Operators
        {
           divide,
           multiply,
           add, 
            subtract
        }

    
        public static void GetOperator()
        {
            Console.ForegroundColor= ConsoleColor.DarkBlue;
            Console.WriteLine("Please enter divide, multiply, add, or subtract");
            Console.ForegroundColor= ConsoleColor.White;
           string? input = Console.ReadLine();

            ArgumentNullException.ThrowIfNull(input);

            if (!Enum.IsDefined(typeof(Operators), input))
            {
                Console.ForegroundColor= ConsoleColor.DarkRed;
                Console.WriteLine("Please enter a valid string");
               
                return;
            }
            else
            {
                Calculate(input);
                
            }

        }
        public static void Calculate(string op)
        {
            bool end = true;
            int x;
            int y;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Choose two numbers");
            while (end)
            {
                string z = Console.ReadLine();
                if (!int.TryParse(z, out x))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Please enter a valid integer");
                    break;
                }
                else
                {
                    x = Convert.ToInt32(z);
                }

                string a = Console.ReadLine();
                if (!int.TryParse(a, out y))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Please enter a valid integer");
                    break;
                }
                else
                {
                    y = Convert.ToInt32(a);
                }






                switch (op)
                {
                    case "divide":
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine($"{x / y}");
                            return;

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

  
}
