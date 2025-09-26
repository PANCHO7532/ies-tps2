using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EJ2.Modulos;

namespace EJ2 {
    class Program {
        static void Main(string[] args) {
            Cuadrilatero cuadrilatero = new Cuadrilatero(70, 50);

            Console.WriteLine("El perimetro es: " + cuadrilatero.calcularPerimetro());
            Console.WriteLine("Su superficie es: " + cuadrilatero.calcularArea());

            if (cuadrilatero.esUnCuadrado()) {
                Console.WriteLine("El cuadrilatero es un cuadrado.");
            } else {
                Console.WriteLine("El cuadrilatero no es un cuadrado.");
            }

            cuadrilatero.setAlto(70);

            if (cuadrilatero.esUnCuadrado()) {
                Console.WriteLine("El cuadrilatero es un cuadrado.");
            } else {
                Console.WriteLine("El cuadrilatero no es un cuadrado.");
            }
        }
    }
}
