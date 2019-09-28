using System;

class Program
{
    static void Main(string[] args)
    {
        Random generator = new Random();
        double randomNumber = generator.NextDouble();
        double roundedNumber = Math.Round(randomNumber, 1);
        
        Console.WriteLine(roundedNumber);
    }
}

