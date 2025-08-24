using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ7 {
    class Program {
        static void Main(string[] args) {
            int operacion;
            float num1, num2;

            Console.Write("Ingrese un numero: ");
            num1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese otro numero: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Operaciones:");
            Console.WriteLine("1) +");
            Console.WriteLine("2) -");
            Console.WriteLine("3) *");
            Console.WriteLine("4) /");
            Console.Write("Elija una operacion: ");

            operacion = Convert.ToInt32(Console.ReadLine());

            switch (operacion) {
                case 1:
                    Console.WriteLine("El resultado es: " + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("El resultado es: " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("El resultado es: " + (num1 * num2));
                    break;
                case 4:
                    if (num2 == 0) {
                        Console.WriteLine("ERROR! No puedes dividir en cero.");
                    } else {
                        Console.WriteLine("El resultado es: " + (num1 / num2));
                    }
                    break;
                default:
                    Console.WriteLine("ERROR! Opcion invalida.");
                    break;
            }
        }
    }
}
