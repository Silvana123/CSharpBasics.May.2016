using System;

class IncheToCentimeters
{
    static void Main()
    {
        Console.Write("Inche = ");
        var inche = double.Parse(Console.ReadLine());
        var centimeters = inche * 2.54;
        Console.Write("Centimeters = ");
        Console.WriteLine(centimeters);
    }
}

