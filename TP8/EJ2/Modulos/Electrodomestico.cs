using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ2.Modulos {
    class Electrodomestico {
        private double precio;
        private string color;
        private char consumoEnergetico;
        private double peso;

        public Electrodomestico() {}

        public Electrodomestico(double precio, string color, char consumoEnergetico, double peso) {
            setPrecio(precio);
            comprobarColor(color);
            comprobarConsumoEnergetico(consumoEnergetico);
            setPeso(peso);
        }

        public double getPrecio() { return precio; }
        public string getColor() { return color; }
        public char getConsumoEnergetico() { return consumoEnergetico; }
        public double getPeso() { return peso; }

        public void setPrecio(double precio) { this.precio = precio; }
        public void setColor(string color) { this.color = color; }
        public void setConsumoEnergetico(char consumoEnergetico) { this.consumoEnergetico = consumoEnergetico; }
        public void setPeso(double peso) { this.peso = peso; }

        private void comprobarConsumoEnergetico(char letra) {
            if (letra > 'F' || letra < 'A') {
                setConsumoEnergetico('F');
            } else {
                setConsumoEnergetico(letra);
            }
        }

        private void comprobarColor(string color) {
            switch (color.ToUpper()) {
                case "BLANCO":
                case "NEGRO":
                case "ROJO":
                case "AZUL":
                case "GRIS":
                    setColor(color);
                    break;
                default:
                    setColor("Blanco");
                    break;
            }
        }

        public virtual double precioFinal() {
            double precio = getPrecio();
            // Consumo Energetico
            switch (getConsumoEnergetico()) {
                case 'A':
                    precio = precio + 1000;
                    break;
                case 'B':
                    precio = precio + 800;
                    break;
                case 'C':
                    precio = precio + 600;
                    break;
                case 'D':
                    precio = precio + 500;
                    break;
                case 'E':
                    precio = precio + 300;
                    break;
                case 'F':
                    precio = precio + 100;
                    break;
            }
            // Peso
            if (getPeso() >= 1 && getPeso() <= 19) {
                precio = precio + 100;
            } else if (getPeso() >= 20 && getPeso() <= 49) {
                precio = precio + 500;
            } else if (getPeso() >= 50 && getPeso() <= 79) {
                precio = precio + 800;
            } else {
                precio = precio + 1000;
            }
            return precio;
        }
    }
}
