using System;

namespace FunctionsAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("I am an argument and am called from a method");
            Console.Read();
        }

        //access modifier (static) return type method name(parameter1, parameter 2)
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
            Console.Read();
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
            
        }
    }
}