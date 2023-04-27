using System.Text;

namespace Entidades
{
    public class Ingresante
    {
        private string nombre;
        private string direccion;
        private string genero;
        private string pais;
        private string[] cursos;
        private int edad;

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
            this.edad = edad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Direccion: " + this.direccion);
            sb.AppendLine("Edad: " + this.edad.ToString());
            sb.AppendLine("Genero: " + this.genero);
            sb.AppendLine("Pais: " + this.pais);
            sb.AppendLine("Curso/s: ");
            foreach(string s in this.cursos)
            {
                sb.AppendLine(s);
            }

            return sb.ToString();
        }
    }
}