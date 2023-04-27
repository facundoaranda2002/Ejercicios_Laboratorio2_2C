using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Kelvin
    {
        private double grados;

        public Kelvin(double grados)
        {
            this.grados = grados;
        }

        public double GetGrados()
        {
            return this.grados;
        }

        public static implicit operator Kelvin(double grados)
        {
            return new Kelvin(grados);
        }

        public static explicit operator Celsius(Kelvin kelvin)
        {
            return (Celsius)((Fahrenheit)kelvin);
        }

        public static explicit operator Fahrenheit(Kelvin kelvin)
        {
            return new Fahrenheit(Math.Round((((kelvin.grados * 9) / 5) - 459.67), 2));
        }

        public static bool operator ==(Kelvin k, Kelvin k2)
        {
            return k.grados == k2.grados;
        }

        public static bool operator !=(Kelvin k, Kelvin k2)
        {
            return !(k == k2);
        }

        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return k.grados == ((Kelvin)f).grados;
        }

        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == f);
        }

        public static bool operator ==(Kelvin k, Celsius c)
        {
            return k.grados == ((Kelvin)c).grados;
        }

        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k == c);
        }

        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(Math.Round((k.grados + ((Kelvin)f).grados), 2));
        }

        public static Kelvin operator +(Kelvin k, Celsius c)
        {
            return new Kelvin(Math.Round((k.grados + ((Kelvin)c).grados), 2));
        }

        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(Math.Round((k.grados - ((Kelvin)f).grados), 2));
        }

        public static Kelvin operator -(Kelvin k, Celsius c)
        {
            return new Kelvin(Math.Round((k.grados - ((Kelvin)c).grados), 2));
        }
    }
}
