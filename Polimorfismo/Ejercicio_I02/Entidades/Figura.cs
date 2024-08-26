namespace Entidades
{
    public abstract class Figura
    {
        public virtual string Dibujar()
        {
            return "Dibujando Forma...";
        }

        public abstract double CalcularSuperficie();

        public abstract double CalcularPerimetro();

    }
}