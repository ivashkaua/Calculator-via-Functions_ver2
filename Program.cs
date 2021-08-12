using System;

namespace _04_Calculator_via_Functions
{
    class Program
    {
        static void Calculator()
        {

            Console.WriteLine("Hello!");
            Console.WriteLine("Book value \"a\"");
            double value_a = ReadLine();
            Console.WriteLine("Book value \"b\"");
            double value_b = ReadLine();
            Console.WriteLine("Number of decimal places");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Book operator +, -, * or /");
            string _operator = Console.ReadLine();

            /*
            double final_result;
            if (_operator == "+")
            final_result = Sum(value_a, value_b, r);
            if (_operator == "-")
            final_result = Diff(value_a, value_b, r);
            if (_operator == "*")
            final_result = Multiplication(value_a, value_b, r);
            if (_operator == "/")
            final_result = Division(value_a, value_b, r);
            Console.WriteLine(final_result); - вот здесь выдает ошибку, что значение "final_result" не присвоено;
            */

            switch (_operator)
            {
                case "+":
                    Console.WriteLine(Sum(value_a, value_b, r));
                    break;
                case "-":
                    Console.WriteLine(Diff(value_a, value_b, r));
                    break;
                case "*":
                    Console.WriteLine(Multiplication(value_a, value_b, r));
                    break;
                case "/":
                    Console.WriteLine(Division(value_a, value_b, r));
                    break;
                default:
                    Console.WriteLine("You entered an unknown operator");
                    break;
            }

            Console.ReadLine();
            Console.Clear();
        }

        static double Sum(double a, double b, int r)
        {
            return Math.Round(a + b, r);
            //return result;
        }

        static double Diff(double a, double b, int r)
        {
            return Math.Round(a - b, r);
            //Console.WriteLine("Your result is " + result);
            //return result;
        }

        static double Multiplication(double a, double b, int r)
        {
            return Math.Round(a * b, r);
            //Console.WriteLine("Your result is " + result);
            //return result;
        }

        static double Division(double a, double b, int r)
        {
            return Math.Round(a / b, r);
            //Console.WriteLine("Your result is " + result);
            //return result;
        }

        static double ReadLine()
        {
            return double.Parse(Console.ReadLine());
            //return booking;

        }
        static void Main(string[] args)
        {
            while (true)
                Calculator();
        }
    }
}
