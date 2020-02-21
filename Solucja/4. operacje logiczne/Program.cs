using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Operacje_logiczne
{
    class Program
    {
        static void Main(string[] args)
        {

            int randomNumber = 0;
            Random random = new Random();

            randomNumber = random.Next(0, 100);

            var exit = true;
            
            while(exit)
            {
                Console.WriteLine("Podaj liczbę od 0 do 100");
                var input = Console.ReadLine();

                var number = 0;
                var result = int.TryParse(input, out number);

                if (result)
                {
                    if (number >= 0 && number <= 100)
                    {
                        if (number < randomNumber)
                        {
                            Console.WriteLine("Twoja liczba jest mniejsza od wylosowanej");
                        }

                        if (number > randomNumber)
                        {
                            Console.WriteLine("Twoja liczba jest większa od wylosowanej");
                        }

                        if (number == randomNumber)
                        {
                            Console.WriteLine("Twoja liczba równa co wyloswana");
                            exit = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wpisałeś liczbę z poza zakresu od 0 do 100");
                    }
                }
                else
                {
                    Console.WriteLine("Nie wpisaleś liczby");
                }

            }

            Console.ReadLine();
        }
    }
}
