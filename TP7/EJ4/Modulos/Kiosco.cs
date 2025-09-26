using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ4.Modulos {
    class Kiosco {
        private string nombre;
        private string direccion;
        private string cuit;
        private Empleado empleado1;
        private Empleado empleado2;
        private Empleado empleado3;

        public Kiosco(string _nombre, string _direccion, string _cuit) {
            nombre = _nombre;
            direccion = _direccion;
            cuit = _cuit;
        }

        public string getNombre() {
            return nombre;
        }
        public string getDireccion() {
            return direccion;
        }
        public string getCuit() {
            return cuit;
        }

        public void setNombre(string _nombre) {
            nombre = _nombre;
        }
        public void setDireccion(string _direccion) {
            direccion = _direccion;
        }
        public void setCuit(string _cuit) {
            cuit = _cuit;
        }

        private double fechaANumero(string fecha) {
            // Basado en absolutamente nada
            // Pero sirve para representar mejor la antiguedad de empleados
            // Esto funciona como un tiempo UNIX barato si lo puedes decir así
            // Solo que no empieza desde 1970, ni cuenta años bisiestos :P
            // Y por supuesto, asume que le pases una fecha tipo dd/mm/yyyy
            // Idealmente se tendria que usar las funciones DateTime de C# para esto
            string[] elementosFecha = fecha.Split('/');
            double v1 = Convert.ToDouble(elementosFecha[2]) * 3153600;
            double v2 = Convert.ToDouble(elementosFecha[1]) * 262800;
            double v3 = Convert.ToDouble(elementosFecha[0]) * 8640;
            return v1 + v2 + v3;
        }
        public void incorporarEmpleado(Empleado _empleado) {
            if (empleado1 == null) {
                empleado1 = _empleado;
                Console.WriteLine("El empleado " + _empleado.getNombre() +
                    " " + _empleado.getApellido() + " fue incorporado al kiosco!");
            } else if (empleado2 == null) {
                empleado2 = _empleado;
                Console.WriteLine("El empleado " + _empleado.getNombre() +
                    " " + _empleado.getApellido() + " fue incorporado al kiosco!");
            } else if (empleado3 == null) {
                empleado3 = _empleado;
                Console.WriteLine("El empleado " + _empleado.getNombre() +
                    " " + _empleado.getApellido() + " fue incorporado al kiosco!");
            } else {
                Console.WriteLine("No se pueden incorporar mas empleados");
            }
        }

        public Empleado empleadoMasAntiguo() {
            Empleado empleadoAntiguo = empleado1;
            if(fechaANumero(empleado2.getFechaDeIngreso()) > fechaANumero(empleado1.getFechaDeIngreso())) {
                empleadoAntiguo = empleado2;
            }
            if (fechaANumero(empleado3.getFechaDeIngreso()) > fechaANumero(empleado1.getFechaDeIngreso())) {
                empleadoAntiguo = empleado3;
            }
            return empleadoAntiguo;
        }
    }
}
