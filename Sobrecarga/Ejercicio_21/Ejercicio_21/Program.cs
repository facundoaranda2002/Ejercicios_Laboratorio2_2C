using Entidades;
using System.Drawing;

namespace Ejercicio_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fahrenheit fahrenheit = 32;//aca estoy usando el conversor implicito

            Celsius celsius = (Celsius)fahrenheit;

            Kelvin kelvin = (Kelvin)fahrenheit;

            Console.WriteLine(fahrenheit.GetGrados());

            Console.WriteLine(celsius.GetGrados());

            Console.WriteLine(kelvin.GetGrados());

            Console.WriteLine(fahrenheit == celsius);

            Console.WriteLine(celsius == kelvin);

            Console.WriteLine(kelvin == fahrenheit);

            Celsius celsius2 = new Celsius(10);
            Kelvin kelvin2 = (Kelvin)celsius2;
            Fahrenheit fahrenheit2 = (Fahrenheit)kelvin2;

            Console.WriteLine(fahrenheit2.GetGrados());

            Console.WriteLine(celsius2.GetGrados());

            Console.WriteLine(kelvin2.GetGrados());

            Console.WriteLine(fahrenheit != fahrenheit2);

            Console.WriteLine(celsius != celsius2);

            Console.WriteLine(kelvin != kelvin2);

            Celsius celsius3 = celsius + fahrenheit2;

            Fahrenheit fahrenheit3 = fahrenheit + kelvin2;

            Kelvin kelvin3 = kelvin + fahrenheit2 + celsius2;

            Console.WriteLine(fahrenheit3.GetGrados());

            Console.WriteLine(celsius3.GetGrados());

            Console.WriteLine(kelvin3.GetGrados());


        }
    }
}