using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ4 {
    class Program {
        static void Main(string[] args) {
            string nombrePlan;

            Console.Write("Ingrese nombre de plan: ");
            nombrePlan = Console.ReadLine().ToUpper();

            if (nombrePlan == "BASICO") {
                Console.WriteLine("Precio del plan: $30");
            } else if (nombrePlan == "INTERMEDIO") {
                Console.WriteLine("Precio del plan: $50");
            } else if (nombrePlan == "AVANZADO") {
                Console.WriteLine("Precio del plan: $80");
            } else {
                Console.WriteLine("Plan no valido");
            }
        }
    }
}
