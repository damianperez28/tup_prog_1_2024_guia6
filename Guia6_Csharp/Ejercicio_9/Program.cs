using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigoProducto=0, cantidadProducto=0;
            double precioUnitario = 0, caja = 0;

            Console.WriteLine("Ingrese el codigo del producto");
            codigoProducto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de unidades del producto a comprar");
            cantidadProducto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el precio unitario del producto");
            precioUnitario= Convert.ToDouble(Console.ReadLine());

            caja = caja + (cantidadProducto * precioUnitario);

            Console.WriteLine("Desea seguir procesando productos?");
            Console.WriteLine("1. Seguir\n-1.Salir");
            codigoProducto = Convert.ToInt32(Console.ReadLine());

            while (codigoProducto != -1)
            {
                Console.WriteLine("Ingrese el codigo del producto");
                codigoProducto = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de unidades del producto a comprar");
                cantidadProducto = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el precio unitario del producto");
                precioUnitario = Convert.ToDouble(Console.ReadLine());

                caja = caja + (cantidadProducto * precioUnitario);

                Console.WriteLine("Desea seguir procesando productos?");
                Console.WriteLine("1. Seguir\n-1.Salir");
                codigoProducto = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Total a pagar: $" + caja);
            Console.ReadKey();
        }
    }
}
