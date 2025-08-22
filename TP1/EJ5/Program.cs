using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ5 {
    class Program {
        static void Main(string[] args) {
            float cantidadDolares, valorVenta;

            Console.Write("Ingrese cantidad de dolares: ");
            cantidadDolares = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese tipo de cambio: ");
            valorVenta = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Cantidad en pesos: $" + cantidadDolares * valorVenta);
        }
    }
}