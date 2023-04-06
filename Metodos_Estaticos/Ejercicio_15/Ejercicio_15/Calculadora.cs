using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    internal class Calculadora
    {
        public static float Calcular(int a, int b, char c)
        {
            float result = -1;
            switch (c)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    {
                        if(Validar(b))
                        {
                            result = (float)a / b;
                        }
                        break;
                    }
            }
            return result;
        }

        static bool Validar(int a)
        {
            if (a != 0)
            {
                return true;
            }
            else 
            {
                return false;
            }   
        }


    }
}
