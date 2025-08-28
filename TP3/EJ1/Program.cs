using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ1 {
    class Program {
        static void Main(string[] args) {
            int PIN = 5678;
            int PINingresado = 0;

            Console.Write("Ingrese PIN: ");
            PINingresado = Convert.ToInt32(Console.ReadLine());
            while (PINingresado != PIN) {
                Console.WriteLine("PIN incorrecto, ingreselo nuevamente!");
                Console.Write("Ingrese PIN: ");
                PINingresado = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Acceso concedido. Bienvenido a su cuenta.");
        }
    }
}
