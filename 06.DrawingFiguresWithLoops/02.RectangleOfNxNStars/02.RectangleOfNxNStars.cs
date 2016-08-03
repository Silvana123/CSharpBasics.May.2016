using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (var i = 1; i <= n; i++)
        {
            Console.WriteLine(
                new string('*', n));
        }


    }
}


