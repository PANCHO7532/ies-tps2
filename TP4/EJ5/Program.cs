using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ5 {
    class Program {
        static void Main(string[] args) {
            string claveIngresada;
            string claveSecreta = "cLaVe123!";
            bool claveContieneNumero = false;
            bool claveContieneMayuscula = false;
            bool claveContieneMinuscula = false;
            bool claveContieneSimbolos = false;

            Console.Write("Ingrese contraseña: ");
            claveIngresada = Console.ReadLine();

            for (int a = 0; a < claveIngresada.Length; a++) {
                if (Char.IsDigit(claveIngresada, a)) {
                    claveContieneNumero = true;
                }
                if (Char.IsUpper(claveIngresada, a)) {
                    claveContieneMayuscula = true;
                }
                if (Char.IsLower(claveIngresada, a)) {
                    claveContieneMinuscula = true;
                }
                if (Char.IsSymbol(claveIngresada, a) || Char.IsPunctuation(claveIngresada, a)) {
                    claveContieneSimbolos = true;
                }
            }

            if (claveContieneNumero && claveContieneMayuscula && claveContieneMinuscula && claveContieneSimbolos) {
                Console.Write("Tu clave encriptada es: ");
                for (int b = 0, c = 0; b < claveIngresada.Length; b++, c++) {
                    if(c >= claveSecreta.Length) {
                        c = 0;
                    }
                    Console.Write((char)(claveIngresada[b] ^ claveSecreta[c]));
                }
                Console.WriteLine();
            } else {
                Console.WriteLine("La clave necesita al menos un numero, una letra mayuscula y minuscula y un simbolo");
            }
        }
    }
}
