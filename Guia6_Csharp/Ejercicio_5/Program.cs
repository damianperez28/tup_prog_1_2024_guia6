using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota=0, cant8=0, cant3=0, cantAprobados=0, cantNoAprobados=0, cantnotas=0, condicionAprobacion, acumnotas=0;
            double promedio, porcMuyBueno, porcInsuficiente;
            Console.WriteLine("Ingrese la condicion de aprobacion");
            condicionAprobacion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese una nota");
            nota = Convert.ToInt32(Console.ReadLine());
            while (nota != -1)
            {
                acumnotas += nota;
                if (nota >= condicionAprobacion){
                    cantAprobados++;
                    if (nota >=8) 
                    { 
                        cant8++; 
                    }
                }
                if (nota < condicionAprobacion)
                {
                    cantNoAprobados++;
                    if(condicionAprobacion <= 3)
                    {
                        cant3++;
                    }
                }
                cantnotas++;
                Console.WriteLine("Ingrese una nota o ingrese -1 para cortar");
                nota = Convert.ToInt32(Console.ReadLine());

            }
            porcMuyBueno = 1.0*cant8 * 100 / cantnotas;
            porcInsuficiente = 1.0*cant3 * 100 / cantnotas;
            promedio = 1.0*acumnotas / cantnotas;
            Console.Clear();
            Console.WriteLine("Cantidad de notas: " + cantnotas);
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Cantidad de aprobados: " + cantAprobados);
            Console.WriteLine("Cantidad de desaprobados: " + cantNoAprobados);
            Console.WriteLine("Porcentaje de notas 8 o mas: " + porcMuyBueno);
            Console.WriteLine("Porcentaje de notas 3 o menos: " + porcInsuficiente);
            Console.ReadKey();

        }
    }
}
