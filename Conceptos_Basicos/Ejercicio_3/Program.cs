namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            string numeroCadena;
            int opcion;

            Console.WriteLine("Ingrese un numero: ");
            numeroCadena = Console.ReadLine();

            while (numeroCadena != "salir" && !(int.TryParse(numeroCadena, out numero)))
            {
                Console.WriteLine("\nERROR. ¡Reingresar número!: ");
                numeroCadena = Console.ReadLine();
            }

            if (numeroCadena == "salir")
            {
                Environment.Exit(0);
            }


            for (int i = 1; i <= numero; i++)
            {
                int contador = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        contador++;
                    }
                }

                if (contador <= 2)
                {
                    Console.WriteLine(i);
                }
            }


            Console.WriteLine("Quiere volver a ingresar un numero?\n1. Si\n2. No");
            while (!(int.TryParse(Console.ReadLine(), out opcion)) || (opcion != 1 && opcion != 2))
            {
                Console.WriteLine("Opcion Incorrecta. Quiere volver a ingresar un numero?\n1. Si\n2. No");
            }

            if (opcion == 1)
            {
                Main(args);
            }

        }
    }
}