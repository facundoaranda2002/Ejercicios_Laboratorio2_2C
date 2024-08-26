using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.MetodoDeExtension
{
    public static class MisMetodosDeExtension
    {
        public static string FizzBuzz(this Int32 num)
        {
            string retorno;// = "El numero no es divisible por 3 ni por 5";
            if(num % 3 == 0 && num % 5 == 0)
            {
                retorno = "Fizz Buzz";
            }
            else if (num % 3 == 0)
            {
                retorno = "Fizz";
            }
            else if (num % 5 == 0)
            {
                retorno = "Buzz";
            }
            else
            {
                throw new Exception();
            }

            return retorno;
        }
    }
}
