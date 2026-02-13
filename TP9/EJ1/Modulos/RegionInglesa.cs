using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ1.Modulos {
    class RegionInglesa : Region, IFecha {
        public RegionInglesa() :
            base() {
        }
        public RegionInglesa(string nombreRegion) :
            base(nombreRegion) {
        }
        public string Formatear(string dia, string mes, string anio) {
            return mes + "/" + dia + "/" + anio;
        }
    }
}
