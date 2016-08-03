using System;

class Program
{
    private static int i;

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //Top part
        for (int row = 1; row <= n; row++)
        {
            
            for (int spaceCol = 1; spaceCol  <= n - row; spaceCol ++)
            {
                Console.Write(" ");
            }
            for (int col = 1; col < row ; col++)
            {
            Console.Write("* ");
            }
            Console.WriteLine("*");
                   
        }
        //Bottom part
        for (int row = n - 1; row >= 1; row--)
        {

            for (int spaceCol = 1; spaceCol <= n - row; spaceCol++)
            {
                Console.Write(" ");
            }
            for (int col = 1; col < row; col++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("*");

        }
    }
}

