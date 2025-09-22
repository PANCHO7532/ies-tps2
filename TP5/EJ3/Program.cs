using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ3 {
    class Program {
        static void Main(string[] args) {
            string textoIngresado;

            Console.Write("Ingrese texto: ");
            textoIngresado = Console.ReadLine();

            for (int a = textoIngresado.Length-1; a >= 0; a--) {
                Console.Write(textoIngresado[a]);
            }
            Console.WriteLine();
        }
    }
}
