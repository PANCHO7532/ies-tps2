using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ7 {
    class Program {
        static void Main(string[] args) {
            int sumaDiagonal = 0;
            int[,] numeros = new int[5, 5];
            Random random = new Random();

            for (int a = 0; a < 5; a++) {
                for (int b = 0; b < 5; b++) {
                    numeros[a, b] = random.Next(1, 50);
                    Console.Write("[" + numeros[a, b] + "]\t");
                }
                Console.WriteLine();
            }

            for (int c = 0, d = 0; c < 5; c++, d++) {
                sumaDiagonal = sumaDiagonal + numeros[c, d];
            }

            Console.WriteLine("Suma de todos los elementos en la diagonal principal: " + sumaDiagonal);
        }
    }
}
