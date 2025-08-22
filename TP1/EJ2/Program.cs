using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ2 {
    class Program {
        static void Main(string[] args) {
            float ladoCubo;

            Console.Write("Ingrese el lado de un cubo: ");
            ladoCubo = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("El volumen del cubo es: " + ladoCubo*ladoCubo*ladoCubo);
        }
    }
}
