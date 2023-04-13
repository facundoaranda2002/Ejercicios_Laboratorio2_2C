using Billetes;

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pesos pesos = 398;//aca estoy usando el conversor implicito

            Dolar dolar = (Dolar)pesos;

            Console.WriteLine(dolar.GetCantidad());

        }
    }
}