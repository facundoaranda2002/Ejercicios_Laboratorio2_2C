using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Circulo : Figura
    {
        private double radio;

        public double Radio { get => radio; set => radio = value; }

        public Circulo(double radio)
        {
            this.Radio = radio;
        }

        public override string Dibujar()
        {
            return "Dibujando Circulo";
        }

        public override double CalcularSuperficie()
        {
            return Math.PI * Math.Pow(this.Radio, 2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * this.Radio;
        }
    }
}
