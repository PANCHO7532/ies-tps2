using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ3.Modulos {
    class BarcoMotor: Barco {
        int potencia;

        public BarcoMotor()
            : base() {}

        public BarcoMotor(string matricula, double eslora, int anioFabricacion, int potencia)
            : base(matricula, eslora, anioFabricacion) {
            setEspecial(true);
            setPotencia(potencia);
        }

        public override int getPotencia() { return this.potencia; }

        public override void setPotencia(int potencia) { this.potencia = potencia; }
    }
}
