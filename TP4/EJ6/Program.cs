using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ6 {
    class Program {
        static void Main(string[] args) {
            int numeroIngresado;
            int cantidadRepetidas = 0;
            int[] numeros = new int[500];
            Random random = new Random();

            for (int a = 0; a < numeros.Length; a++) {
                numeros[a] = random.Next(1, 100);
            }

            Console.Write("Ingrese un numero: ");
            numeroIngresado = Convert.ToInt32(Console.ReadLine());

            foreach(int numero in numeros) {
                if (numero == numeroIngresado) {
                    cantidadRepetidas = cantidadRepetidas + 1;
                }
            }

            if (cantidadRepetidas > 0) {
                Console.WriteLine("El numero ingresado aparece en el array!");
                Console.WriteLine("Cantidad de veces que aparece: " + cantidadRepetidas);
            } else {
                Console.WriteLine("El numero ingresado no aparece en el array!");
            }
        }
    }
}
