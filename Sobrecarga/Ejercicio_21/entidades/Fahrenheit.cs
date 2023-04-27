using System.Drawing;

namespace Entidades
{
    public class Fahrenheit
    {
        private double grados;

        public Fahrenheit(double grados)
        {
            this.grados = grados;
        }

        public double GetGrados()
        {
            return this.grados;
        }

        public static implicit operator Fahrenheit(double grados)
        {
            return new Fahrenheit(grados);
        }

        public static explicit operator Celsius(Fahrenheit fahrenheit)
        {
            return new Celsius(Math.Round((((fahrenheit.grados - 32) * 5) / 9), 2));
        }

        public static explicit operator Kelvin(Fahrenheit fahrenheit)
        {
            return new Kelvin(Math.Round((((fahrenheit.grados + 459.67) * 5) / 9), 2));
        }

        public static bool operator ==(Fahrenheit f, Fahrenheit f2)
        {
            return f.grados == f2.grados;
        }

        public static bool operator !=(Fahrenheit f, Fahrenheit f2)
        {
            return !(f == f2);
        }

        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            return f.grados == ((Fahrenheit)c).grados;
        }

        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !(f == c);
        }

        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            return f.grados == ((Fahrenheit)k).grados;
        }

        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f == k);
        }

        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(Math.Round((f.grados + ((Fahrenheit)c).grados), 2));
        }

        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(Math.Round((f.grados + ((Fahrenheit)k).grados), 2));
        }

        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(Math.Round((f.grados - ((Fahrenheit)c).grados), 2));
        }

        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(Math.Round((f.grados - ((Fahrenheit)k).grados), 2));
        }

    }
}