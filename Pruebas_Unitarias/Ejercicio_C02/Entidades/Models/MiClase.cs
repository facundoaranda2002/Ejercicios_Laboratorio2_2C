using Entidades.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class MiClase
    {
        public MiClase()
        {
            try
            {
                LanzarExcepcion();
            }
            catch (Exception ex)
            {
                throw; //throw ex;
            }
        }

        public MiClase(int id)
        {
            try
            {
                new MiClase();
            }
            catch (Exception ex)
            {
                throw new UnaExcepcion("Este es el constructor con parametros de mi clase", ex);
            }
        }

        public static void LanzarExcepcion()
        {
            throw new DivideByZeroException();
        }
    }
}
