using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ4.Modulos {
    class Prestamo {
        private string fechaPrestamo;
        private string fechaDevolucion;

        private Material material;

        public Prestamo(Material material, string fechaPrestamo, string fechaDevolucion) {
            setMaterial(material);
            setFechaPrestamo(fechaPrestamo);
            setFechaDevolucion(fechaDevolucion);
        }

        public Material getMaterial() { return material; }
        public void setMaterial(Material material) { this.material = material; }

        public string getFechaPrestamo() { return fechaPrestamo; }
        public void setFechaPrestamo(string fechaPrestamo) { this.fechaPrestamo = fechaPrestamo; }

        public string getFechaDevolucion() { return fechaDevolucion; }
        public void setFechaDevolucion(string fechaDevolucion) { this.fechaDevolucion = fechaDevolucion; }
    }
}
