using Entidades;
namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int minimo = 0;
            int maximo = 0;
            int suma = 0;
            float promedio;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero entre -100 y 100");
                int.TryParse(Console.ReadLine(), out num);
                while(!Validador.Validar(num, -100, 100))
                {
                    Console.WriteLine("Rango invalido. Ingrese un numero entre -100 y 100");
                    int.TryParse(Console.ReadLine(), out num);
                }

                if( i == 0)
                {
                    minimo = num;
                    maximo = num;
                }
                else
                {
                    if( num<minimo)
                    {
                        minimo = num;
                    }
                    if( num>maximo)
                    {
                        maximo = num;
                    }
                }
                suma += num;
            }
            promedio = (float)suma / 10;

            Console.WriteLine("El valor mínimo es {0}, el maximo es {1} y el promedio {2:#.00}", minimo, maximo, promedio);
        }
    }
}