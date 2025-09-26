using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ4.Modulos {
    class Empleado {
        private string nombre;
        private string apellido;
        private string fechaDeIngreso;
        private string dni;

        public Empleado(string _nombre, string _apellido, string _fechaDeIngreso, string _dni) {
            nombre = _nombre;
            apellido = _apellido;
            fechaDeIngreso = _fechaDeIngreso;
            dni = _dni;
        }

        public string getNombre() {
            return nombre;
        }
        public string getApellido() {
            return apellido;
        }
        public string getFechaDeIngreso() {
            return fechaDeIngreso;
        }
        public string getDni() {
            return dni;
        }

        public void setNombre(string _nombre) {
            nombre = _nombre;
        }
        public void setApellido(string _apellido) {
            apellido = _apellido;
        }
        public void setFechaDeIngreso(string _fechaDeIngreso) {
            fechaDeIngreso = _fechaDeIngreso;
        }
        public void setDni(string _dni) {
            dni = _dni;
        }
    }
}
