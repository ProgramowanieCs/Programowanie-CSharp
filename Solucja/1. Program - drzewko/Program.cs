using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Program___drzewko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proszę wprowadzić liczbę od 1 - 10: ");
            var input = Convert.ToInt32(Console.ReadLine());

            var starNumber = 1;

            for (int i = 0; i < input; i++)
            {
                var spaceNumber = input - 1 - i;

                var resultSpaces = new String(' ', spaceNumber);
                var resultStars = new String('*', starNumber);

                starNumber = starNumber + 2;

                Console.WriteLine(resultSpaces + resultStars);
            }

            Console.ReadKey();
        }
    }
}
