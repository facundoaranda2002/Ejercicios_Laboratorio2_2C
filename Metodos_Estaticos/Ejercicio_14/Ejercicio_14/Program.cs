using Entidades;
using System;

namespace Ejercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lado;
            double bas;
            double altura;
            double radio;
            double areaCuadrado;
            double areaTriangulo;
            double areaCirculo;

            Console.WriteLine("Ingrese valor del lado del cuadrado");
            double.TryParse(Console.ReadLine(), out lado);
            areaCuadrado=CalculadoraDeArea.CalcularAreaCuadrado(lado);

            Console.WriteLine("Ingrese valor de la base del triangulo");
            double.TryParse(Console.ReadLine(), out bas);
            Console.WriteLine("Ingrese valor de la altura del triangulo");
            double.TryParse(Console.ReadLine(), out altura);
            areaTriangulo = CalculadoraDeArea.CalcularAreaTriangulo(bas, altura);

            Console.WriteLine("Ingrese valor del radio del circulo");
            double.TryParse(Console.ReadLine(), out radio);
            areaCirculo = CalculadoraDeArea.CalcularAreaCirculo(radio);

            Console.WriteLine("El area del cuadrado es {0}, el area del triangulo {1} y el area del circulo {2}", areaCuadrado, areaTriangulo, areaCirculo);

        }
    }
}