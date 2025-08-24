using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ1 {
    class Program {
        static void Main(string[] args) {
            float saldoActual, montoMinimo;

            Console.Write("Ingrese saldo actual: ");
            saldoActual = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese monto minimo: ");
            montoMinimo = Convert.ToSingle(Console.ReadLine());

            if (saldoActual >= montoMinimo) {
                Console.WriteLine("¡Puede solicitar el prestamo!");
            } else {
                Console.WriteLine("Saldo insuficiente");
            }
        }
    }
}
