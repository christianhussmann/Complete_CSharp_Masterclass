using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate());
            Console.Read();
        }

        public static int Calculate()
        {
            Console.WriteLine("Please enter the first number");
            string number1Input = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string number2Input = Console.ReadLine();
            
            int number1 = int.Parse(number1Input);
            int number2 = int.Parse(number2Input);
            
            int result = number1 + number2;
            
            
            return result;
        }
    }
}