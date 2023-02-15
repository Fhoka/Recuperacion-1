using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion
{
    public class Frappe : Cafe
    {
        private bool leche;
        public Frappe(bool leche, string ingredientes, float temperatura, bool pitillos, string color, float cantidad) : base(ingredientes, 
            temperatura, pitillos, color, cantidad)
        {

            Leche = leche;
        }

        public bool Leche { get => leche; set => leche = value; }
    }
}
