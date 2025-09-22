using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ4 {
    class Program {
        static void Main(string[] args) {
            string textoIngresado, vocalIngresada;

            Console.Write("Ingrese frase: ");
            textoIngresado = Console.ReadLine();

            Console.Write("Ingrese vocal: ");
            vocalIngresada = Console.ReadLine();

            vocalIngresada = vocalIngresada.Substring(0, 1);
            textoIngresado = textoIngresado.Replace(vocalIngresada, vocalIngresada.ToUpper());

            Console.WriteLine(textoIngresado);
        }
    }
}
