using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Motocross : VehiculoDeCarrera
    {
        private short cilindrada;

        public Motocross(string escuderia, short numero) : base(escuderia, numero)
        {
        }

        public Motocross(short cilindrada, string escuderia, short numero) : this(escuderia, numero)
        {
            this.cilindrada = cilindrada;
        }

        public static bool operator ==(Motocross a, Motocross b)
        {
            return (VehiculoDeCarrera)a == (VehiculoDeCarrera)b && a.cilindrada == b.cilindrada;//si no fuera hijo no podria castearlo tan facilmente
        }

        public static bool operator !=(Motocross a, Motocross b)
        {
            return !(a == b);
        }

        public new string MostrarDatos()//con el new anulo el metodo heredado y asi lo genera como si fuera un metodo nuevo pero solo lo haremos por hay ya que mañana veremos polimorfismo, hacemos esto para quitar el warning
        {
            return "Soy una Moto";
        }
    }
}
