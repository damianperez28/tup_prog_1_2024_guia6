using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, suma=0;
            Console.WriteLine("Ingrese hasta que numero desea sumar los naturales");
            numero = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i <= numero; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine("La suma es: " + suma);
            Console.ReadKey();
        }
    }
}
