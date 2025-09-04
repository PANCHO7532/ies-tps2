using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ2 {
    class Program {
        static void Main(string[] args) {
            string usuarioIngresado, claveIngresada;

            Console.Write("Ingrese nombre de usuario: ");
            usuarioIngresado = Console.ReadLine();

            Console.Write("Ingrese contraseña: ");
            claveIngresada = Console.ReadLine();

            for (int a = 0; a < usuarioIngresado.Length; a++) {
                if (Char.IsDigit(usuarioIngresado, a)) {
                    Console.WriteLine("El usuario no puede llevar un numero.");
                    break;
                }
            }
        }
    }
}
