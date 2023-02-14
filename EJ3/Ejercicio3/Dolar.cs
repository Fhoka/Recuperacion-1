using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Dolar : Moneda
    {
        public Dolar(int valor, float peso, string materiales) : base(valor, peso, materiales)
        {
        }

        public int Revaluarse(int v, int i)
        {
            return v + i;
        }
    }
}
