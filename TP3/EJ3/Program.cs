using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ3 {
    class Program {
        static void Main(string[] args) {
            int numero;

            Console.Write("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (float a = 1; a <= 10; a++) {
                Console.WriteLine(a + " * " + numero + " = " + (a * numero));
            }
        }
    }
}
