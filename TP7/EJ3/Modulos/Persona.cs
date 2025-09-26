using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ3.Modulos {
    class Persona {
        private string nombre;
        private string apellido;
        private int edad;
        private string documento;
        private Perro perro1;
        private Perro perro2;
        private Perro perro3;

        public Persona(string _nombre, string _apellido, int _edad, string _documento) {
            nombre = _nombre;
            apellido = _apellido;
            edad = _edad;
            documento = _documento;
        }

        public string getNombre() {
            return nombre;
        }
        public string getApellido() {
            return apellido;
        }
        public int getEdad() {
            return edad;
        }
        public string getDocumento() {
            return documento;
        }

        public void setNombre(string _nombre) {
            nombre = _nombre;
        }
        public void setApellido(string _apellido) {
            apellido = _apellido;
        }
        public void setEdad(int _edad) {
            edad = _edad;
        }
        public void setDocumento(string _documento) {
            documento = _documento;
        }

        public void adoptarPerro(Perro _perro) {
            Perro[] perros = { perro1, perro2, perro3 };
            if (perro1 == null) {
                perro1 = _perro;
                Console.WriteLine("El perro " + _perro.getNombre() + " fue adoptado!");
            } else if (perro2 == null) {
                perro2 = _perro;
                Console.WriteLine("El perro " + _perro.getNombre() + " fue adoptado!");
            } else if (perro3 == null) {
                perro3 = _perro;
                Console.WriteLine("El perro " + _perro.getNombre() + " fue adoptado!");
            } else {
                Console.WriteLine("Ya no puedo adoptar");
            }
        }
        public Perro perroMasGrande() {
            Perro perroGrande = perro1;

            if (perro2.getEdad() > perro1.getEdad()) { perroGrande = perro2; }
            if (perro3.getEdad() > perro1.getEdad()) { perroGrande = perro3; }

            return perroGrande;
        }
    }
}
