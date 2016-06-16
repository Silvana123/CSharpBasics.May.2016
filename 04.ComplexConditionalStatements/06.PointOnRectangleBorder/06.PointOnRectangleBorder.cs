using System;

class Program
{
    static void Main()
    {
       
            double x1= double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            var isOnTop = y == y1 && (x >= x1 && x <= x2);
            var isOnBotom = y == y2 && (x >= x1 && x <= x2);
            var isOnLeft = x == x1 && (y >= y1 && y <= y2);
            var isOnRight = x == x2 && (y >= y1 && y <= y2);


            if (isOnTop || isOnBotom || isOnLeft || isOnRight)
            {
                Console.WriteLine("Border");
            }
   
            else 
            {
                Console.WriteLine("Inside / Outside");
            }
            
        }
    }




