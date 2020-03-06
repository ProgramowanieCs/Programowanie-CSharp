using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Operacje_logiczne_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var zmienna1 = false;
            var zmienna2 = false;
            var zmienna3 = true;
            var zmienna4 = true;

            if (zmienna1 && zmienna2)
            {

            }

            if (zmienna1 || zmienna2)
            {

            }

            if (!zmienna1)
            {

            }

            if (zmienna1 || (zmienna2 && zmienna3))
            { 
            
            }

            if (zmienna1 && (zmienna2 || zmienna3))
            { 
            
            }

            if (zmienna1 || (zmienna2 || zmienna3))
            { 
            
            }

            if (zmienna1 && (zmienna2 && zmienna3))
            { 
            
            }

            if (zmienna1 || ((zmienna2 && 20 < 100) || (zmienna4 || zmienna3)) || !zmienna4)
            { 
            
            }
        }
    }
}
