using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion
{
    public class Cafe : Bebida
    {
        public Cafe(string ingredientes, float temperatura, bool pitillos, string color, float cantidad) : base(ingredientes, 
            temperatura, pitillos, color, cantidad)
        {
        }

        public string AgregarAzucar(string ingredientes)
        {
            return null;
        }
    }
}
