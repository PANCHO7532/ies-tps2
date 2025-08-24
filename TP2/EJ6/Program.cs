using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ6 {
    class Program {
        static void Main(string[] args) {
            float temperaturaCelsius, temperaturaConvertida;
            int eleccion;

            Console.Write("Ingrese la temperatura en grados celsius: ");
            temperaturaCelsius = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("1) Convertir a grados Fahrenheit");
            Console.WriteLine("2) Convertir a grados Kelvin");
            Console.WriteLine("3) Convertir a grados Rankine");
            Console.Write("Elija una opcion: ");

            eleccion = Convert.ToInt32(Console.ReadLine());

            switch (eleccion) {
                case 1:
                    temperaturaConvertida = (temperaturaCelsius * (9.0F/5.0F)) + 32.0F;
                    Console.WriteLine("Temperatura en Fahrenheit: " + temperaturaConvertida + "°F");
                    break;
                case 2:
                    temperaturaConvertida = temperaturaCelsius + 273.15F;
                    Console.WriteLine("Temperatura en Kelvin: " + temperaturaConvertida + "°K");
                    break;
                case 3:
                    temperaturaConvertida = (temperaturaCelsius + 273.15F) * (9.0F / 5.0F);
                    Console.WriteLine("Temperatura en Rankine: " + temperaturaConvertida + "°R");
                    break;
                default:
                    Console.WriteLine("ERROR! Opcion invalida.");
                    break;
            }
        }
    }
}
