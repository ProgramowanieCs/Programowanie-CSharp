using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Program___ćwiczenia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz ciąg znaków");
            var input = Console.ReadLine();

            if (input.Length >= 2)
            {
                Console.WriteLine(input);
            }
            else
            {
                var count = 4;
                var wynik = "";

                for (int i = 0; i < count; i++)
                {
                    wynik = wynik + input;
                }

                Console.WriteLine(wynik);
            }
        }
    }
}
