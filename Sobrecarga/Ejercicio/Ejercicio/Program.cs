namespace Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Persona p = 1111111;
            Persona p2 = Persona.GetPersona(p);


            int dni = p;
            Console.WriteLine(p.GetDni());
            

            
        }
    }
}