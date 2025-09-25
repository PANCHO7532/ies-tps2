using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ6 {
    class Program {
        static void MostrarConGuiones(string texto) {
            for (int a = 0; a < texto.Length; a++) {
                Console.Write(texto[a]);
                if (a == texto.Length - 1) { continue; }
                if((texto[a] != ' ') &&
                    (texto[a+1] != ' ') &&
                    (a != (texto.Length - 1))) {
                    Console.Write("-");
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args) {
            string texto = "";

            Console.Write("Ingrese texto: ");
            texto = Console.ReadLine();

            MostrarConGuiones(texto);
        }
    }
}
