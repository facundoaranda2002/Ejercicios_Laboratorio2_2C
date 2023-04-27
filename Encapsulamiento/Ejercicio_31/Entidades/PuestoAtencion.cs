using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PuestoAtencion
    {
        public enum EPuesto {Caja1, Caja2};
        private EPuesto puesto;
        private static int numeroActual;

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(EPuesto puesto)
        {
            this.puesto = puesto;
        }

        public static int NumeroActual { get { return ++PuestoAtencion.numeroActual; } }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(1000);
            return true;
        }
           
    }
}
