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

            Console.WriteLine("1. Wybierz jeden, aby pomnożyć\n2.Wybierz dwa, aby podzielić\n3.Wybierz trzy, aby dodać\n4.Wybierz cztery, aby odjąć");
            
            //Pętla dopuki nie zostanie odwołana
            while (true)
            {
                //Odczytanie liczby dostarczonej przez użytkownika
                var input = Console.ReadLine();

                int option;
                var inputParseResult = int.TryParse(input, out option);

                if (input.ToUpper() == "ESC")
                {
                    Environment.Exit(0);
                }

                if (inputParseResult)
                {
                    if (option > 0 && option <= 4)
                    {
                        //Jezeli odpowiedzą nie była liczba lecz "ESC" - wyjdz z programu

                        //Odczytaj dwie liczby potrzebne do wykonania działania

                        var numberResult1 = false;
                        float number1 = 0;

                        while (!numberResult1)
                        {
                            Console.WriteLine("Numer 1:");

                            var numberInput1 = Console.ReadLine();
                            numberResult1 = float.TryParse(numberInput1, out number1);

                            if (numberResult1 == false)
                            {
                                Console.WriteLine("Musisz podać liczbę. Spróbuj ponownie.");
                            }
                        }

                        var numberResult2 = false;
                        float number2 = 0;

                        while (!numberResult2)
                        {
                            Console.WriteLine("Numer 2:");

                            var numberInput2 = Console.ReadLine();
                            numberResult2 = float.TryParse(numberInput2, out number2);

                            if (numberResult1 == false)
                            {
                                Console.WriteLine("Musisz podać liczbę. Spróbuj ponownie.");
                            }
                        }

                        float wynik = 0;

                        //Porównaj odpowiedx użytkownika z możliwymi odpowiedziami
                        switch (option)
                        {
                            //Przyklad (Jezeli option == 1)
                            case 1:
                                //Odwołaj się do metody napisanej poniżej
                                wynik = Mnozenie(number1, number2);
                                break;
                            case 2:
                                wynik = Dzielenie(number1, number2);
                                break;
                            case 3:
                                wynik = Dodawanie(number1, number2);
                                break;
                            case 4:
                                wynik = Odejmowanie(number1, number2);
                                break;
                        }

                        Console.WriteLine("Twoj wynik to:" + wynik.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Liczba musi być z przedziału od 1-4.");
                    }
                }
                else
                {
                    Console.WriteLine("Nie wpisałeś liczby. Musisz podać liczbę, z przedziału 1-4.");
                }
            }
        }

        //Metoda Mnozenia (zbierz numer1 i numer2 w typie float)
        static float Mnozenie(float numer1, float numer2)
        {
            //Wyswietl wynik numer1 * numer2
            return numer1 * numer2;
        }

        static float Dzielenie(float numer1, float numer2)
        {
            return numer1 / numer2;
        }

        static float Dodawanie(float numer1, float numer2)
        {
            return numer1 + numer2;
        }

        static float Odejmowanie(float numer1, float numer2)
        {
            return numer1 - numer2;
        }
    }
}
