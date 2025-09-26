using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ3.Modulos {
    class Perro {
        private string nombre;
        private string raza;
        private int edad;
        private string tamano;

        public Perro(string _nombre, string _raza, int _edad, string _tamano) {
            nombre = _nombre;
            raza = _raza;
            edad = _edad;
            tamano = _tamano;
        }

        public string getNombre() {
            return nombre;
        }
        public string getRaza() {
            return raza;
        }
        public int getEdad() {
            return edad;
        }
        public string getTamano() {
            return tamano;
        }

        public void setNombre(string _nombre) {
            nombre = _nombre;
        }
        public void setRaza(string _raza) {
            raza = _raza;
        }
        public void setEdad(int _edad) {
            edad = _edad;
        }
        public void setTamano(string _tamano) {
            tamano = _tamano;
        }

    }
}
