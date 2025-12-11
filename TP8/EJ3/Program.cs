using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EJ3.Modulos;

namespace EJ3 {
    class Program {
        static void Main(string[] args) {
            string nombreCliente, dniCliente;

            Console.Write("Ingrese su nombre: ");
            nombreCliente = Console.ReadLine();

            Console.Write("Ingrese su DNI: ");
            dniCliente = Console.ReadLine();

            string eleccion, matricula, eslora, anioFabricacion;
            string potencia, numeroMastiles, numeroCamarotes;
            string fechaAlquiler, fechaDevolucion, posicionAmarre;
            Barco barco = new Barco() ;

            Console.WriteLine("Escoja tipo de barco: ");
            Console.WriteLine("1) Barco comun");
            Console.WriteLine("2) Barco a motor");
            Console.WriteLine("3) Velero");
            Console.WriteLine("4) Yate");
            Console.WriteLine("5) Salir del programa");
            Console.Write("Escoja una opcion: ");
            eleccion = Console.ReadLine();

            if (eleccion.Length > 1 || (eleccion[0] < '0' || eleccion[0] > '9')) {
                Console.Write("Opcion invalida, presione ENTER para salir: ");
                Console.ReadLine();
                return;
            }
            if (Convert.ToInt32(eleccion) > 5) {
                Console.Write("Opcion invalida, presione ENTER para salir: ");
                Console.ReadLine();
                return;
            }
            if (eleccion == "5") { return; }

            Console.Write("Ingrese matricula: ");
            matricula = Console.ReadLine();

            Console.Write("Ingrese eslora (en metros): ");
            eslora = Console.ReadLine();

            Console.Write("Ingrese año de fabricacion: ");
            anioFabricacion = Console.ReadLine();

            switch (Convert.ToInt32(eleccion)) {
                case 1:
                    barco = new Barco(matricula, Convert.ToDouble(eslora), Convert.ToInt32(anioFabricacion));
                    break;
                case 2:
                    Console.Write("Ingrese potencia del motor: ");
                    potencia = Console.ReadLine();

                    barco = new BarcoMotor(matricula, Convert.ToDouble(eslora), Convert.ToInt32(anioFabricacion), Convert.ToInt32(potencia));
                    break;
                case 3:
                    Console.Write("Ingrese numero de mastiles: ");
                    numeroMastiles = Console.ReadLine();

                    barco = new Velero(matricula, Convert.ToDouble(eslora), Convert.ToInt32(anioFabricacion), Convert.ToInt32(numeroMastiles));
                    break;
                case 4:
                    Console.Write("Ingrese potencia: ");
                    potencia = Console.ReadLine();

                    Console.Write("Ingrese numero de camarotes: ");
                    numeroCamarotes = Console.ReadLine();

                    barco = new Yate(matricula, Convert.ToDouble(eslora), Convert.ToInt32(anioFabricacion), Convert.ToInt32(potencia), Convert.ToInt32(numeroCamarotes));
                    break;
            }

            Console.Write("Describa posicion de amarre: ");
            posicionAmarre = Console.ReadLine();

            Console.Write("Ingrese fecha de alquiler (dd/mm/yyyy): ");
            fechaAlquiler = Console.ReadLine();

            Console.Write("Ingrese fecha de devolucion (dd/mm/yyyy): ");
            fechaDevolucion = Console.ReadLine();

            Alquiler alquiler = new Alquiler(nombreCliente, dniCliente, fechaAlquiler, fechaDevolucion, posicionAmarre, barco);

            Console.WriteLine("Precio final del alquiler: $" + alquiler.calcularAlquiler());
        }
    }
}
