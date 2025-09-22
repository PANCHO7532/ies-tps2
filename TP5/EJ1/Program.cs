using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ1 {
    public struct Materia {
        public string nombreMateria;
        public string modalidadAnio;
    };
    public struct Alumno {
        public string apellido;
        public string nombre;
        public string dni;
        public Materia[] materias;
    };

    class Program {
        const int cantidadAlumnos = 10;
        const int cantidadMaterias = 10;
        const int cantidadMateriasPorAlumno = 3;
        static void Main(string[] args) {
            Alumno[] registroAlumnos = new Alumno[cantidadAlumnos];
            Materia[] registroMaterias = new Materia[cantidadMaterias];
            string datosIngresados;

            do {
                Console.Clear();
                Console.WriteLine("Elija una opcion: ");
                Console.WriteLine("1) Registrar alumno");
                Console.WriteLine("2) Registrar materia");
                Console.WriteLine("3) Registrar alumno en materia");
                Console.WriteLine("4) Dar de baja alumno en una materia");
                Console.WriteLine("5) Mostrar informacion de alumno");
                Console.WriteLine("6) Mostrar informacion de materia");
                Console.WriteLine("7) Borrar alumno");
                Console.WriteLine("8) Borrar materia");
                Console.WriteLine("9) Salir del programa");
                Console.Write("Escoja una opcion: ");

                datosIngresados = Console.ReadLine();
                datosIngresados = datosIngresados + " ";

                switch (datosIngresados.Substring(0, 1)) {
                    case "1":
                        Console.Clear();
                        bool sinEspacioAlumnos = true;
                        bool dniNoEsNumero = false;

                        for (int a = 0; a < cantidadAlumnos; a++) {
                            // Nos aseguramos de que este espacio esté nulo
                            if (registroAlumnos[a].apellido == null &&
                                registroAlumnos[a].nombre == null &&
                                registroAlumnos[a].dni == null) {
                                sinEspacioAlumnos = false;

                                // Escribimos en este espacio vacio
                                Console.Write("Ingrese apellido del alumno: ");
                                datosIngresados = Console.ReadLine();
                                if (datosIngresados.Length < 1) {
                                    Console.WriteLine("El apellido no puede ir vacio.");
                                    Console.WriteLine("Presione ENTER para continuar...");
                                    Console.ReadLine();
                                    break;
                                }
                                registroAlumnos[a].apellido = datosIngresados;
                                Console.Write("Ingrese nombre del alumno: ");
                                datosIngresados = Console.ReadLine();
                                if (datosIngresados.Length < 1) {
                                    Console.WriteLine("El nombre no puede ir vacio.");
                                    Console.WriteLine("Presione ENTER para continuar...");
                                    Console.ReadLine();
                                    break;
                                }
                                registroAlumnos[a].nombre = datosIngresados;
                                Console.Write("Ingrese DNI del alumno: ");
                                datosIngresados = Console.ReadLine();
                                if (datosIngresados.Length < 1) {
                                    Console.WriteLine("El DNI no puede ir vacio.");
                                    Console.WriteLine("Presione ENTER para continuar...");
                                    Console.ReadLine();
                                    break;
                                }
                                foreach (char caracter in datosIngresados) {
                                    if(Char.IsDigit(caracter) == false) {
                                        dniNoEsNumero = true;
                                    }
                                }
                                if (dniNoEsNumero) {
                                    Console.WriteLine("El DNI solo puede estar compuesto de numeros.");
                                    Console.WriteLine("Presione ENTER para continuar...");
                                    Console.ReadLine();
                                    break;
                                }
                                registroAlumnos[a].dni = datosIngresados;
                                // Inicializamos el array de las materias
                                registroAlumnos[a].materias = new Materia[cantidadMateriasPorAlumno];

                                Console.Clear();
                                Console.WriteLine("Alumno registrado exitosamente!");
                                Console.WriteLine("Presione ENTER para continuar...");
                                Console.ReadLine();
                                break;
                            }
                        }
                        if (sinEspacioAlumnos) {
                            Console.WriteLine("El registro de alumnos está lleno.");
                            Console.WriteLine("Presione ENTER para continuar...");
                            Console.ReadLine();
                        }
                        break;
                    case "2":
                        Console.Clear();
                        bool sinEspacioMaterias = true;

                        for (int b = 0; b < cantidadAlumnos; b++) {
                            // Nos aseguramos de que este espacio esté nulo
                            if (registroMaterias[b].nombreMateria == null &&
                                registroMaterias[b].modalidadAnio == null) {
                                sinEspacioMaterias = false;

                                // Escribimos en este espacio vacio
                                Console.Write("Ingrese nombre de la materia: ");
                                datosIngresados = Console.ReadLine();
                                if (datosIngresados.Length < 1) {
                                    Console.WriteLine("El nombre de la materia no puede ir vacio.");
                                    break;
                                }
                                registroMaterias[b].nombreMateria = datosIngresados;

                                Console.Write("Ingrese modalidad y año: ");
                                datosIngresados = Console.ReadLine();
                                if (datosIngresados.Length < 1) {
                                    Console.WriteLine("La modalidad y año no pueden ir vacias.");
                                }
                                registroMaterias[b].modalidadAnio = datosIngresados;
                                Console.Clear();
                                Console.WriteLine("Materia registrada exitosamente!");
                                Console.WriteLine("Presione ENTER para continuar...");
                                Console.ReadLine();
                                break;
                            }
                        }
                        if (sinEspacioMaterias) {
                            Console.WriteLine("El registro de materias está lleno.");
                            Console.WriteLine("Presione ENTER para continuar...");
                            Console.ReadLine();
                        }
                        break;
                    case "3":
                        bool sinAlumnos = true;
                        bool sinMaterias = true;
                        bool cantMateriasMaxima = true;
                        bool yaInscripto = false;
                        int idAlumnoParaInscribir = 0;
                        int idMateriaParaInscribir = 0;
                        Console.Clear();
                        Console.WriteLine("Seleccione alumno:");
                        for (int c = 0; c < cantidadAlumnos; c++) {
                            if (registroAlumnos[c].apellido == null &&
                                registroAlumnos[c].nombre == null &&
                                registroAlumnos[c].dni == null) {
                                continue;
                            }
                            sinAlumnos = false;
                            Console.WriteLine((c+1) + ") " +
                                registroAlumnos[c].apellido + ", " +
                                registroAlumnos[c].nombre + " (" +
                                registroAlumnos[c].dni + ")");
                        }
                        if (sinAlumnos) {
                            Console.WriteLine("No hay alumnos para mostrar!");
                            Console.WriteLine("Presione ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }
                        Console.Write("Elija una opcion: ");
                        idAlumnoParaInscribir = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (registroAlumnos[idAlumnoParaInscribir].apellido == null ||
                            registroAlumnos[idAlumnoParaInscribir].nombre == null ||
                            registroAlumnos[idAlumnoParaInscribir].dni == null) {
                            Console.Clear();
                            Console.WriteLine("El alumno solicitado no existe!");
                            Console.WriteLine("Presione ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }

                        // Ya con el alumno seleccionado seleccionamos entonces de las materias registradas
                        Console.Clear();
                        Console.WriteLine("Seleccione materia donde inscribir:");

                        for (int d = 0; d < cantidadMaterias; d++) {
                            if (registroMaterias[d].nombreMateria == null &&
                                registroMaterias[d].modalidadAnio == null) {
                                continue;
                            }
                            sinMaterias = false;
                            Console.WriteLine((d + 1) + ") " +
                                registroMaterias[d].nombreMateria + " " +
                                registroMaterias[d].modalidadAnio);
                        }
                        if (sinMaterias) {
                            Console.WriteLine("No hay materias para mostrar!");
                            Console.WriteLine("Presione ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }

                        Console.Write("Elija una opcion: ");
                        idMateriaParaInscribir = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (registroMaterias[idMateriaParaInscribir].nombreMateria == null ||
                            registroMaterias[idMateriaParaInscribir].modalidadAnio == null) {
                            Console.Clear();
                            Console.WriteLine("La materia solicitada no existe!");
                            Console.WriteLine("Presione ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }

                        // Buscamos entre las materias ya inscriptas por si ya estamos en ella
                        foreach (Materia materia in registroAlumnos[idAlumnoParaInscribir].materias) {
                            if (materia.nombreMateria == registroMaterias[idMateriaParaInscribir].nombreMateria ||
                                materia.modalidadAnio == registroMaterias[idMateriaParaInscribir].modalidadAnio) {
                                yaInscripto = true;
                                Console.Clear();
                                Console.WriteLine("Ya estas inscripto en esta materia!");
                                Console.WriteLine("Presione ENTER para continuar...");
                                Console.ReadLine();
                            }
                        }
                        if (yaInscripto) { break; }
                        for(int e = 0; e < cantidadMateriasPorAlumno; e++) {
                            // Buscamos un espacio disponible entre las materias inscriptas por el alumno
                            if (registroAlumnos[idAlumnoParaInscribir].materias[e].nombreMateria == null &&
                                registroAlumnos[idAlumnoParaInscribir].materias[e].modalidadAnio == null) {
                                cantMateriasMaxima = false;
                                registroAlumnos[idAlumnoParaInscribir].materias[e] = registroMaterias[idMateriaParaInscribir];

                                Console.Clear();
                                Console.WriteLine("Inscripcion exitosa!");
                                Console.WriteLine("Presione ENTER para continuar...");
                                Console.ReadLine();
                                break;
                            }
                        }
                        if(cantMateriasMaxima) {
                            Console.WriteLine("No se puede inscribir a mas materias!");
                            Console.WriteLine("Presione ENTER para continuar...");
                            Console.ReadLine();
                        }
                        break;
                    case "4":
                        bool sinAlumnosBaja = true;
                        bool sinMateriasBaja = true;
                        int idAlumnoParaBaja = 0;
                        int idMateriaParaBaja = 0;
                        Console.Clear();
                        Console.WriteLine("Seleccione alumno:");
                        for (int c = 0; c < cantidadAlumnos; c++) {
                            if (registroAlumnos[c].apellido == null &&
                                registroAlumnos[c].nombre == null &&
                                registroAlumnos[c].dni == null) {
                                continue;
                            }
                            sinAlumnosBaja = false;
                            Console.WriteLine((c + 1) + ") " +
                                registroAlumnos[c].apellido + ", " +
                                registroAlumnos[c].nombre + " (" +
                                registroAlumnos[c].dni + ")");
                        }
                        if (sinAlumnosBaja) {
                            Console.WriteLine("No hay alumnos para mostrar!");
                            Console.WriteLine("Presione ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }
                        Console.Write("Elija una opcion: ");
                        idAlumnoParaBaja = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (registroAlumnos[idAlumnoParaBaja].apellido == null ||
                            registroAlumnos[idAlumnoParaBaja].nombre == null ||
                            registroAlumnos[idAlumnoParaBaja].dni == null) {
                            Console.Clear();
                            Console.WriteLine("El alumno solicitado no existe!");
                            Console.WriteLine("Presione ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }

                        // Ya con el alumno seleccionado seleccionamos entonces de las materias registradas
                        Console.Clear();
                        Console.WriteLine("Seleccione materia a dar de baja:");

                        for (int f = 0; f < cantidadMateriasPorAlumno; f++) {
                            if (registroAlumnos[idAlumnoParaBaja].materias[f].nombreMateria == null &&
                                registroAlumnos[idAlumnoParaBaja].materias[f].modalidadAnio == null) {
                                continue;
                            }
                            sinMateriasBaja = false;
                            Console.WriteLine((f + 1) + ") " +
                                registroAlumnos[idAlumnoParaBaja].materias[f].nombreMateria + " " +
                                registroAlumnos[idAlumnoParaBaja].materias[f].modalidadAnio);
                        }
                        if (sinMateriasBaja) {
                            Console.WriteLine("No hay materias para mostrar!");
                            Console.WriteLine("Presione ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }

                        Console.Write("Elija una opcion: ");
                        idMateriaParaBaja = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (registroAlumnos[idAlumnoParaBaja].materias[idMateriaParaBaja].nombreMateria == null ||
                            registroAlumnos[idAlumnoParaBaja].materias[idMateriaParaBaja].modalidadAnio == null) {
                            Console.Clear();
                            Console.WriteLine("La materia solicitada no existe!");
                            Console.WriteLine("Presione ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }

                        // "Borrar" la materia dejando como nulas sus propiedades
                        // (Aparentemente así es como C# define algo como no-existente)
                        registroAlumnos[idAlumnoParaBaja].materias[idMateriaParaBaja].nombreMateria = null;
                        registroAlumnos[idAlumnoParaBaja].materias[idMateriaParaBaja].modalidadAnio = null;

                        Console.Clear();
                        Console.WriteLine("Baja exitosa!");
                        Console.WriteLine("Presione ENTER para continuar...");
                        Console.ReadLine();
                        break;
                    case "5":
                        bool sinAlumnosParaMostrar = true;
                        int idAlumnoParaMostrar = 0;
                        Console.Clear();
                        Console.WriteLine("Seleccione alumno:");
                        for (int c = 0; c < cantidadAlumnos; c++) {
                            if (registroAlumnos[c].apellido == null &&
                                registroAlumnos[c].nombre == null &&
                                registroAlumnos[c].dni == null) {
                                continue;
                            }
                            sinAlumnosParaMostrar = false;
                            Console.WriteLine((c + 1) + ") " +
                                registroAlumnos[c].apellido + ", " +
                                registroAlumnos[c].nombre + " (" +
                                registroAlumnos[c].dni + ")");
                        }
                        if (sinAlumnosParaMostrar) {
                            Console.WriteLine("No hay alumnos para mostrar!");
                            Console.WriteLine("Presione ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }
                        Console.Write("Elija una opcion: ");
                        idAlumnoParaMostrar = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (registroAlumnos[idAlumnoParaMostrar].apellido == null ||
                            registroAlumnos[idAlumnoParaMostrar].nombre == null ||
                            registroAlumnos[idAlumnoParaMostrar].dni == null) {
                            Console.Clear();
                            Console.WriteLine("El alumno solicitado no existe!");
                            Console.WriteLine("Presione ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }
                        Console.Clear();
                        Console.WriteLine("Apellido del alumno: " + registroAlumnos[idAlumnoParaMostrar].apellido);
                        Console.WriteLine("Nombre del alumno: " + registroAlumnos[idAlumnoParaMostrar].nombre);
                        Console.WriteLine("DNI del alumno: " + registroAlumnos[idAlumnoParaMostrar].dni);
                        Console.WriteLine();
                        Console.WriteLine("Presione ENTER para continuar...");
                        Console.ReadLine();
                        break;
                    case "6":
                        bool sinMateriasParaMostrar = true;
                        int idMateriaParaMostrar = 0;
                        Console.Clear();
                        Console.WriteLine("Seleccione materia:");
                        for (int c = 0; c < cantidadMaterias; c++) {
                            if (registroMaterias[c].nombreMateria == null &&
                                registroMaterias[c].modalidadAnio == null) {
                                continue;
                            }
                            sinMateriasParaMostrar = false;
                            Console.WriteLine((c + 1) + ") " +
                                registroMaterias[c].nombreMateria + ", " +
                                registroMaterias[c].modalidadAnio);
                        }
                        if (sinMateriasParaMostrar) {
                            Console.WriteLine("No hay materias para mostrar!");
                            Console.WriteLine("Presione ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }
                        Console.Write("Elija una opcion: ");
                        idMateriaParaMostrar = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (registroMaterias[idMateriaParaMostrar].nombreMateria == null ||
                            registroMaterias[idMateriaParaMostrar].modalidadAnio == null) {
                            Console.Clear();
                            Console.WriteLine("La materia solicitada no existe!");
                            Console.WriteLine("Presione ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }
                        Console.Clear();
                        Console.WriteLine("Nombre de la materia: " + registroMaterias[idMateriaParaMostrar].nombreMateria);
                        Console.WriteLine("Modalidad y año: " + registroMaterias[idMateriaParaMostrar].modalidadAnio);
                        Console.WriteLine();
                        Console.WriteLine("Presione ENTER para continuar...");
                        Console.ReadLine();
                        break;
                    case "7":
                        bool sinAlumnosParaBorrar = true;
                        int idAlumnoParaBorrar = 0;
                        Console.Clear();
                        Console.WriteLine("Seleccione alumno:");
                        for (int c = 0; c < cantidadAlumnos; c++) {
                            if (registroAlumnos[c].apellido == null &&
                                registroAlumnos[c].nombre == null &&
                                registroAlumnos[c].dni == null) {
                                continue;
                            }
                            sinAlumnosParaBorrar = false;
                            Console.WriteLine((c + 1) + ") " +
                                registroAlumnos[c].apellido + ", " +
                                registroAlumnos[c].nombre + " (" +
                                registroAlumnos[c].dni + ")");
                        }
                        if (sinAlumnosParaBorrar) {
                            Console.WriteLine("No hay alumnos para borrar!");
                            Console.WriteLine("Presione ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }
                        Console.Write("Elija una opcion: ");
                        idAlumnoParaBorrar = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (registroAlumnos[idAlumnoParaBorrar].apellido == null ||
                            registroAlumnos[idAlumnoParaBorrar].nombre == null ||
                            registroAlumnos[idAlumnoParaBorrar].dni == null) {
                            Console.Clear();
                            Console.WriteLine("El alumno solicitado no existe!");
                            Console.WriteLine("Presione ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }
                        // Borramos el alumno seteando todos sus atributos como nulos
                        registroAlumnos[idAlumnoParaBorrar].apellido = null;
                        registroAlumnos[idAlumnoParaBorrar].nombre = null;
                        registroAlumnos[idAlumnoParaBorrar].dni = null;

                        Console.Clear();
                        Console.WriteLine("Alumno eliminado exitosamente.");
                        Console.WriteLine("Presione ENTER para continuar...");
                        Console.ReadLine();
                        break;
                    case "8":
                        bool sinMateriasParaBorrar = true;
                        int idMateriaParaBorrar = 0;
                        Console.Clear();
                        Console.WriteLine("Seleccione materia:");
                        for (int c = 0; c < cantidadMaterias; c++) {
                            if (registroMaterias[c].nombreMateria == null &&
                                registroMaterias[c].modalidadAnio == null) {
                                continue;
                            }
                            sinMateriasParaBorrar = false;
                            Console.WriteLine((c + 1) + ") " +
                                registroMaterias[c].nombreMateria + ", " +
                                registroMaterias[c].modalidadAnio);
                        }
                        if (sinMateriasParaBorrar) {
                            Console.WriteLine("No hay materias para borrar!");
                            Console.WriteLine("Presione ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }
                        Console.Write("Elija una opcion: ");
                        idMateriaParaBorrar = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (registroMaterias[idMateriaParaBorrar].nombreMateria == null ||
                            registroMaterias[idMateriaParaBorrar].modalidadAnio == null) {
                            Console.Clear();
                            Console.WriteLine("La materia solicitada no existe!");
                            Console.WriteLine("Presione ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }
                        registroMaterias[idMateriaParaBorrar].nombreMateria = null;
                        registroMaterias[idMateriaParaBorrar].modalidadAnio = null;

                        Console.Clear();
                        Console.WriteLine("Materia borrada exitosamente.");
                        Console.WriteLine("Presione ENTER para continuar...");
                        Console.ReadLine();
                        break;
                    case "9":
                        return;
                    default:
                        break;
                }
            } while(true);
        }
    }
}
