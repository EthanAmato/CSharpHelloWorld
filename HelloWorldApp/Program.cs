using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("This doesn't have a \\n on the end of it |");
            Console.WriteLine("Hello World!");
            // Write comments like javascript

            //Type safety similar to Java
            byte x = 123;
            int y = 1234567;
            ulong z = 123456781231234;
            int myNum = 5;               // Integer (whole number)
            double myDoubleNum = 5.99D;  // Floating point number
            char myLetter = 'D';         // Character
            bool myBool = true;          // Boolean
            string myText = "Hello";     // String


            //Can declare variables without assigning
            ulong xyz;
            xyz = (ulong)x + (ulong)y + z; //casting example
            Console.WriteLine(xyz);
            Console.WriteLine(Convert.ToChar("A")); //string to char
                                                    // Type your username and press enter
            Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Your age is: " + age); //can apparently concatenate int and string and not get error

            //Operators
            x = 1 + 2 - 5 * 20 / 100 % 2;
            x++;
            x--;

            //& Operator
            int boolOperator = -100;
            boolOperator &= 3; //if greater than 0 it is 1 (true), else it's false
            Console.WriteLine(boolOperator);

            //

        }
    }
}