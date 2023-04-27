using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public VehiculoDeCarrera(string escuderia, short numero)
        {
            this.escuderia = escuderia;
            this.numero = numero;
        }

        public short CantidadCombustible { get => cantidadCombustible; set => cantidadCombustible = value; }
        public bool EnCompetencia { get => enCompetencia; set => enCompetencia = value; }
        public short VueltasRestantes { get => vueltasRestantes; set => vueltasRestantes = value; }

        public static bool operator ==(VehiculoDeCarrera a, VehiculoDeCarrera b)
        {
            return (a.numero == b.numero) && (a.escuderia == b.escuderia);
        }

        public static bool operator !=(VehiculoDeCarrera a, VehiculoDeCarrera b)
        {
            return !(a == b);
        }

        public string MostrarDatos()
        {
            return $"Escuderia: {this.escuderia} Vueltas Restantes: {this.vueltasRestantes}";
        }
    }
}
