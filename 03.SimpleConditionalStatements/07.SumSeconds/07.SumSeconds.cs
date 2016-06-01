using System;

class Program
{
    static void Main()
    {
        int firstPlayer = int.Parse(Console.ReadLine());
        int secondPlayer = int.Parse(Console.ReadLine());
        int thirdPlayer = int.Parse(Console.ReadLine());
        int secondSum = firstPlayer + secondPlayer + thirdPlayer;

        if (secondSum < 60)
        {
            Console.WriteLine("0:{0:D2}", secondSum);
        }
        else if (secondSum < 120)
        {
            secondSum = secondSum - 60;
            Console.WriteLine("1:{0:D2}",secondSum);
        }
        else  
        {
            secondSum = secondSum - 120;
            Console.WriteLine("2:{0:D2}",secondSum);
        }

    }
}


