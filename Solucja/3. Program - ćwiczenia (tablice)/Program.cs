using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Program___ćwiczenia__tablice_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = new int[10];
            
            Console.WriteLine("Wprowadź 10 liczb: ");

            Random random = new Random();
            random.Next(0, 10000);

            for (int i = 0; i < 10; i++)
            {
                bool result = true;

                while (result)
                {
                    Console.WriteLine("Wprowadź liczbę nr. " + (i + 1));
                    var input = Console.ReadLine();

                    var number = 0;
                    result = !int.TryParse(input, out number);

                    if (result == false)
                    {
                        numbersArray[i] = Convert.ToInt32(number);
                    }
                    else
                    {
                        Console.WriteLine("BŁĄD! Podaj liczbę jeszcze raz!");
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Miejsce " + i + " w tablicy ma wartość: " + numbersArray[i]);
            }

            Console.ReadKey();
        }
    }
}
