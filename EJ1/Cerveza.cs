using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion
{
    public class Cerveza : Bebida
    {
        public Cerveza(string ingredientes, float temperatura, bool pitillos, string color, float cantidad) : base(ingredientes, 
            temperatura, pitillos, color, cantidad)
        {
        }

        public string Destapar()
        {
            return null;
        }

        public string Michelar()
        {
            return null;
        }

        public override void Servir()
        {

        }
    }
}
