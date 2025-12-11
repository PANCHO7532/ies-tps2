using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ1.Modulos {
    class Caballo: Animal {
        public Caballo()
            : base() {}
        public Caballo(string nombre, string alimento, int edad, string raza)
            : base(nombre, alimento, edad, raza) {
        }
    }
}
