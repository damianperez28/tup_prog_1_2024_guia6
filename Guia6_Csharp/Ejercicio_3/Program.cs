using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, sumadenumeros=0, promedio;
            Console.WriteLine("Ingrese los 10 numero");
            for(int i = 0; i < 10; i++) 
            {
                numero = Convert.ToInt32(Console.ReadLine());
                sumadenumeros = numero + sumadenumeros;
            }
            promedio = sumadenumeros / 10;
            Console.WriteLine("El promedio es: {0}%", promedio);
            Console.ReadKey();
        }
    }
}
