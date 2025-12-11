using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ1.Modulos {
    class Animal {
        private string nombre;
        private string alimento;
        private int edad;
        private string raza;

        public Animal() {}

        public Animal(string nombre, string alimento, int edad, string raza) {
            setNombre(nombre);
            setAlimento(alimento);
            setEdad(edad);
            setRaza(raza);
        }

        public string getNombre() { return nombre; }
        public string getAlimento() { return alimento; }
        public int getEdad() { return edad; }
        public string getRaza() { return raza; }

        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setAlimento(string alimento) { this.alimento = alimento; }
        public void setEdad(int edad) { this.edad = edad; }
        public void setRaza(string raza) { this.raza = raza; }

        public virtual void imprimirAlimento() {
            Console.WriteLine("Mi alimento es: " + getAlimento());
        }
    }
}
