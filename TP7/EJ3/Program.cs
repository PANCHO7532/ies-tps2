using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EJ3.Modulos;

namespace EJ3 {
    class Program {
        static void Main(string[] args) {
            Persona persona = new Persona("Juan", "Perez", 25, "42424242");
            Perro perro1 = new Perro("Pepe", "Caniche", 1, "Chico");
            Perro perro2 = new Perro("Popo", "Pila", 2, "Chico");
            Perro perro3 = new Perro("Pipi", "Bulldog", 3, "Mediano");
            Perro perro4 = new Perro("Pupu", "Ovejero Aleman", 4, "Grande");

            persona.adoptarPerro(perro1);
            persona.adoptarPerro(perro2);
            persona.adoptarPerro(perro3);
            persona.adoptarPerro(perro4);

            Perro perroGrande = persona.perroMasGrande();
            Console.WriteLine("El perro mas grande es: " +
                perroGrande.getNombre() + " - " +
                perroGrande.getRaza() + " " +
                perroGrande.getTamano());
        }
    }
}
