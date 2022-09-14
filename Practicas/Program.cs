using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas
{
    class Program
    {
        static void Main(string[] args)
        {
            int Edad = 21;
            string Nombre = "Lesly";
            string Pais = "Alemania";

            Console.WriteLine("Mi nombre es: {1}, tengo {0} de edad y me gustaria conocer el pais de {2}", Edad, Nombre, Pais);
            Console.ReadKey(); 
        }
    }
 
}

