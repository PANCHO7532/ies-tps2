using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ4 {
    class Program {
        static void Main(string[] args) {
            float montoPrincipal, tasaInteresAnual, tiempo;
            float interesSimple;

            Console.Write("Ingrese monto principal: ");
            montoPrincipal = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese la tasa de interes anual: ");
            tasaInteresAnual = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese el tiempo en años: ");
            tiempo = Convert.ToSingle(Console.ReadLine());

            interesSimple = montoPrincipal * tasaInteresAnual * tiempo;

            Console.WriteLine("El interes simple es: " + interesSimple);
        }
    }
}
