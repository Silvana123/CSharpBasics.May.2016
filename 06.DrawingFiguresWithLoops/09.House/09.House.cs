using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var stars = 1;
        if (n % 2 == 0)
        {
            stars = 2;
        }
        for (; stars <= n; stars +=2)
        {
            Console.Write(new string ('-', (n-stars)/2));
            Console.Write(new string('*', stars));
            Console.WriteLine(new string('-', (n - stars) / 2));
        }
        for (int row = 0; row < n/2; row++)
        {
            Console.WriteLine("{0}{1}{0}","|",new string('*', n-2));
        }
    }
}

