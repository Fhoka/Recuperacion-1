using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion
{
    public class Caipirinha : Coctel
    {
        private bool caña;
        public Caipirinha(bool caña, string nombre, string ingredientes, float temperatura, bool pitillos, string color, 
            float cantidad) : base(nombre, ingredientes, temperatura, pitillos, color, cantidad)
        {
            Caña = caña;
        }

        public bool Caña { get => caña; set => caña = value; }
    }
}
