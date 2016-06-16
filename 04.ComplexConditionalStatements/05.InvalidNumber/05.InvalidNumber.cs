using System;


namespace _05.InvalidNumber
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            var isValid  = (num >= 100 && num <= 200) || num == 0;

            if (!isValid)
            {
                Console.WriteLine("invalid");
            }
               
        }
    }
}
