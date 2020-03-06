using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var exit = true;

            while (exit)
            {
                Console.WriteLine("wprowadz esc aby wyjsc");

                var input = Console.ReadKey();

                Console.WriteLine("zly klawisz"  + input.KeyChar);

                Console.WriteLine($"ssdasds{input.KeyChar}ad");
                


            }
        }
    }
}
