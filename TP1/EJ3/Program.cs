using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ3 {
    class Program {
        static void Main(string[] args) {
            float temperaturaCelsius;
            float temperaturaFahrenheit;

            Console.Write("Ingrese la temperatura en grados Celsius: ");
            temperaturaCelsius = Convert.ToSingle(Console.ReadLine());

            temperaturaFahrenheit = (temperaturaCelsius * (9.0F/5.0F)) + 32.0F;
            Console.WriteLine("La temperatura en grados fahrenheit es: " + temperaturaFahrenheit + " grados");
        }
    }
}
