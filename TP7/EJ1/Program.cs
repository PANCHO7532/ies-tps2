using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EJ1.Modulos;

namespace EJ1 {
    class Program {
        static void Main(string[] args) {
            Numero numero = new Numero(1459);
            if (numero.esPar()) {
                Console.WriteLine("El numero es par.");
            } else {
                Console.WriteLine("El numero no es par.");
            }

            if (numero.esPositivo()) {
                Console.WriteLine("El numero es positivo");
            } else {
                Console.WriteLine("El numero no es positivo");
            }

            if (numero.esMultiploDe(3)) {
                Console.WriteLine("El numero es multiplo.");
            } else {
                Console.WriteLine("El numero no es multiplo.");
            }
        }
    }
}
