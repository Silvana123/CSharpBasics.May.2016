using System;

class Program
{
    static void Main()
    {
        //// Print the top part
        int n = int.Parse(Console.ReadLine());
        
        Console.Write(new string('*', n * 2));
        Console.Write(new string(' ', n ));
        Console.WriteLine(new string('*', n * 2));
        ///Print the left -middle part
        for (int i = 0; i < n-2; i++)
        
        {
            
            Console.Write("*");
            Console.Write(new string ('/', (n*2)-2));
            Console.Write('*');
            if (i==(n-1)/2-1)
            {
                Console.Write(new string('|', n));
            }
            else
            {
                Console.Write(new string(' ',n));
            }
            ///Print the right-middle part
            Console.Write("*");
            Console.Write(new string('/', (n * 2) - 2));
            Console.WriteLine('*');

        }
        //// Print the bottom part
        Console.Write(new string('*', n * 2));
        Console.Write(new string(' ', n));
        Console.WriteLine(new string('*', n * 2));
    }
    
}

