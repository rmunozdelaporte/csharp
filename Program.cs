using System;
using System.Threading;

class Program
{
    static void MyMethod()
    {
        int total = 0;
        Console.WriteLine("Waiting...");       
        Console.WriteLine(total);
    }

    static void Main(string[] args)
    {
        int total = 0;
        total += 10;
        MyMethod();
        Console.WriteLine("Total in Main: ");
        Console.WriteLine(total);
    }
}

