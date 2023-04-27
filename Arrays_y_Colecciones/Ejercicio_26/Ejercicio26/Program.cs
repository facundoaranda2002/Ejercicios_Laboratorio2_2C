namespace Ejercicio_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[20];
            Random random = new Random();

            for(int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(-100, 100);
            }

            Console.WriteLine("Punto A");
            for(int i = 0;i < numeros.Length;i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("Punto B");
            Array.Sort(numeros, Program.OrdenDescendente);
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > 0)
                {
                    Console.WriteLine(numeros[i]);
                }
            }

            Console.WriteLine("Punto C");
            Array.Sort(numeros);
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                {
                    Console.WriteLine(numeros[i]);
                }
            }
        }

        public static int OrdenDescendente(int n1, int n2)
        {
            return n2 - n1;
        }
    }
}