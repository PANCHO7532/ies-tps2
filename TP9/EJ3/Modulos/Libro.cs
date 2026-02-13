using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ3.Modulos {
    class Libro: Material {
        private int numPaginas;

        public Libro(string codigo, string titulo, int numPaginas)
            : base(codigo, titulo) {
            SetNumPaginas(numPaginas);
        }

        public int GetNumPaginas() { return numPaginas; }
        public void SetNumPaginas(int numPaginas) { this.numPaginas = numPaginas; }

        public override string ToString() {
            return "[" + GetCodigo() + "] Libro: " + GetTitulo() + " - Cantidad Paginas: " + GetNumPaginas();
        }
    }
}
