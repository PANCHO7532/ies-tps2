using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EJ4.Modulos;

namespace EJ4 {
    class Program {
        static void Main(string[] args) {
            string eleccion;
            Usuario[] usuarios = new Usuario[20];
            Material[] materiales = new Material[20];

            while (true) {
                Console.Clear();
                Console.WriteLine("1) Mostrar usuarios");
                Console.WriteLine("2) Mostrar materiales");
                Console.WriteLine("3) Mostrar prestamos");
                Console.WriteLine("4) Agregar usuarios");
                Console.WriteLine("5) Agregar material");
                Console.WriteLine("6) Agregar prestamo");
                Console.WriteLine("7) Borrar usuarios");
                Console.WriteLine("8) Borrar material");
                Console.WriteLine("9) Borrar prestamo");
                Console.WriteLine("0) Salir del programa");
                Console.Write("Escoja una opcion: ");
                eleccion = Console.ReadLine();

                if (eleccion.Length > 1 || eleccion.Length <= 0) {
                    Console.Write("Opcion invalida, presione ENTER para continuar: ");
                    Console.ReadLine();
                    continue;
                }
                if(eleccion[0] < '0' || eleccion[0] > '9') {
                    Console.Write("Opcion invalida, presione ENTER para continuar: ");
                    Console.ReadLine();
                    continue;
                }
                /*if (Convert.ToInt32(eleccion) > 4) {
                    Console.Write("Opcion invalida, presione ENTER para salir: ");
                    Console.ReadLine();
                    return;
                }*/

                //// Temporales usuario
                string tempDNI, tempNombre, tempDireccion, tempTelefono, tempNumeroUsuario;
                Usuario usuario;

                //// Temporales material
                // Generico materiales
                string tempCodigo, tempTitulo, tempNumeroMaterial, tempTipo;
                // Libros
                int tempPaginas;
                // Peliculas
                int tempAnyo;
                string tempDirector;
                Material material = null;

                //// Temporales prestamo
                string tempFechaPrestamo, tempFechaDevolucion, tempNumeroPrestamo;
                Prestamo prestamo = null;

                switch (Convert.ToInt32(eleccion)) {
                    case 1:
                        // Mostrar usuarios
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
                        // Mostrar materiales
                        bool noHayMateriales = true;
                        Console.Clear();
                        Console.WriteLine("------------------------------");
                        for (int a = 0; a < materiales.Length; a++) {
                            if (materiales[a] == null) { continue; }
                            noHayMateriales = false;
                            Console.WriteLine((a + 1) + ") " + materiales[a].ToString());
                            Console.WriteLine("------------------------------");
                        }
                        if (noHayMateriales) {
                            Console.WriteLine("No hay materiales para mostrar.");
                            Console.WriteLine("------------------------------");
                        }
                        Console.Write("Presione ENTER para continuar: ");
                        Console.ReadLine();
                        break;
                    case 3:
                        // Mostrar prestamos (de todos los usuarios)
                        //// Todos los prestamos están almacenados dentro del usuario
                        //// Todos los materiales prestados estan almacenados dentro del prestamo
                        bool noHayUsuarios2 = true;
                        bool noHayPrestamos = true;
                        Console.Clear();
                        Console.WriteLine("------------------------------");
                        for (int a = 0; a < usuarios.Length; a++) {
                            if (usuarios[a] == null) { continue; }
                            noHayUsuarios2 = false;
                            Console.WriteLine("Prestamos del usuario: " + usuarios[a].GetNombre() + " - DNI: " + usuarios[a].GetDni());
                            Console.WriteLine();
                            Prestamo[] prestamosUsuario = usuarios[a].GetPrestamos();
                            for (int b = 0; b < prestamosUsuario.Length; b++) {
                                if(prestamosUsuario[b] == null) { continue; } // no hay prestamo, skipeo
                                noHayPrestamos = false;
                                Console.WriteLine((b + 1) + ") " + prestamosUsuario[b].getMaterial().ToString());
                                Console.WriteLine("===> Fecha prestamo: " + prestamosUsuario[b].getFechaPrestamo());
                                Console.WriteLine("===> Fecha devolucion: " + prestamosUsuario[b].getFechaDevolucion());
                                Console.WriteLine();
                            }
                            if (noHayPrestamos) {
                                Console.WriteLine("No hay prestamos.");
                                Console.WriteLine("------------------------------");
                            } else {
                                Console.WriteLine("------------------------------");
                            }
                            noHayPrestamos = true;
                        }
                        if (noHayUsuarios2) {
                            Console.WriteLine("No hay usuarios registrados.");
                            Console.WriteLine("------------------------------");
                        }
                        Console.Write("Presione ENTER para continuar: ");
                        Console.ReadLine();
                        break;
                    case 4:
                        // Agregar usuario
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
                    case 5:
                        // Agregar material
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
                    case 6:
                        // Agregar prestamo (a un usuario)
                        //// Tanto usuarios como materiales deben de existir y tener algo de datos para operar
                        //// Un poco de copy-paste a las operaciones de validacion en eliminaciones y probablemente nada estalle
                        bool noHayEspacioPrestamos = true;
                        bool yaEstaPrestado = false;
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
                        usuario = usuarios[Convert.ToInt32(tempNumeroUsuario) - 1];
                        // Chequear si existe
                        if (usuario == null) {
                            // No existe, fuera
                            Console.Write("Usuario invalido, presione ENTER para continuar: ");
                            Console.ReadLine();
                            break;
                        }

                        // Verificacion de material
                        Console.Write("Ingrese numero/posicion del material: ");
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
                        material = materiales[Convert.ToInt32(tempNumeroMaterial) - 1];
                        // Chequear si existe el material
                        if (material == null) {
                            // Inexistente, fuera
                            Console.Write("Material invalido, presione ENTER para continuar: ");
                            Console.ReadLine();
                            break;
                        }

                        // Chequear si ya prestamos este material a este usuario
                        Prestamo[] prestamosUsuarioElegido = usuario.GetPrestamos();
                        for (int a = 0; a < prestamosUsuarioElegido.Length; a++) {
                            if (prestamosUsuarioElegido[a] == null) { continue; }
                            if (prestamosUsuarioElegido[a].getMaterial().GetCodigo().Equals(material.GetCodigo())) {
                                yaEstaPrestado = true;
                                break;
                            }
                        }
                        // Chequear si ya prestamos este material a otro usuario
                        for (int b = 0; b < usuarios.Length; b++) {
                            if (usuarios[b] == null) { continue; }
                            Prestamo[] prestamosUsuarioTemp = usuarios[b].GetPrestamos();
                            for (int c = 0; c < prestamosUsuarioTemp.Length; c++) {
                                if (prestamosUsuarioTemp[c] == null) { continue; }
                                if (prestamosUsuarioTemp[c].getMaterial().GetCodigo().Equals(material.GetCodigo())) {
                                    yaEstaPrestado = true;
                                    break;
                                }
                            }
                        }
                        if (yaEstaPrestado) {
                            Console.Clear();
                            Console.WriteLine("Este material ya está prestado.");
                            Console.Write("Presione ENTER para continuar: ");
                            Console.ReadLine();
                            break;
                        }

                        // Preguntar datos del prestamo
                        Console.Write("Ingrese fecha de prestamo: ");
                        tempFechaPrestamo = Console.ReadLine();

                        Console.Write("Ingrese fecha de devolucion: ");
                        tempFechaDevolucion = Console.ReadLine();

                        // Ahora que ya tenemos todo hacemos la relacion
                        for (int d = 0; d < prestamosUsuarioElegido.Length; d++) {
                            // Buscamos espacio libre
                            if (prestamosUsuarioElegido[d] != null) { continue; }
                            noHayEspacioPrestamos = false;
                            // Creamos un prestamo
                            prestamo = new Prestamo(material, tempFechaPrestamo, tempFechaDevolucion);
                            // Asignamos el prestamo en el espacio libre
                            prestamosUsuarioElegido[d] = prestamo;
                            break;
                        }
                        if (noHayEspacioPrestamos) {
                            Console.Clear();
                            Console.WriteLine("El usuario ya tiene demasiados prestamos.");
                            Console.Write("Presione ENTER para continuar: ");
                            Console.ReadLine();
                            break;
                        }
                        Console.Clear();
                        Console.WriteLine("Prestamo agregado!");
                        Console.Write("Presione ENTER para continuar: ");
                        Console.ReadLine();
                        break;
                    case 7:
                        // Borrar usuario
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
                    case 8:
                        // Borrar material
                        Console.Clear();
                        Console.Write("Ingrese numero/posicion del material: ");
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
                    case 9:
                        // Borrar prestamo
                        //// Hay que verificar basicamente si el usuario existe, y si el prestamo por posicion está ahi
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
                        usuario = usuarios[Convert.ToInt32(tempNumeroUsuario) - 1];
                        // Chequear si existe
                        if (usuario == null) {
                            // No existe, fuera
                            Console.Write("Usuario invalido, presione ENTER para continuar: ");
                            Console.ReadLine();
                            break;
                        }

                        // Verificacion de prestamo
                        Prestamo[] prestamosUsuario2 = usuario.GetPrestamos();
                        Console.Write("Ingrese numero/posicion del prestamo: ");
                        tempNumeroPrestamo = Console.ReadLine();
                        if ((tempNumeroPrestamo[0] < '1' || tempNumeroPrestamo[0] > '9')) {
                            Console.Write("Prestamo invalido, presione ENTER para continuar: ");
                            Console.ReadLine();
                            break;
                        }
                        if (Convert.ToInt32(tempNumeroPrestamo) > prestamosUsuario2.Length) {
                            Console.Write("Prestamo invalido, presione ENTER para continuar: ");
                            Console.ReadLine();
                            break;
                        }
                        if (Convert.ToInt32(tempNumeroPrestamo) == 0) {
                            Console.Write("Prestamo invalido, presione ENTER para continuar: ");
                            Console.ReadLine();
                            break;
                        }
                        prestamo = prestamosUsuario2[Convert.ToInt32(tempNumeroPrestamo) - 1];
                        // Chequear si existe el prestamo
                        if (prestamo == null) {
                            // Inexistente, fuera
                            Console.Write("Prestamo invalido, presione ENTER para continuar: ");
                            Console.ReadLine();
                            break;
                        }
                        // borrar el prestamo
                        prestamosUsuario2[Convert.ToInt32(tempNumeroPrestamo) - 1] = null;
                        Console.Clear();
                        Console.WriteLine("Prestamo eliminado!");
                        Console.Write("Presione ENTER para continuar: ");
                        Console.ReadLine();
                        break;
                    case 0:
                        // Salir del programa
                        return;
                }
            }
        }
    }
}
