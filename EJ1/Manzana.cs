using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion
{
    public class Manzana : Gaseosa
    {
        private bool navidad;
        public Manzana(bool navidad, string ingredientes, float temperatura, bool pitillos, string color, 
            float cantidad) : base(ingredientes, temperatura, pitillos, color, cantidad)
        {
            Navidad= navidad;
        }

        public bool Navidad { get => navidad; set => navidad = value; }
    }
}
