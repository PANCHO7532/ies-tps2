using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ6 {
    class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int numeroGanador = random.Next(1, 50);
            int numeroIngresado = 0;
            int intentosRestantes = 5;

            Console.WriteLine("Numero ganador: " + numeroGanador);

            do {
                Console.Write("Ingresa un numero: ");
                numeroIngresado = Convert.ToInt32(Console.ReadLine());
                intentosRestantes--;

                // Calcular pistas basado en distancia entre numeros
                if (numeroIngresado < numeroGanador) {
                    int distancia = numeroGanador - numeroIngresado;
                    
                    // Si es nuestro ultimo intento no mostrar pistas
                    if (intentosRestantes == 0) {
                        continue;
                    }

                    if (distancia > 20) {
                        Console.WriteLine("Frio!");
                    } else if (distancia > 10) {
                        Console.WriteLine("Tibio!");
                    } else {
                        Console.WriteLine("Caliente!");
                    }
                }

                if (numeroIngresado > numeroGanador) {
                    int distancia = numeroIngresado - numeroGanador;

                    // Si es nuestro ultimo intento no mostrar pistas
                    if (intentosRestantes == 0) {
                        continue;
                    }

                    if (distancia > 20) {
                        Console.WriteLine("Frio!");
                    } else if (distancia > 10) {
                        Console.WriteLine("Tibio!");
                    } else {
                        Console.WriteLine("Caliente!");
                    }
                }
            } while ((numeroIngresado != numeroGanador) && (intentosRestantes > 0));

            if (numeroIngresado == numeroGanador) {
                Console.WriteLine("Ganaste!");
            } else {
                Console.WriteLine("Perdiste!");
            }
        }
    }
}