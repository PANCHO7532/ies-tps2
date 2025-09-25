using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ2 {
    class Program {
        static int cantidadVocales(string texto) {
            int cantidad = 0;
            foreach (char c in texto.ToUpper()) {
                switch (c) {
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        cantidad = cantidad + 1;
                        break;
                }
            }
            return cantidad;
        }
        static void Main(string[] args) {
            string texto;

            Console.Write("Escriba texto: ");
            texto = Console.ReadLine();

            Console.WriteLine("Cantidad de vocales en texto: " + cantidadVocales(texto));
        }
    }
}
