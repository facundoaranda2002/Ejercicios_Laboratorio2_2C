using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Celsius
    {
        private double grados;

        public Celsius(double grados)
        {
            this.grados = grados;
        }

        public double GetGrados()
        {
            return this.grados;
        }

        public static implicit operator Celsius(double grados)
        {
            return new Celsius(grados);
        }

        public static explicit operator Fahrenheit(Celsius celsius)
        {
            return new Fahrenheit(Math.Round((((celsius.grados * 9) / 5) + 32), 2));
        }

        public static explicit operator Kelvin(Celsius celsius)
        {
            return (Kelvin)((Fahrenheit)celsius);
        }

        public static bool operator ==(Celsius c, Celsius c2)
        {
            return c.grados == c2.grados;
        }

        public static bool operator !=(Celsius c, Celsius c2)
        {
            return !(c == c2);
        }

        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            return c.grados == ((Celsius)f).grados;
        }

        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c == f);
        }

        public static bool operator ==(Celsius c, Kelvin k)
        {
            return c.grados == ((Celsius)k).grados;
        }

        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == k);
        }

        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            return new Celsius(Math.Round((c.grados + ((Celsius)f).grados), 2));
        }

        public static Celsius operator +(Celsius c, Kelvin k)
        {
            return new Celsius(Math.Round((c.grados + ((Celsius)k).grados), 2));
        }

        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            return new Celsius(Math.Round((c.grados - ((Celsius)f).grados), 2));
        }

        public static Celsius operator -(Celsius c, Kelvin k)
        {
            return new Celsius(Math.Round((c.grados - ((Celsius)k).grados), 2));
        }
    }
}
