using System;

class Program
{
    static void Main()
    {
        var count = int.Parse(Console.ReadLine());
        var maxNumber = int.MinValue;
        for (var i = 0; i < count; i++)
        {
            var number = int.Parse(Console.ReadLine());
            if (number > maxNumber)
            {
                maxNumber = number;
            }

        }
        Console.WriteLine(maxNumber);

    }
}

