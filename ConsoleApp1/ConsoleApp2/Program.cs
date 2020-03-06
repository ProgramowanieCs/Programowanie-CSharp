using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var number = 0;

            var blad = int.TryParse(input, out number);

            if (!blad)
            {
                Console.WriteLine("podałeś literę");
            }
            else
            {
                for (int i = 0; i < number; i++)
                {
                    var wynik = i + 1;
                    Console.WriteLine("obecna liczba to: " + wynik);

                }

                Console.WriteLine("Tu sie dzieje dobrze");
            }


            Console.ReadLine();
        }
        
    }
}
