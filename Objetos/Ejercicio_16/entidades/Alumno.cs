using System.Text;

namespace entidades
{
    public class Alumno
    {
        byte nota1;//al no aclararse el modificador de privacidad se toma como private
        byte nota2;//al no aclararse el modificador de privacidad se toma como private
        float notaFinal;//al no aclararse el modificador de privacidad se toma como private
        public string apellido;
        public int legajo;
        public string nombre;

        public void Estudiar(byte nota1, byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2; 
        }

        public void CalcularFinal()
        {
            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = new Random().Next(1, 11);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Legajo: {this.legajo}");
            sb.AppendLine($"Nota 1: {this.nota1}");
            sb.AppendLine($"Nota 2: {this.nota2}");
            if(this.notaFinal == -1)
            {
                sb.AppendLine("Alumno desaprobado");
            }
            else
            {
                sb.AppendLine($"Nota Final: {this.notaFinal}");
            }

            return sb.ToString();
        }
    }
}