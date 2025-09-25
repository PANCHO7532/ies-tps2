using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ3 {
    class Program {
        static bool esPrimo(int numero) {
            if (numero < 2) {
                return false;
            }
            for (int a = 2; a * a <= numero; a++) {
                if ((numero % a == 0) && (a != numero)) {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args) {
            int numero;

            Console.Write("Ingrese numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (esPrimo(numero)) {
                Console.WriteLine("El numero es primo.");
            } else {
                Console.WriteLine("El numero no es primo.");
            }
        }
    }
}
