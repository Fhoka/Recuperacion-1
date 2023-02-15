using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion
{
    public class Capuchino : Cafe
    {
        private bool espuma;
        public Capuchino(bool espuma, string ingredientes, float temperatura, bool pitillos, string color, float cantidad) : base(ingredientes, 
            temperatura, pitillos, color, cantidad)
        {
            Espuma= espuma;
        }

        public bool Espuma { get => espuma; set => espuma = value; }
    }
}
