using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroA=0, numeroB;
            Console.WriteLine("Ingrese dos numeros");
            numeroA = Convert.ToInt32(Console.ReadLine());
            numeroB = Convert.ToInt32(Console.ReadLine());

            if(numeroA > numeroB)
            {
                numeroA = numeroB;
                numeroB = numeroA;
            }

            for (int i = numeroA; i <= numeroB; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(i+" Es divisible por 2 y por 3");
                }
            }
            Console.ReadKey();
        }
    }
}
