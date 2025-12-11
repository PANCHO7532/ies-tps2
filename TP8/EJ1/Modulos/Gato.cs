using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ1.Modulos {
    class Gato: Animal {
        public Gato()
            : base() {}
        public Gato(string nombre, string alimento, int edad, string raza)
            : base(nombre, alimento, edad, raza) {
        }
    }
}
