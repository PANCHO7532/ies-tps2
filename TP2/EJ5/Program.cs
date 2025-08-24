using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ5 {
    class Program {
        static void Main(string[] args) {
            int edadSocio;

            Console.Write("Ingrese la edad del socio: ");
            edadSocio = Convert.ToInt32(Console.ReadLine());

            if (edadSocio >= 5 && edadSocio <= 12) {
                Console.WriteLine("Categoria: Infantil");
            } else if (edadSocio >= 13 && edadSocio <= 17) {
                Console.WriteLine("Categoia: Juvenil");
            } else if (edadSocio >= 18 && edadSocio <= 64) {
                Console.WriteLine("Categoria: Adulto");
            } else if (edadSocio >= 65) {
                Console.WriteLine("Categoria: Senior");
            } else {
                Console.WriteLine("No admitido");
            }
        }
    }
}
