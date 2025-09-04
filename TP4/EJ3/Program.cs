using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ3 {
    class Program {
        static void Main(string[] args) {
            char caracter;

            Console.Write("Ingrese un caracter: ");
            caracter = Convert.ToChar(Console.ReadLine());
            
            if (Char.IsLower(caracter)) {
                Console.WriteLine("El caracter ingresado es una minuscula");
            } else if (Char.IsUpper(caracter)) {
                Console.WriteLine("El caracter ingresado es una mayuscula");
            } else if (Char.IsDigit(caracter)) {
                Console.WriteLine("El caracter ingresado es un digito");
            } else if (Char.IsPunctuation(caracter)) {
                Console.WriteLine("El caracter ingresado es un signo de puntuacion");
            }
        }
    }
}
