using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Dolar()
        {
            Dolar.cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public static double GetCotizacion()
        {
            return Dolar.cotzRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static implicit operator Dolar(double cantidad)
        {
            return new Dolar(cantidad);
        }

        public static explicit operator Pesos(Dolar dolar)
        {
            return new Pesos(dolar.cantidad * Pesos.GetCotizacion());
        }

        public static explicit operator Euro(Dolar dolar)
        {
            return new Euro(dolar.cantidad * Euro.GetCotizacion());
        }
    }
}
