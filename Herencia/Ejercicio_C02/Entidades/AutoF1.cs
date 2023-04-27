namespace Entidades
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public AutoF1(string escuderia, short numero) : base(escuderia, numero)
        {
        }

        public AutoF1(short caballosDeFuerza, string escuderia, short numero) : this(escuderia, numero)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        public static bool operator ==(AutoF1 a, AutoF1 b)
        {
            return (VehiculoDeCarrera)a == (VehiculoDeCarrera)b && a.caballosDeFuerza == b.caballosDeFuerza;//si no fuera hijo no podria castearlo
        }

        public static bool operator !=(AutoF1 a, AutoF1 b)
        {
            return !(a==b);
        }

        public new string MostrarDatos()//con el new anulo el metodo heredado y asi lo genera como si fuera un metodo nuevo pero solo lo haremos por hay ya que mañana veremos polimorfismo, hacemos esto para quitar el warning
        {
            return "Soy un AutoF1";
        }


    }
}