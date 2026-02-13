using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ3.Modulos {
    abstract class Material {
        private string codigo;
        private string titulo;

        public Material(string codigo, string titulo) {
            SetCodigo(codigo);
            SetTitulo(titulo);
        }

        public string GetCodigo() { return codigo; }
        public void SetCodigo(string codigo) { this.codigo = codigo; }
        public string GetTitulo() { return titulo; }
        public void SetTitulo(string titulo) { this.titulo = titulo; }

        public abstract string ToString() {
            return "[" + GetCodigo() + "] " + GetTitulo();
        }
    }
}
