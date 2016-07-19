using System;

class Program
{
    static void Main(string[] args)
    {
        for (var number = 0; number <= 1000; number++)
        {
            if (number % 10 == 7)
            {
                Console.WriteLine(number);
            }
        }

    }
}

