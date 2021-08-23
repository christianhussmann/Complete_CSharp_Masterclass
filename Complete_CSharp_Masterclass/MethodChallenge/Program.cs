using System;

namespace MethodChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //MethodChallenge
            /*In this challenge you will deepen your understanding for methods.
            Please go ahead and create three variables with names of your friends.
            Then create a Method "GreetFriend" which writes something like: "Hi Frank, my friend!" 
            onto the console, once it is called.
            Where "Frank" should be replaced with the Name behind the argument given to the Method when it's called. 
            So the method will need a parameter (decide which DataType will be best). 

            Greet all your three friends.
                */
            
            string friend1 = "Julian";
            string friend2 = "Mads";
            string friend3 = "Christian";
            
            //First way to solve the challenge
            //GreetFriend(friend1);
            //GreetFriend(friend2);
            //GreetFriend(friend3);

            //Console.Read();
            
            //Alternative way to solve it
            GreetFriend(friend1, friend2, friend3);
            Console.Read();
        }


        public static void GreetFriend(string friendName1, string friendName2, string friendName3)
        {
            Console.WriteLine("Hi " + friendName1 + " , my friend!");
            Console.WriteLine("Hi " + friendName2 + " , my friend!");
            Console.WriteLine("Hi " + friendName3 + " , my friend!");
        }
        
        
    }
}