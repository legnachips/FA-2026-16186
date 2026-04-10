using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class ejercicio1
    {
        static void Main(string[] args)
        {
            string nombre, carrera;

            Console.WriteLine("ingrese nombre: ");
            nombre = Console.ReadLine();
            Console.Write("\ningrese carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine("------- IMPRESION CON + -------");
            Console.WriteLine(nombre + ",Bienvenido a la carrera FA de la carrera " + carrera);

            Console.WriteLine("------- IMPRESION CON $ -------");
            Console.WriteLine($"{nombre}, Bienvenido al curso FA de la carrear {carrera}");

            Console.ReadKey();
        }
    }
}
