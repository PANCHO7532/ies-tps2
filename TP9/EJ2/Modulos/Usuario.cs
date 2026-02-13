using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ2.Modulos {
    class Usuario {
        private string dni, nombre, direccion, telefono;
        private bool sancionesPendientes;

        public Usuario(string dni, string nombre, string direccion, string telefono) {
            SetDni(dni);
            SetNombre(nombre);
            SetDireccion(direccion);
            SetTelefono(telefono);
        }

        public string GetDni() { return dni; }
        public void SetDni(string dni) { this.dni = dni; }

        public string GetNombre() { return nombre; }
        public void SetNombre(string nombre) { this.nombre = nombre; }

        public string GetDireccion() { return direccion; }
        public void SetDireccion(string direccion) { this.direccion = direccion; }

        public string GetTelefono() { return telefono; }
        public void SetTelefono(string telefono) { this.telefono = telefono; }

        public bool GetSancionesPendientes() { return sancionesPendientes; }
        public void SetSancionesPendientes(bool sancionesPendientes) { this.sancionesPendientes = sancionesPendientes; }
    }
}
