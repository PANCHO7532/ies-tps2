using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ2 {
    class Program {
        static void Main(string[] args) {
            string textoIngresado;
            int cantidadVocales = 0;

            Console.Write("Ingrese texto: ");
            textoIngresado = Console.ReadLine().ToUpper();

            foreach (char caracter in textoIngresado) {
                switch (caracter) {
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        cantidadVocales++;
                        break;
                }
            }

            Console.WriteLine("Cantidad de vocales en el texto: " + cantidadVocales);
        }
    }
}
