using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ5 {
    class Program {
        static void Main(string[] args) {
            int numero = 0, sumaNumeros = 0;

            do {
                Console.Write("Ingrese un numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero < 0) {
                    Console.WriteLine("Por favor ingresa numeros enteros.");
                    continue;
                }
                sumaNumeros = sumaNumeros + numero;
            } while (numero != 0);

            Console.WriteLine("Suma de los numeros ingresados: " + sumaNumeros);
        }
    }
}
