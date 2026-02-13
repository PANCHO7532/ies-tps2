using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ3.Modulos {
    class Pelicula: Material {
        private int anyoEstreno;
        private string director;

        public Pelicula(string codigo, string titulo, int anyoEstreno, string director)
            : base(codigo, titulo) {
            SetAnyoEstreno(anyoEstreno);
            SetDirector(director);
        }

        public int GetAnyoEstreno() { return anyoEstreno; }
        public void SetAnyoEstreno(int anyoEstreno) { this.anyoEstreno = anyoEstreno; }

        public string GetDirector() { return director; }
        public void SetDirector(string director) { this.director = director; }

        public override string ToString() {
            return "[" + GetCodigo() + "] Pelicula: " + GetTitulo() + " - Director: " + GetDirector() + " - Año: " + GetAnyoEstreno();
        }
    }
}
