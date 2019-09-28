using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.String greeting = "Hello";   // string greeting
            System.Int32 wholeNumber = 4;       // int wholeNumber
            System.Double pi = 3.1415;          // double pi
            System.Boolean status = true;       // bool status
            System.Char letter = 'z';           // char letter

            System.Console.WriteLine(greeting.GetType());
            System.Console.WriteLine(wholeNumber.GetType());
            System.Console.WriteLine(pi.GetType());
            System.Console.WriteLine(status.GetType());
            System.Console.WriteLine(letter.GetType());
        }
    }
}
