using System;

namespace ReturnValueAndParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divide(101,25));
            Console.Read();
        }

        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public static double Divide(double number1, double number2)
        {
            return number1 / number2;
        }
    }
}