namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double resultadoCubo;
            double resultadoCuadrado;
            string valorIngresado;
            int valorNumerico;
            bool respuesta;

            Console.WriteLine("Ingrese un numero mayor a 0:");
            valorIngresado = Console.ReadLine();

            respuesta = int.TryParse(valorIngresado, out valorNumerico);

            while (!respuesta || valorNumerico <= 0)
            {
                Console.WriteLine("Error Numero no valido");
                Console.WriteLine("Ingrese un numero mayor a 0:");
                valorIngresado = Console.ReadLine();
                respuesta = int.TryParse(valorIngresado, out valorNumerico);
            }

            resultadoCuadrado = Math.Pow(valorNumerico, 2);
            resultadoCubo = Math.Pow(valorNumerico, 3);

            Console.WriteLine($"El resultado del cuadrado del numero {valorNumerico} , es {resultadoCuadrado} ");
            Console.WriteLine($"El resultado del cubo del numero {valorNumerico} , es {resultadoCubo} ");

        }
    }
}