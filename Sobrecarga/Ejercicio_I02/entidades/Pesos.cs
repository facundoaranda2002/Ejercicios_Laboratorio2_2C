using System.Runtime.CompilerServices;

namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Pesos()
        {
            Pesos.cotzRespectoDolar = 398;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotzRespectoDolar) : this(cantidad)
        {
            Pesos.cotzRespectoDolar = cotzRespectoDolar;
        }

        public static double GetCotizacion()
        {
            return Pesos.cotzRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static implicit operator Pesos(double cantidad)
        {
            return new Pesos(cantidad);
        }

        public static explicit operator Dolar(Pesos pesos)
        {
            return new Dolar(pesos.cantidad/Pesos.cotzRespectoDolar);
        }

        public static explicit operator Euro(Pesos pesos)
        {
            return (Euro)pesos;
        }

        public static bool operator ==(Pesos p, Pesos p2)
        {
            return p.cantidad == p2.cantidad;
        }

        public static bool operator !=(Pesos p, Pesos p2)
        {
            return !(p == p2);
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            return p.cantidad == ((Pesos)d).cantidad;
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            return p.cantidad == ((Pesos)e).cantidad;
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }


    }
}