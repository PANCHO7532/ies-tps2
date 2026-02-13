using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ1 {
    abstract class Region {
        protected string nombreRegion;

        public Region() {
        }

        public Region(string nombreRegion) {
            setNombreRegion(nombreRegion);
        }

        public string getNombreRegion() { return nombreRegion; }
        public void setNombreRegion(string nombreRegion) { this.nombreRegion = nombreRegion; }
    }
}
