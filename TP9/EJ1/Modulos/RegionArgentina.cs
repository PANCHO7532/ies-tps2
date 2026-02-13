using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ1.Modulos {
    class RegionArgentina: Region, IFecha {
        public RegionArgentina() :
            base() {
        }
        public RegionArgentina(string nombreRegion) :
            base(nombreRegion) {
        }
        public string Formatear(string dia, string mes, string anio) {
            return dia + "/" + mes + "/" + anio;
        }
    }
}
