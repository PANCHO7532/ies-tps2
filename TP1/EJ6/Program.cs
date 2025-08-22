using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ6 {
    class Program {
        static void Main(string[] args) {
            float num1, num2, num3;
            float promedio;

            Console.Write("Ingrese numero 1: ");
            num1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese numero 2: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese numero 3: ");
            num3 = Convert.ToSingle(Console.ReadLine());

            promedio = (num1 + num2 + num3) / 3;

            Console.WriteLine("El promedio es: " + promedio);
        }
    }
}
