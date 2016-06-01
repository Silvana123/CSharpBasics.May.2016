using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two integers:");
        var firstInteger = double.Parse(Console.ReadLine());
        var secondInteger = double.Parse(Console.ReadLine());
        if (firstInteger >= secondInteger)
        {
            Console.WriteLine(firstInteger);
        }
        else
        {
            Console.WriteLine(secondInteger);
        }
    }
}

