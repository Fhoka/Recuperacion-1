using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion
{
    public class Stout : Cerveza
    {
        private bool imperial;
        public Stout(bool imperial, string ingredientes, float temperatura, bool pitillos, string color, 
            float cantidad) : base(ingredientes, temperatura, pitillos, color, cantidad)
        {
            Imperial = imperial;
        }

        public bool Imperial { get => imperial; set => imperial = value; }
    }
}
