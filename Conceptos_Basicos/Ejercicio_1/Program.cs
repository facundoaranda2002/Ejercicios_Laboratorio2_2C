namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 1";
            int min = 0;
            int max = 0;
            int numeroIngresado;
            float total = 0;

            string palabra;

            for (int i = 0; i < 5; i++)
            {

                Console.Write("Ingrese un número: ");
                palabra = Console.ReadLine();

                if (int.TryParse(palabra, out numeroIngresado))
                {
                    total += numeroIngresado;
                    if (i == 0 || numeroIngresado < min)
                    {
                        min = numeroIngresado;
                    }

                    if (i == 0 || numeroIngresado > max)
                    {
                        max = numeroIngresado;
                    }

                }
                else
                {
                    Console.Write("No es un numero");
                    break;
                }


            }

            Console.WriteLine("El valor mínimo es {0}, el maximo es {1} y el promedio {2:#.00}", min, max, total / 5);


        }
    }
}