using entidades;
namespace Ejercicio_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno = new Alumno();
            Alumno alumnoDos = new Alumno();
            Alumno alumnoTres = new Alumno();

            alumno.nombre = "Facundo";
            alumno.apellido = "Aranda";
            alumno.legajo = 1234;
            alumno.Estudiar(7, 5);
            alumno.CalcularFinal();
            Console.WriteLine(alumno.Mostrar());

            alumnoDos.nombre = "Nicolas";
            alumnoDos.apellido = "Leich";
            alumnoDos.legajo = 2222;
            alumnoDos.Estudiar(3, 5);
            alumnoDos.CalcularFinal();
            Console.WriteLine(alumnoDos.Mostrar());

            alumnoTres.nombre = "Pablo";
            alumnoTres.apellido = "Perez";
            alumnoTres.legajo = 3333;
            alumnoTres.Estudiar(2, 2);
            alumnoTres.CalcularFinal();
            Console.WriteLine(alumnoTres.Mostrar());


        }
    }
}