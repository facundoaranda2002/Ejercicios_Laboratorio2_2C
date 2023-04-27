using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        public enum ETipoCompetencia { F1, MOTOCROSS};
        private ETipoCompetencia tipo;
        private short cantidadVueltas;
        private short cantidadCompetidores;
        private List<VehiculoDeCarrera> competidores;

      
        public Competencia(ETipoCompetencia tipo, short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
            this.tipo = tipo;
        }

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            if(c.cantidadCompetidores > c.competidores.Count && c != a)
            {
                Random r = new Random();
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                a.CantidadCombustible = (short)r.Next(15, 100);
                c.competidores.Add(a);
                return true;
            }
            return false;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            if(c.competidores.Count > 0 && c == a/*lo retiro si esta*/)
            {
                a.EnCompetencia = false;
                c.competidores.Remove(a);
                return true;
            }
            return false;
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            if((c.tipo == ETipoCompetencia.F1 && a is AutoF1) || (c.tipo == ETipoCompetencia.MOTOCROSS && a is Motocross))
            {
                foreach (VehiculoDeCarrera item in c.competidores)
                {
                    if (item == a)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }

        public string MostrarDatos()
        {
            return $"Cantidad de Vueltas de la Competencia: {this.cantidadVueltas} Cantidad de competidores: {this.cantidadCompetidores}";
        }
    }
}
