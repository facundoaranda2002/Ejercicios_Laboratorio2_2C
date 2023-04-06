using System.Xml.Serialization;

namespace Ejercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            char operando;
            float result;
            string salir;

            do
            {
                Console.WriteLine("Ingrese el primer numero");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                num2 = int.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine("Ingrese el operando");
                    operando = Console.ReadKey().KeyChar;
                }
                while (operando != '+' && operando != '-' && operando != '*' && operando != '/');

                result = Calculadora.Calcular(num1, num2, operando);
                if (result == -1)
                {
                    Console.WriteLine("\nError en operacion, no se puede dividir por cero");
                }
                else
                {
                    Console.WriteLine($"\nEl resultado de la operacion de {operando} es {result}");
                }

                Console.WriteLine("Desea salir del programa? (si/no)");
                salir = Console.ReadLine();
            }
            while (salir != "si");
            
        }
    }
}