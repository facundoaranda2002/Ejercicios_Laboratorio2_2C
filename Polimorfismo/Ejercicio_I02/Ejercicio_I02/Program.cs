using Entidades;
using System.Text;

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();

            figuras.Add(new Circulo(5));
            figuras.Add(new Cuadrado(3, 3));
            figuras.Add(new Rectangulo(4, 6));

            StringBuilder sb = new StringBuilder();
            int n = 1;
            foreach (Figura f in figuras)
            {
                sb.AppendLine($"=============== FIGURA {n} ==================");
                sb.AppendLine($"Tipo: {f.GetType()}");
                sb.AppendLine(f.Dibujar());
                sb.AppendLine($"Área: {((f.CalcularSuperficie()).ToString("0.00"))}");
                sb.AppendLine($"Perimetro: {((f.CalcularPerimetro()).ToString("0.00"))}");
                sb.AppendLine("============================================");
                sb.AppendLine();
                sb.AppendLine();
                n++;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}