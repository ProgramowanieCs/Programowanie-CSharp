using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            int number2 = 6;

            //If - else if - else
            if (number > 10 && number2 < 6)
            {
                //Jeżeli warunki z powyższego if'a zostaną spełnione to kod wewnątrz nawiasów się wykona
            }
            else if (number == 11)
            {
                //Jeżeli nasz pierwszy if nie będzie miał spełnionych warunków sprawdzamy kolejno następne if / else
            }
            else if (number2 == 6)
            {

            }
            else
            {
                //Kod z 'else' wykona się zawsze jeżeli poprzednie 'if' oraz 'if - else' nie zostaną wykonane
            }

            //Switch - case

            //W zależności od tego jakiego typu dajemy mu zmienną do nawiasów, takie instrukcje 'case' będziemy mogli napisać
            //Instrukcje 'case' działają jak 'if'. Jeżeli np. number będzie równy 10 to nasz case się wykona.
            //Default działa jak 'else'. Jeżeli nic z powyższych 'case' się nie wykona to jeżeli mamy 'default' kod z niego zawsze się wykona.
            switch (number)
            {
                case 10:

                    Console.WriteLine("Liczba wynosi 10");
                    break;
                case 20:

                    Console.WriteLine("Liczba wynosi 20");
                    break;
                case 30:

                    Console.WriteLine("Liczba wynosi 30");
                    break;
                default:

                    Console.WriteLine("Tu wykona się kod który nie wpadł do żadnego warunku 'case' ");
                    break;
            }
        }
    }
}
