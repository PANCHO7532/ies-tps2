using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EJ4.Modulos;

namespace EJ4 {
    class Program {
        static void Main(string[] args) {
            Kiosco kiosco = new Kiosco("Kiosco Jorge", "9 de Julio S/N", "12345678");
            Empleado empleado1 = new Empleado("Jorgelio", "Perez", "01/01/2019", "42424242");
            Empleado empleado2 = new Empleado("Jorgelina", "Rodrigez", "02/02/2020", "69696969");
            Empleado empleado3 = new Empleado("Jorgencio", "Gonzalez", "03/03/2021", "87654321");

            kiosco.incorporarEmpleado(empleado1);
            kiosco.incorporarEmpleado(empleado2);
            kiosco.incorporarEmpleado(empleado3);

            Empleado empleadoAntiguo = kiosco.empleadoMasAntiguo();

            Console.WriteLine("El empleado con mas antiguedad es: " +
                empleadoAntiguo.getNombre() + " " +
                empleadoAntiguo.getApellido());
        }
    }
}
