using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ2.Modulos {
    class Televisor: Electrodomestico {
        private double resolucionPulgadas;
        private bool sintonizadorTDT;

        public Televisor()
            : base() {}

        public Televisor(double precio, string color, char consumoEnergetico, double peso, double resolucionPulgadas, bool sintonizadorTDT)
            : base(precio, color, consumoEnergetico, peso) {
            setResolucionPulgadas(resolucionPulgadas);
            setSintonizadorTDT(sintonizadorTDT);
        }

        public double getResolucionPulgadas() { return resolucionPulgadas; }
        public bool getSintonizadorTDT() { return sintonizadorTDT; }

        public void setResolucionPulgadas(double resolucionPulgadas) { this.resolucionPulgadas = resolucionPulgadas; }
        public void setSintonizadorTDT(bool sintonizadorTDT) { this.sintonizadorTDT = sintonizadorTDT; }

        public override double precioFinal() {
            double precio =  base.precioFinal();
            if (getResolucionPulgadas() > 40) {
                precio = precio + ((precio / 100) * 30);
            }
            if (getSintonizadorTDT()) {
                precio = precio + 500;
            }
            return precio;
        }
    }
}
