using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter score: ");
        int num = int.Parse(Console.ReadLine());
        double bonusScore = 0.0;
        if (num > 1000)
        {
                bonusScore = num * 0.10;
                
        }
                 
        else if (num > 100)           
        {
                bonusScore = num * 0.20;
                
        }
        else   
        {
            bonusScore = 5;
        }
        if (num % 2 == 0)
        {
            bonusScore = bonusScore + 1;
        }
        if (num % 10 == 5) 
        {
            bonusScore = bonusScore + 2;
        }
        Console.WriteLine("Bonus score: {0}", bonusScore);
        Console.WriteLine("Total score: {0}", num + bonusScore);

    }
}
