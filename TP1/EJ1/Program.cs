using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program {
    static void Main(string[] args) {
        float baseRectangulo, alturaRectangulo;

        Console.Write("Ingrese la base del rectangulo: ");
        baseRectangulo = Convert.ToSingle(Console.ReadLine());

        Console.Write("Ingrese la altura del rectangulo: ");
        alturaRectangulo = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("El area del rectangulo es: " + (baseRectangulo * alturaRectangulo));
    }
}