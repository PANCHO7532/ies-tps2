using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ2 {
    class Program {
        static void Main(string[] args) {
            float precioProducto;

            Console.Write("Ingrese el precio del producto: ");
            precioProducto = Convert.ToSingle(Console.ReadLine());

            if (precioProducto > 1000.0F) {
                precioProducto = precioProducto - ((precioProducto * 21.0F) / 100.0F);
            }
            Console.WriteLine("Precio final: $" + precioProducto);
        }
    }
}
