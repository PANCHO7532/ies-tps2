using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EJ3.Modulos;

namespace EJ3 {
    class Program {
        static void Main(string[] args) {
            string eleccion;
            Material[] materiales = new Material[20];

            while (true) {
                Console.Clear();
                Console.WriteLine("1) Mostrar materiales");
                Console.WriteLine("2) Agregar material");
                Console.WriteLine("3) Borrar material");
                Console.WriteLine("4) Salir del programa");
                Console.Write("Escoja una opcion: ");
                eleccion = Console.ReadLine();

                if (eleccion.Length > 1 || (eleccion[0] < '1' || eleccion[0] > '9')) {
                    Console.Write("Opcion invalida, presione ENTER para salir: ");
                    Console.ReadLine();
                    return;
                }
                if (Convert.ToInt32(eleccion) > 4) {
                    Console.Write("Opcion invalida, presione ENTER para salir: ");
                    Console.ReadLine();
                    return;
                }

                // Generico materiales
                string tempCodigo, tempTitulo, tempNumeroMaterial, tempTipo;
                // Libros
                int tempPaginas;
                // Peliculas
                int tempAnyo;
                string tempDirector;

                Material material = null;

                switch (Convert.ToInt32(eleccion)) {
                    case 1:
                        bool noHayMateriales = true;
                        Console.Clear();
                        Console.WriteLine("------------------------------");
                        for (int a = 0; a < materiales.Length; a++) {
                            if (materiales[a] == null) { continue; }
                            noHayMateriales = false;
                            Console.WriteLine((a+1) + ") " + materiales[a].ToString());
                            Console.WriteLine("------------------------------");
                        }
                        if (noHayMateriales) {
                            Console.WriteLine("No hay materiales para mostrar.");
                            Console.WriteLine("------------------------------");
                        }
                        Console.Write("Presione ENTER para continuar: ");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Ingrese codigo: ");
                        tempCodigo = Console.ReadLine();

                        Console.Write("Ingrese titulo: ");
                        tempTitulo = Console.ReadLine();

                        Console.WriteLine("Especifique tipo de material");
                        Console.WriteLine("1) Libro");
                        Console.WriteLine("2) Pelicula");
                        Console.Write("Ingrese eleccion: ");
                        tempTipo = Console.ReadLine();

                        if (tempTipo[0] > '2' || tempTipo[0] < '0') { break; }
                        if (tempTipo[0] == '1') {
                            Console.Write("Ingrese numero de paginas: ");
                            tempPaginas = Convert.ToInt32(Console.ReadLine());
                            material = new Libro(tempCodigo, tempTitulo, tempPaginas);

                        }
                        if (tempTipo[0] == '2') {
                            Console.Write("Ingrese año de estreno: ");
                            tempAnyo = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingrese director: ");
                            tempDirector = Console.ReadLine();
                            material = new Pelicula(tempCodigo, tempTitulo, tempAnyo, tempDirector);
                        }

                        for (int b = 0; b < materiales.Length; b++) {
                            if (materiales[b] == null) {
                                materiales[b] = material;
                                break;
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("Material agregado!");
                        Console.Write("Presione ENTER para continuar: ");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Ingrese posicion del material: ");
                        tempNumeroMaterial = Console.ReadLine();
                        if ((tempNumeroMaterial[0] < '1' || tempNumeroMaterial[0] > '9')) {
                            Console.Write("Material invalido, presione ENTER para continuar: ");
                            Console.ReadLine();
                            break;
                        }
                        if (Convert.ToInt32(tempNumeroMaterial) > materiales.Length) {
                            Console.Write("Material invalido, presione ENTER para continuar: ");
                            Console.ReadLine();
                            break;
                        }
                        if (Convert.ToInt32(tempNumeroMaterial) == 0) {
                            Console.Write("Material invalido, presione ENTER para continuar: ");
                            Console.ReadLine();
                            break;
                        }
                        materiales[Convert.ToInt32(tempNumeroMaterial) - 1] = null;
                        Console.Clear();
                        Console.WriteLine("Material eliminado!");
                        Console.Write("Presione ENTER para continuar: ");
                        Console.ReadLine();
                        break;
                    case 4:
                        return;
                }
            }
        }
    }
}
