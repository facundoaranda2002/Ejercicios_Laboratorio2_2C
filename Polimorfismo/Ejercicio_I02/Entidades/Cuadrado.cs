using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Cuadrado : Rectangulo
    {

        public Cuadrado(double xBase, double yAltura): base(xBase, yAltura) 
        {
            XBase = YAltura;
        }

        public override string Dibujar()
        {
            return "Dibujando Cuadrado";
        }

    }
}
