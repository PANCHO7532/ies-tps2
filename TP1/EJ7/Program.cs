using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ7 {
    class Program {
        static void Main(string[] args) {
            float cantidadAlumnos, cantidadAprobados;
            float resultado;

            Console.Write("Ingrese cantidad de alumnos: ");
            cantidadAlumnos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese cantidad de alumnos aprobados: ");
            cantidadAprobados = Convert.ToInt32(Console.ReadLine());

            resultado = (cantidadAprobados * 100.0F) / cantidadAlumnos;

            Console.WriteLine("El porcentaje de alumnos aprobados es: " + resultado + "%");
        }
    }
}
