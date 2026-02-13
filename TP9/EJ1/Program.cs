using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EJ1.Modulos;

namespace EJ1 {
    class Program {
        static void Main(string[] args) {
            string eleccion, dia, mes, anio;

            Console.Write("Ingrese dia: ");
            dia = Console.ReadLine();

            Console.Write("Ingrese mes: ");
            mes = Console.ReadLine();

            Console.Write("Ingrese año: ");
            anio = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("1) Imprimir fecha en Region Argentina");
            Console.WriteLine("2) Imprimir fecha en Region Inglesa");
            Console.WriteLine("3) Salir del programa");
            Console.Write("Escoja una opcion: ");
            eleccion = Console.ReadLine();

            if (eleccion.Length > 1 || (eleccion[0] < '0' || eleccion[0] > '9')) {
                Console.Write("Opcion invalida, presione ENTER para salir: ");
                Console.ReadLine();
                return;
            }
            if (Convert.ToInt32(eleccion) > 3) {
                Console.Write("Opcion invalida, presione ENTER para salir: ");
                Console.ReadLine();
                return;
            }
            if (eleccion == "3") { return; }

            switch (Convert.ToInt32(eleccion)) {
                case 1:
                    RegionArgentina region = new RegionArgentina("Argentina");
                    Console.WriteLine("Fecha en region " + region.getNombreRegion() + ": " + region.Formatear(dia, mes, anio));
                    break;
                case 2:
                    RegionInglesa region2 = new RegionInglesa("Inglesa");
                    Console.WriteLine("Fecha en region " + region2.getNombreRegion() + ": " + region2.Formatear(dia, mes, anio));
                    break;
            }
            return;
        }
    }
}
