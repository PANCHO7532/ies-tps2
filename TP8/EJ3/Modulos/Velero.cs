using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ3.Modulos {
    class Velero: Barco {
        int numeroMastiles;

        public Velero()
            : base() {}

        public Velero(string matricula, double eslora, int anioFabricacion, int numeroMastiles)
            : base(matricula, eslora, anioFabricacion) {
            setEspecial(true);
            setNumeroMastiles(numeroMastiles);
        }

        public override int getNumeroMastiles() { return this.numeroMastiles; }

        public override void setNumeroMastiles(int numeroMastiles) { this.numeroMastiles = numeroMastiles; }
    }
}
