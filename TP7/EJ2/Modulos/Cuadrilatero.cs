using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ2.Modulos {
    class Cuadrilatero {
        private float largo;
        private float alto;

        public Cuadrilatero(float _largo, float _alto) {
            largo = _largo;
            alto = _alto;
        }
        public float getLargo() {
            return largo;
        }
        public float getAlto() {
            return alto;
        }
        public void setLargo(float _largo) {
            largo = _largo;
        }
        public void setAlto(float _alto) {
            alto = _alto;
        }
        public float calcularPerimetro() {
            return (2 * largo) + (2 * alto);
        }
        public float calcularArea() {
            return largo * alto;
        }
        public bool esUnCuadrado() {
            return largo == alto;
        }
    }
}
