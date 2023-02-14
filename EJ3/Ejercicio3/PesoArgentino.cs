using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class PesoArgentino : Moneda
    {
        public PesoArgentino(int valor, float peso, string materiales) : base(valor, peso, materiales)
        {
        }

        public int Devaluarse(int v, int i)
        {
            return v - i;
        }
    }
}
