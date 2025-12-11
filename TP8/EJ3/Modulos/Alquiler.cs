using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ3.Modulos {
    class Alquiler {
        private string nombre, dni, fechaAlquiler, fechaDevolucion, posicionAmarre;
        private Barco barco;

        public Alquiler() {}

        public Alquiler(string nombre, string dni, string fechaAlquiler, string fechaDevolucion, string posicionAmarre, Barco barco) {
            setNombre(nombre);
            setDni(dni);
            setFechaAlquiler(fechaAlquiler);
            setFechaDevolcuion(fechaDevolucion);
            setPosicionAmarre(posicionAmarre);
            setBarco(barco);
        }

        public string getNombre() { return this.nombre; }
        public string getDni() { return this.dni; }
        public string getFechaAlquiler() { return this.fechaAlquiler; }
        public string getFechaDevolucion() { return this.fechaDevolucion; }
        public string getPosicionAmarre() { return this.posicionAmarre; }
        public Barco getBarco() { return this.barco; }

        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setDni(string dni) { this.dni = dni; }
        public void setFechaAlquiler(string fechaAlquiler) { this.fechaAlquiler = fechaAlquiler; }
        public void setFechaDevolcuion(string fechaDevolucion) { this.fechaDevolucion = fechaDevolucion; }
        public void setPosicionAmarre(string posicionAmarre) { this.posicionAmarre = posicionAmarre; }
        public void setBarco(Barco barco) { this.barco = barco; }

        private double fechaANumero(string fecha) {
            // Basado en absolutamente nada
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
        public double calcularAlquiler() {
            double fechaAlquiler = fechaANumero(getFechaAlquiler());
            double fechaDevolucion = fechaANumero(getFechaDevolucion());
            double valorModulo = getBarco().getEslora() * 10;
            int cantidadDias = Convert.ToInt32((fechaDevolucion - fechaAlquiler) / 8640);

            if (getBarco().getEspecial()) {
                valorModulo = valorModulo + getBarco().getNumeroMastiles();
                valorModulo = valorModulo + getBarco().getPotencia();
                valorModulo = valorModulo + getBarco().getNumeroCamarotes();
            }

            return cantidadDias * valorModulo;
        }
    }
}
