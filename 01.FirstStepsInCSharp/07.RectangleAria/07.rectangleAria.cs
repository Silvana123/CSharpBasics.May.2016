using System;

class Program
{
    static void Main()
   
    {
        Console.Write("Add Rectangle's width: ");
        var a = decimal.Parse(Console.ReadLine());
        Console.Write("Add Rectangle's height: ");
        var b = decimal.Parse(Console.ReadLine());
        var area = (a * b);
        Console.WriteLine("the area of rectangles is:{0}", area);

      
    }

}

