using Billetes;

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Pesos pesos = 398;//aca estoy usando el conversor implicito

            Dolar dolar = (Dolar)pesos;

            Euro euro = (Euro)dolar;

            Console.WriteLine(pesos.GetCantidad());

            Console.WriteLine(dolar.GetCantidad());

            Console.WriteLine(euro.GetCantidad());

            Console.WriteLine(pesos == dolar);

            Console.WriteLine(pesos == euro);

            Console.WriteLine(euro == dolar);

            Pesos pesos2 = new Pesos(398, 400);

            Euro euro2 = (Euro)pesos2;

            Dolar dolar2 = (Dolar)euro2;

            Console.WriteLine(pesos2.GetCantidad());

            Console.WriteLine(dolar2.GetCantidad());

            Console.WriteLine(euro2.GetCantidad());

            Console.WriteLine(pesos != pesos2);

            Console.WriteLine(dolar != dolar2);

            Console.WriteLine(euro != euro2);

            Pesos pesos3 = pesos + dolar2;

            Dolar dolar3 = dolar + euro2;

            Euro euro3 = euro + dolar2 + pesos2;

            Console.WriteLine(pesos3.GetCantidad());

            Console.WriteLine(dolar3.GetCantidad());

            Console.WriteLine(euro3.GetCantidad());

        }
    }
}