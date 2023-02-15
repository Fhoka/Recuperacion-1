using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion
{
    public class Kola : Gaseosa
    {
        private bool mundial;
        public Kola(bool mundial, string ingredientes, float temperatura, bool pitillos, string color, 
            float cantidad) : base(ingredientes, temperatura, pitillos, color, cantidad)
        {
            Mundial= mundial;
        }

        public bool Mundial { get => mundial; set => mundial = value; }
    }
}
