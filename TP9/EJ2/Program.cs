using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EJ2.Modulos;

namespace EJ2 {
    class Program {
        static void Main(string[] args) {
            string eleccion;
            Usuario[] usuarios = new Usuario[20];

            while (true) {
                Console.Clear();
                Console.WriteLine("1) Mostrar usuarios");
                Console.WriteLine("2) Agregar usuarios");
                Console.WriteLine("3) Borrar usuarios");
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

                string tempDNI, tempNombre, tempDireccion, tempTelefono, tempNumeroUsuario;
                Usuario usuario;

                switch (Convert.ToInt32(eleccion)) {
                    case 1:
                        bool noHayUsuarios = true;
                        Console.Clear();
                        Console.WriteLine("------------------------------");
                        for (int a = 0; a < usuarios.Length; a++) {
                            if (usuarios[a] == null) { continue; }
                            noHayUsuarios = false;
                            Console.WriteLine("Numero de usuario: " + (a + 1));
                            Console.WriteLine("DNI: " + usuarios[a].GetDni());
                            Console.WriteLine("Nombre: " + usuarios[a].GetNombre());
                            Console.WriteLine("Direccion: " + usuarios[a].GetDireccion());
                            Console.WriteLine("Telefono: " + usuarios[a].GetTelefono());
                            if (usuarios[a].GetSancionesPendientes()) {
                                Console.WriteLine("Sanciones pendientes: SI");
                            } else {
                                Console.WriteLine("Sanciones pendientes: NO");
                            }
                            Console.WriteLine("------------------------------");
                        }
                        if (noHayUsuarios) {
                            Console.WriteLine("No hay usuarios para mostrar.");
                            Console.WriteLine("------------------------------");
                        }
                        Console.Write("Presione ENTER para continuar: ");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Ingrese DNI: ");
                        tempDNI = Console.ReadLine();

                        Console.Write("Ingrese nombre: ");
                        tempNombre = Console.ReadLine();

                        Console.Write("Ingrese direccion: ");
                        tempDireccion = Console.ReadLine();

                        Console.Write("Ingrese telefono: ");
                        tempTelefono = Console.ReadLine();

                        Console.Write("El usuario tiene sanciones? [S/N]: ");
                        if (Console.ReadLine().ToUpper()[0] == 'S') {
                            usuario = new Usuario(tempDNI, tempNombre, tempDireccion, tempTelefono);
                            usuario.SetSancionesPendientes(true);
                        } else {
                            usuario = new Usuario(tempDNI, tempNombre, tempDireccion, tempTelefono);
                            usuario.SetSancionesPendientes(false);
                        }
                        for (int b = 0; b < usuarios.Length; b++) {
                            if (usuarios[b] == null) {
                                usuarios[b] = usuario;
                                break;
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("Usuario agregado!");
                        Console.Write("Presione ENTER para continuar: ");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Ingrese numero de usuario: ");
                        tempNumeroUsuario = Console.ReadLine();
                        if ((tempNumeroUsuario[0] < '1' || tempNumeroUsuario[0] > '9')) {
                            Console.Write("Usuario invalido, presione ENTER para continuar: ");
                            Console.ReadLine();
                            break;
                        }
                        if (Convert.ToInt32(tempNumeroUsuario) > usuarios.Length) {
                            Console.Write("Usuario invalido, presione ENTER para continuar: ");
                            Console.ReadLine();
                            break;
                        }
                        if (Convert.ToInt32(tempNumeroUsuario) == 0) {
                            Console.Write("Usuario invalido, presione ENTER para continuar: ");
                            Console.ReadLine();
                            break;
                        }
                        usuarios[Convert.ToInt32(tempNumeroUsuario) - 1] = null;
                        Console.Clear();
                        Console.WriteLine("Usuario eliminado!");
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
