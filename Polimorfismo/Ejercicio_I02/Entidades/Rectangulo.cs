using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rectangulo : Figura
    {
        private double xBase;
        private double yAltura;

        public double XBase { get => xBase; set => xBase = value; }
        public double YAltura { get => yAltura; set => yAltura = value; }

        public Rectangulo(double xBase, double yAltura)
        {
            this.XBase = xBase;
            this.YAltura = yAltura;
        }

        public override string Dibujar()
        {
            return "Dibujando Rectangulo";
        }

        public override double CalcularSuperficie()
        {
            return this.XBase * this.YAltura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * this.XBase + 2 * this.YAltura;
        }
    }
}
