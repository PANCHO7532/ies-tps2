using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ5 {
    class Program {
        static bool esPalindromo(string texto) {
            string textoReverso = "";
            for (int a = 0; a < texto.Length; a++) {
                textoReverso = textoReverso + texto[(texto.Length - 1) - a];
            }
            if (textoReverso == texto) {
                return true;
            } else {
                return false;
            }
        }
        static void Main(string[] args) {
            string texto = "";

            Console.Write("Ingrese texto: ");
            texto = Console.ReadLine();

            if (esPalindromo(texto)) {
                Console.WriteLine("El texto ingresado es un palindromo");
            } else {
                Console.WriteLine("El texto ingresado no es un palindromo");
            }
        }
    }
}
