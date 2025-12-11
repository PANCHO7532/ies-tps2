using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EJ2.Modulos;

namespace EJ2 {
    class Program {
        static void Main(string[] args) {
            Lavadora lavadora = new Lavadora(100, "Negro", 'A', 50, 50);
            Televisor televisor = new Televisor(200, "Rojo", 'B', 42, 42, true);

            Console.WriteLine("Precio final lavadora: $" + lavadora.precioFinal());
            Console.WriteLine("Precio final televisor: $" + televisor.precioFinal());
        }
    }
}
