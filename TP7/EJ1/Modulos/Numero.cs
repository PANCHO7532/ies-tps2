using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ1.Modulos {
    class Numero {
        private int numero;

        public Numero(int _numero) {
            numero = _numero;
        }
        public int getNumero() {
            return numero;
        }
        public void setNumero(int _numero) {
            numero = _numero;
        }
        public bool esPar() {
            return numero % 2 == 0;
        }
        public bool esPositivo() {
            return numero >= 0;
        }
        public bool esMultiploDe(int _numero) {
            return numero % _numero == 0;
        }
    }
}
