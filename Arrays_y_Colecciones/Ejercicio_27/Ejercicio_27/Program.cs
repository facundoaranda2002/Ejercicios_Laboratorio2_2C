namespace Ejercicio_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numerosLista = new List<int>();
            Queue<int> numerosCola = new Queue<int>();
            Stack<int> numerosPila = new Stack<int>();
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                numerosLista.Add(random.Next(-100, 100));
            }

            Console.WriteLine("Punto A");
            foreach(int item in numerosLista)
            {
                Console.WriteLine(item);
            }

            numerosLista.Sort(OrdenDescendente);

            foreach (int item in numerosLista)
            {
                if (item >= 0)
                {
                    numerosCola.Enqueue(item);
                }
                else  
                {
                    numerosPila.Push(item);
                }
            }

            Console.WriteLine("Punto B");
            foreach (int c in numerosCola)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("Punto C");
            foreach (int p in numerosPila)
            {
                Console.WriteLine(p);
            }
        }

        public static int OrdenDescendente(int n1, int n2)
        {
            return n2 - n1;
        }
    }

}