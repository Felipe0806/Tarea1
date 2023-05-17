using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaIndividual1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la base del triángulo: ");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del triángulo: ");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

            double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

            Console.WriteLine("El área del triángulo es: " + areaTriangulo);
            Console.ReadLine();

        }
    }
}
