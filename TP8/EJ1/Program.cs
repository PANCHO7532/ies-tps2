using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EJ1.Modulos;

namespace EJ1 {
    class Program {
        static void Main(string[] args) {
            Caballo caballo = new Caballo("Pepa", "Cebada", 3, "Puro");
            Gato gato = new Gato("Pepe", "Wiskas", 2, "Tri-color");
            Perro perro = new Perro("Pepi", "DogChow", 1, "Caniche");

            caballo.imprimirAlimento();
            gato.imprimirAlimento();
            perro.imprimirAlimento();
        }
    }
}
