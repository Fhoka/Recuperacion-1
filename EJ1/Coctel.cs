using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion
{
    public class Coctel : Bebida
    {
        private string nombre;
        public Coctel(string nombre, string ingredientes, float temperatura, bool pitillos, string color, 
            float cantidad) : base(ingredientes, temperatura, pitillos, color, cantidad)
        {
            Nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public string Mezclar()
        {
            return null;
        }

        public override void Servir()
        {
            
        }
    }
}
