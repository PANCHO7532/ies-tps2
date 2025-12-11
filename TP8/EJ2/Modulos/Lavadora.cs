using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ2.Modulos {
    class Lavadora: Electrodomestico {
        private double carga;

        public Lavadora()
            : base() {}

        public Lavadora(double precio, string color, char consumoEnergetico, double peso, double carga)
            : base(precio, color, consumoEnergetico, peso) {
            setCarga(carga);
        }

        public double getCarga() { return carga; }

        public void setCarga(double carga) { this.carga = carga; }

        public override double precioFinal() {
            double precio = base.precioFinal();
            if (getCarga() > 50) { precio = precio + 500; }
            return precio;
        }
    }
}
