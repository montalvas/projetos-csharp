using System;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            short option;

            Console.Clear();
            Console.WriteLine("Select an option:");
            Console.WriteLine("1 - Addiction");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Integer Division");
            Console.WriteLine("6 - Module");
            Console.WriteLine("7 - Exponentiation");
            Console.WriteLine("8 - Square Root");
            Console.WriteLine("9 - Quit");
            Console.WriteLine("------------------");

            Console.Write("Option: ");
            short.TryParse(Console.ReadLine(), out option);

            StartOperation(option);
        }

        static void StartOperation(short option)
        {
            switch(option)
            {
                case 1: 
                    Addition();
                    break;
                case 2:
                    Subtraction();
                    break;
                case 3:
                    Multiplication();
                    break;
                case 4:
                    Division();
                    break;
                case 5:
                    IntegerDivision();
                    break;
                case 6:
                    Module();
                    break;
                case 7:
                    Exponentiation();
                    break;
                case 8:
                    SquareRoot();
                    break;
                case 9:
                    ExitProgram();
                    break;
                default:
                    Menu();
                    break;
            }
        }

        static void Addition()
        {
            float value1, value2, result;

            Console.Clear();
            Console.Write("First value: ");
            float.TryParse(Console.ReadLine(), out value1);

            Console.Write("Second value: ");
            float.TryParse(Console.ReadLine(), out value2);

            result = value1 + value2;

            Console.WriteLine($"The result of sum is {result}");

            Console.ReadKey();
            Menu();
        }

        static void Subtraction()
        {
            float value1, value2, result;

            Console.Clear();
            Console.Write("First value: ");
            float.TryParse(Console.ReadLine(), out value1);

            Console.Write("Second value: ");
            float.TryParse(Console.ReadLine(), out value2);

            result = value1 - value2;

            Console.WriteLine($"The result of subtraction is {result}");

            Console.ReadKey();
            Menu();
        }

        static void Multiplication()
        {
            float value1, value2, result;

            Console.Clear();
            Console.Write("First value: ");
            float.TryParse(Console.ReadLine(), out value1);

            Console.Write("Second value: ");
            float.TryParse(Console.ReadLine(), out value2);

            result = value1 * value2;

            Console.WriteLine($"The result of multiplication is {result}");

            Console.ReadKey();
            Menu();
        }

        static void Division()
        {
            float value1, value2, result;

            Console.Clear();
            Console.Write("First value: ");
            float.TryParse(Console.ReadLine(), out value1);

            Console.Write("Second value: ");
            float.TryParse(Console.ReadLine(), out value2);

            result = value1 / value2;
            Console.WriteLine($"The result of division is {result}");

            Console.ReadKey();
            Menu();
        }

        static void IntegerDivision()
        {
            float value1, value2;

            Console.Clear();
            Console.Write("First number: ");
            float.TryParse(Console.ReadLine(), out value1);

            Console.Write("Second number: ");
            float.TryParse(Console.ReadLine(), out value2);

            int result = (int)(value1 / value2);
            Console.WriteLine($"The result of integer division is {result}");

            Console.ReadKey();
            Menu();
        }

        static void Module()
        {
            float value1, value2, result;

            Console.Write("First value: ");
            float.TryParse(Console.ReadLine(), out value1);

            Console.Write("Second value: ");
            float.TryParse(Console.ReadLine(), out value2);

            result = value1 % value2;
            Console.WriteLine($"The result of module is {result}");

            Console.ReadKey();
            Menu();
        }

        static void Exponentiation()
        {
            double value1, value2, result;

            Console.Write("Base: ");
            double.TryParse(Console.ReadLine(), out value1);

            Console.Write("Exponent: ");
            double.TryParse(Console.ReadLine(), out value2);

            result = Math.Pow(value1, value2);
            Console.WriteLine($"The result of exponentiation is {result}");

            Console.ReadKey();
            Menu();
        }

        static void SquareRoot()
        {
            double value, result;

            Console.Write("Number: ");
            Double.TryParse(Console.ReadLine(), out value);

            result = Math.Sqrt(value);
            Console.WriteLine($"The result of square root is {result}");

            Console.ReadKey();
            Menu();
        }

        static void ExitProgram()
        {
            Console.WriteLine("Thanks for using, bye!");
            System.Environment.Exit(0);
        }
    }
}
