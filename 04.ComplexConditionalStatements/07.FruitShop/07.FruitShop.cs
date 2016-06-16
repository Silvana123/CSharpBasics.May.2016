using System;

class Program
{
    static void Main()
    {
        var fruit = Console.ReadLine().ToLower();
        var date = Console.ReadLine().ToLower();
        var quantity = double.Parse(Console.ReadLine());

        if (date == "monday" || date == "tuesday" || date == "wednesday" || date == "thursday" || date == "friday")
        {
            if (fruit == "banana")

            { Console.WriteLine(quantity * 2.5); }

            else if (fruit == "apple")

            { Console.WriteLine(quantity * 1.2); }


            else if (fruit == "orange")

            { Console.WriteLine(quantity * 0.85); }

            else if (fruit == "grapefruit")

            { Console.WriteLine(quantity * 1.45); }


            else if (fruit == "kiwi")

            { Console.WriteLine(quantity * 2.7); }

            else if (fruit == "pineapple")

            { Console.WriteLine(quantity * 5.5); }


            else if (fruit == "grapes")

            { Console.WriteLine(quantity * 3.85); }
        }

        else if (date == "saturday" || date == "sunday")
        {
            if (fruit == "banana")

            { Console.WriteLine(quantity * 2.7); }

            else if (fruit == "apple")

            { Console.WriteLine(quantity * 1.25); }


            else if (fruit == "orange")

            { Console.WriteLine(quantity * 0.90); }

            else if (fruit == "grapefruit")

            { Console.WriteLine(quantity * 1.60); }


            else if (fruit == "kiwi")

            { Console.WriteLine(quantity * 3.00); }

            else if (fruit == "pineapple")

            { Console.WriteLine(quantity * 5.60); }


            else if (fruit == "grapes")

            { Console.WriteLine(quantity * 4.20); }

        }

        else
        { Console.WriteLine("error"); }


    }
}
    
