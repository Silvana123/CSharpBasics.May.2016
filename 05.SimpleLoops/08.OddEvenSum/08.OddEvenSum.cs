using System;

class Program
{
    static void Main()
    {
        var count = int.Parse(Console.ReadLine());
        var oddSum = 0;
        var evenSum = 0;


        for (int i = 0; i < count; i++)
        {
            var number = int.Parse(Console.ReadLine());
            if (i % 2 == 0) 

            {
                evenSum += number;
            }
            else
            {
                oddSum += number;
            }
        }
            
        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Sum ={0} ", oddSum);
        }

        else
        {
            Console.WriteLine("No");
            Console.WriteLine("Diff = {0} ", Math.Abs(oddSum - evenSum));
        }
        
    
            

    }
}

