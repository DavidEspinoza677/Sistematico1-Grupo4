using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistematico1
{
    internal class Listnumbercs
    {
        public Listnumbercs() 
        {
            //Solicitar los numeros al usuarios

            Console.WriteLine("Ingrese los valores de X: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los valores de y: ");
            int y = int.Parse(Console.ReadLine());

            // Verificar si x es mayor que y
            if (x > y)
            {
                // Mostrar los números en orden inverso
                for (int i = 20; i >= 10; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                // Mostrar los números en orden normal
                for (int i = 15; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }


}
    

