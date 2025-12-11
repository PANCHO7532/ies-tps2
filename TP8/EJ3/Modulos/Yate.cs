using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ3.Modulos {
    class Yate: BarcoMotor {
        int numeroCamarotes;

        public Yate()
            : base() {}

        public Yate(string matricula, double eslora, int anioFabricacion, int potencia, int numeroCamarotes)
            : base(matricula, eslora, anioFabricacion, potencia) {
            setEspecial(true);
            setNumeroCamarotes(numeroCamarotes);
        }

        public override int getNumeroCamarotes() { return this.numeroCamarotes; }

        public override void setNumeroCamarotes(int numeroCamarotes) { this.numeroCamarotes = numeroCamarotes; }
    }
}
