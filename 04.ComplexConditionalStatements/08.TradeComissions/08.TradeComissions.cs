using System;

class Program
{
    static void Main(string[] args)
    {
        string town = Console.ReadLine().ToLower();
        double sales = double.Parse(Console.ReadLine());
        var comission = -1.0;

        if (town == "Sofia")
        {
            if (0 <= sales && sales <= 500) comission = 0.05;
            else if (500 < sales && sales <= 1000) comission = 0.07;
            else if (1000 < sales && sales <= 10000) comission = 0.08;
            else if (sales > 10000) comission = 0.12;
        }
        else if (town == "Varna")
        {
            if (0 <= sales && sales <= 500) comission = 0.045;
            else if (500 < sales && sales <= 1000) comission = 0.075;
            else if (1000 < sales && sales <= 10000) comission = 0.10;
            else if (sales > 10000) comission = 0.13;
        }
        else if (town == "plovdiv")
        {
            if (0 <= sales && sales <= 500) comission = 0.055;
            else if (500 < sales && sales <= 1000) comission = 0.08;
            else if (1000 < sales && sales <= 10000) comission = 0.12;
            else if (sales > 10000) comission = 0.145;
        }
        if (comission >= 0)

            Console.WriteLine("{0:f2}", sales * comission);
        
            
        else Console.WriteLine("error");

    }
}

