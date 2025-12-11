using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ3.Modulos {
    class Barco {
        private string matricula;
        private double eslora;
        private int anioFabricacion;
        private bool especial = false;

        public Barco() {}

        public Barco(string matricula, double eslora, int anioFabricacion) {
            setMatricula(matricula);
            setEslora(eslora);
            setAnioFabricacion(anioFabricacion);
        }

        public string getMatricula() { return this.matricula; }
        public double getEslora() { return this.eslora; }
        public int getAnioFabricacion() { return this.anioFabricacion; }
        public bool getEspecial() { return this.especial; }

        public void setMatricula(string matricula) { this.matricula = matricula; }
        public void setEslora(double eslora) { this.eslora = eslora; }
        public void setAnioFabricacion(int anioFabricacion) { this.anioFabricacion = anioFabricacion; }
        public void setEspecial(bool especial) { this.especial = especial; }

        public virtual int getNumeroMastiles() { return 0; }
        public virtual void setNumeroMastiles(int numeroMastiles) { return; }

        public virtual int getPotencia() { return 0; }
        public virtual void setPotencia(int potencia) { return; }

        public virtual int getNumeroCamarotes() { return 0; }
        public virtual void setNumeroCamarotes(int numeroCamarotes) { return; }
    }
}
