using System;

namespace IntroToTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberAsString = "128";
            float parsedValue;

            bool success = float.TryParse(numberAsString, out parsedValue);
            
            if(success)
                Console.WriteLine("Parsing successfull - number is " + parsedValue);
            else
            {
                Console.WriteLine("Parsing failed");
            }
        }
    }
}