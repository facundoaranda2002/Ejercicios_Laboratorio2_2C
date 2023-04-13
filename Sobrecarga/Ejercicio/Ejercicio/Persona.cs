using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public class Persona
    {
        private int dni;

        private Persona(int dni)
        {
            this.dni = dni;
        }

        public int GetDni()
        {
            return this.dni;
        }

        public static Persona GetPersona(int dni)
        {
            return new Persona(dni);
        }

        public static implicit operator Persona(int dni)
        {
            return new Persona(dni);
        }

        public static implicit operator int(Persona p)
        {
            return p.dni;
        }

        


    }
}
