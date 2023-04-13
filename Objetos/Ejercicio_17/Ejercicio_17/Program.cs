using entidades;

namespace Ejercicio_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto;

            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);

            Console.WriteLine(boligrafoRojo.GetColor());
            Console.WriteLine(boligrafoRojo.GetTinta());
            if(boligrafoRojo.Pintar(60, out texto))
            {
                Console.ForegroundColor = boligrafoRojo.GetColor();
            }
            Console.WriteLine(texto);
            Console.ForegroundColor = ConsoleColor.White;
            boligrafoRojo.Recargar();
            Console.WriteLine(boligrafoRojo.GetTinta());
            if (boligrafoRojo.Pintar(60, out texto))
            {
                Console.ForegroundColor = boligrafoRojo.GetColor();
            }
            Console.WriteLine(texto);
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(boligrafoAzul.GetColor());
            Console.WriteLine(boligrafoAzul.GetTinta());
            if (boligrafoAzul.Pintar(100, out texto))
            {
                Console.ForegroundColor = boligrafoAzul.GetColor();               
            }
            Console.WriteLine(texto);
            Console.ForegroundColor = ConsoleColor.White;
            if (boligrafoAzul.Pintar(100, out texto))
            {
                Console.ForegroundColor = boligrafoAzul.GetColor();
            }
            Console.WriteLine(texto);
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(boligrafoRojo.GetColor());
            Console.WriteLine(boligrafoRojo.GetTinta());
            Console.WriteLine(boligrafoAzul.GetColor());
            Console.WriteLine(boligrafoAzul.GetTinta());


        }
    }
}