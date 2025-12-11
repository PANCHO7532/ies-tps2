using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ1.Modulos {
    class Perro: Animal {
        public Perro()
            : base() {}
        public Perro(string nombre, string alimento, int edad, string raza)
            : base(nombre, alimento, edad, raza) {
        }
    }
}
