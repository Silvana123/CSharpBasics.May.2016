using System;

class PrintRectangleStars

{
    static void Main()

    {
        Console.Write("Enter number :");
        var n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)

        {

            for (int j = 1; j <= n; j++)

            {

                if ((i == 1 || i == n) || (j == 1 || j == n))

                    Console.Write("*"); //prints at border place

                else

                    Console.Write(" "); //prints inside other than border

            }

            Console.WriteLine();
        }
        Console.ReadKey();

    }

}



