using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ1 {
    class Program {
        static float suma(float a, float b) {
            return a + b;
        }
        static float resta(float a, float b) {
            return a - b;
        }
        static float multiplicar(float a, float b) {
            return a * b;
        }
        static float dividir(float a, float b) {
            return a / b;
        }
        static void Main(string[] args) {
            String eleccion;
            float num1, num2;

            do {
                Console.Write("Ingrese un numero: ");
                num1 = Convert.ToSingle(Console.ReadLine());

                Console.Write("Ingrese otro numero: ");
                num2 = Convert.ToSingle(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("1) Sumar");
                Console.WriteLine("2) Restar");
                Console.WriteLine("3) Multiplicar");
                Console.WriteLine("4) Dividir");
                Console.WriteLine("5) Salir del programa");
                Console.Write("Escoja una opcion: ");
                eleccion = Console.ReadLine();

                switch (eleccion.Substring(0, 1)) {
                    case "1":
                        Console.WriteLine("El resultado es: " + suma(num1, num2));
                        Console.WriteLine("Presione ENTER para continuar");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("El resultado es: " + resta(num1, num2));
                        Console.WriteLine("Presione ENTER para continuar");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("El resultado es: " + multiplicar(num1, num2));
                        Console.WriteLine("Presione ENTER para continuar");
                        Console.ReadLine();
                        break;
                    case "4":
                        if (num2 == 0) {
                            Console.WriteLine("No puedes dividir en cero.");
                            break;
                        }
                        Console.WriteLine("El resultado es: " + dividir(num1, num2));
                        Console.WriteLine("Presione ENTER para continuar");
                        Console.ReadLine();
                        break;
                    case "5":
                        return;
                }
            } while (true);
        }
    }
}
