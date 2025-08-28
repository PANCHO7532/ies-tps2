using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ4 {
    class Program {
        static void Main(string[] args) {
            int edadIngresada;

            do {
                Console.Write("Ingrese su edad: ");
                edadIngresada = Convert.ToInt32(Console.ReadLine());
            } while (edadIngresada < 1 || edadIngresada > 120);
        }
    }
}
