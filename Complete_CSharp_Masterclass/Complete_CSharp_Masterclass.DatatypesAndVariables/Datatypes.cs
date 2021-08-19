using System;

namespace Complete_CSharp_Masterclass.Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Declaring multiple variables at once
            int number3, number4, number5;
            
            //Declaring a variable
            int number1;
            //Assigning a value to a variable
            number1 = 13;
            
            //Declaring and initializing a variable in one go
            int number2 = 23;
            
            
            //Console.WriteLine(sum);
            //Using concatination
            Console.WriteLine("number 1 is " + number1);
            Console.WriteLine("Number 2 is " + number2);
            int sum = number1 + number2;
            Console.WriteLine("number 1:" + number1 + "+ number2: " + number2 + " is " + sum);


            double d1 = 3.1415;
            double d2 = 5.1;
            double doubleDivident = d1 / d2;
            Console.WriteLine("d1/d2 is " + doubleDivident);

            float f1 = 3.1415f;
            float f2 = 5.1f;
            float floatDiv = f1 / f2;
            Console.WriteLine("f1/f2 is " + floatDiv);


            string myName = "Christian";

            string message = "My name is " + myName;

            string capsMessage = message.ToUpper();

            string lowerCaseMessage = message.ToLower();
            
            Console.WriteLine(capsMessage);
            Console.WriteLine(lowerCaseMessage);
            
            
            Console.Read();


            
            //Implicit and Explicit conversion
            //implicit conversion 
            int num = 12390532;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;

            double myDouble = 13.37;
            int myInt;
            
            //explicit conversion
            //cast double to int
            myInt = (int) myDouble;
            
            
            //type Conversion
            string myString = myDouble.ToString();
            string myFloatString = myFloat.ToString();
            bool sunIsShining = false;

            string myBoolString = sunIsShining.ToString();
            
            Console.WriteLine(myInt);
            Console.Read();
            
            
            
            //Parsing a string to an integer
            string myNewString = "15";
            string myNewSecondString = "13";
            int num1 = Int32.Parse(myNewString);
            int num2 = Int32.Parse(myNewSecondString);
            int resultInt = num1 + num2;
            string result = myNewString + myNewSecondString;
            
            Console.WriteLine(resultInt);
            Console.Read();
            
            
            
            //String manipulation
            
            //define few variables
            int age = 24;
            string name = "Christian";
            string job = "Developer";
            
            // 1. string concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + " , i am " + age + " years old");
            
            
            // 2. string formatting
            //string formatting uses index
            Console.WriteLine("String formatting");
            Console.WriteLine("Hello my name is {0} , i am {1} years old. I'm a {2}", name , age, job);
            
            
            //3. String interpolation.
            //string interpolation uses $ at the start which will allow us to write our
            //Variables like this {variableName}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name} , I am {age} years old");
            
            //4. Verbatim strings.
            //verbatim strings start with @ and tells the compiler to take the string
            //literally and ignore any spaces and escape characters like \n
            Console.WriteLine("Verbatim strings");
            Console.WriteLine(@"uhgauuhghuhu 
            guhahughuhuahughu a,g 
            iajgjiajgjiij iajgjijaigijjaiaaogka. ajigiahjigaogka");

            
            /*
             * Now you know the use of various string functions so let’s create a small Console application to practice this.

                Declare a string variable and don’t assign any value to it.

                Print on the console “Please enter your name and press enter”. You can then enter your name or any other valid string like “tutorials.eu”.

                Assign that entered string to the string variable which you have declared initially.

                The program should write on the console that string in Uppercase in the first line, then the same string in Lowercase in the second line. In the third line, it writes on the console the string with no trailing or preceding white space like if string entered as “ tutorials.eu ” it should be written on the console as “tutorials.eu”. And in the last line, it should write the Substring of the entered string on the console.

                These kinds of features are e.g. used when creating a login screen, where the system will cut out trailing or preceding white space or, doesn’t care about the casing of the entered username.
             */
            
            //Challenge 1
            string myNewNameForChallenge;
            Console.Write("Please enter your name and press enter : ");
            myNewNameForChallenge = Console.ReadLine();
            string myNameUpperCase = String.Format("Upper case : {0}", myNewNameForChallenge.ToUpper());
            string myNameLowerCase = String.Format("Lower case : {0}", myNewNameForChallenge.ToLower());
            string myNameTrimmed = String.Format("Trimmed value : {0}", myNewNameForChallenge.Trim());
            string myNameSubString = String.Format("Substring value : {0}", myNewNameForChallenge.Substring(0,5));
            Console.WriteLine(myNameUpperCase);
            Console.WriteLine(myNameLowerCase);
            Console.WriteLine(myNameTrimmed);
            Console.WriteLine(myNameSubString);
            
            
            
            
            /*
             * Let’s create another console application for more practice.

                This application asks the user to input a string in the first line like “Enter a string here: ”.

                In the Second Line, it should ask for the character to search in the string which you have entered in the first line like “Enter the character to search: ”

                On the third line, it should write the index of the first occurrence of the searched character from the string.

                Now on concatenation...

                It should then ask to enter the first name and once the name is written and the enter button is pressed, it should ask to enter the last name.

                It should then show your full name printed in a single line like in my case the output will be "Christian Hussmann". Output can be different in your case. Try to store the full name in a variable, before displaying it.
             */
            
            //Challenge 2
            Console.Write("Enter the string here: ");
            //Read first input string.
            string input = Console.ReadLine();
            
            Console.Write("Enter a character to search: ");
            //Read the character input to search.
            char searchInput = Console.ReadLine()[0];
            //Gets the Index of the character from the string.
            int searchIndex = input.IndexOf(searchInput);
            //Prints the index as a search result on console.
            Console.WriteLine("Index of character {0} in string is {1}", searchInput, searchIndex);
            
            Console.Write("Enter first name: ");
            //Read the first name
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            //Read the last name
            string lastName = Console.ReadLine();
            
            //Concatinate the firstName and lastName variable and assign that to fullName variable.
            string fullName = string.Concat(firstName, " ", lastName);
            //Prints the full name on the console.
            Console.WriteLine("Your first name is {0}", fullName);

            Console.ReadKey();

            
            //Challenge - Datatypes and Variables
            /*Now that you know how to declare and initialize Variables, please go ahead and create a variable for each of the primitive datatypes (you can find the list here). Leave the Object datatype out.
                And also please initialize each variable with a working value.
                Then create two values of type string. 
                The first one should say "I control text"

                The second one should be a whole number. Then use the Parse method in order to convert that string to an integer.

                Add each an output for each of the variables and write it onto the console. (WriteLine)
                Feel free to name your variables as you like, but keep in mind, that my result's variable names will differ to yours.
             */
            
            byte myByte = 25;
            Console.WriteLine(myByte);
            sbyte mySbyte = -15;
            Console.WriteLine(mySbyte);
            int myNewInt = -12318925;
            Console.WriteLine(myInt);
            uint myUint = 123091;
            Console.WriteLine(myUint);
            short myShort = -32768;
            Console.WriteLine(myShort);
            ushort myUShort = 65535;
            Console.WriteLine(myUShort);
            float myNewFloat = -31.1289f;
            Console.WriteLine(myFloat);
            double myNewDoubleForChallenge = -12.1231250;
            Console.WriteLine(myDouble);
            char myCharacter = 'A';
            Console.WriteLine(myCharacter);
            bool myBool = true;
            Console.WriteLine(myBool);
            string myText = "I control text";
            Console.WriteLine(myText);
            string numText = "15";

            int myNumFromText = int.Parse(numText);
            Console.WriteLine(myNumFromText);
            Console.ReadLine();
            
            
            
           //Constants are immutable values which are known
           //at compile time and do not change for the life of the program.
           
           //Constants as fields
           const double PI = 3.14159265359;
           const int weeks = 52, months = 12;
           //Create a constant of type string with your birthday as its value
           const string birthday = "20.05.1997";

           Console.WriteLine("My Birthday is always going to be: {0}", birthday);
           Console.ReadKey();
           
           
           
           //C# cheatsheets can be found here
           //https://cheatography.com/laurence/cheat-sheets/c/
           //https://www.thecodingguys.net/resources/cs-cheat-sheet.pdf
        }
    }
}