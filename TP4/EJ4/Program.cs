using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ4 {
    class Program {
        static void Main(string[] args) {
            string usuarioIngresado, claveIngresada;
            bool claveContieneNumero = false;
            bool claveContieneMayuscula = false;
            bool claveContieneMinuscula = false;
            bool claveContieneSimbolos = false;

            Console.Write("Ingrese nombre de usuario: ");
            usuarioIngresado = Console.ReadLine();

            Console.Write("Ingrese contraseña: ");
            claveIngresada = Console.ReadLine();

            for (int a = 0; a < usuarioIngresado.Length; a++) {
                if (Char.IsDigit(usuarioIngresado, a)) {
                    Console.WriteLine("El usuario no puede llevar un numero.");
                    return;
                }
                if (Char.IsSymbol(usuarioIngresado, a) || Char.IsPunctuation(usuarioIngresado, a)) {
                    Console.WriteLine("El usuario no puede contener simbolos.");
                    return;
                }
                if (Char.IsUpper(usuarioIngresado, a)) {
                    Console.WriteLine("El usuario solo puede tener letras de la 'a' a la 'z'.");
                    return;
                }
            }

            for (int b = 0; b < claveIngresada.Length; b++) {
                if (Char.IsDigit(claveIngresada, b)) {
                    claveContieneNumero = true;
                }
                if (Char.IsUpper(claveIngresada, b)) {
                    claveContieneMayuscula = true;
                }
                if (Char.IsLower(claveIngresada, b)) {
                    claveContieneMinuscula = true;
                }
                if (Char.IsSymbol(claveIngresada, b) || Char.IsPunctuation(claveIngresada, b)) {
                    claveContieneSimbolos = true;
                }
            }

            if (claveContieneNumero && claveContieneMayuscula && claveContieneMinuscula && claveContieneSimbolos) {
                Console.WriteLine("El usuario y la contraseña se han registrado exitosamente!");
            } else {
                Console.WriteLine("La clave necesita al menos un numero, una letra mayuscula y minuscula y un simbolo");
            }
        }
    }
}
