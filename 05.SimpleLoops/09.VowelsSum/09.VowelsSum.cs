using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a') sum += 1;
                if (text[i] == 'e') sum += 2;
                if (text[i] == 'i') sum += 3;
                if (text[i] == 'o') sum += 4;
                if (text[i] == 'u') sum += 5;
            }
            Console.WriteLine("Wowels sum = {0}", sum);
        }
    }
}
