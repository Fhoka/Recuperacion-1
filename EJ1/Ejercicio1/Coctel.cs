using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion
{
    public class Coctel : Bebida, IPicante
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
            string a = "Coctel mezclado";
            return a;
        }

        public override void Servir()
        {
            string a = Mezclar();
            Console.WriteLine(a + " y servido");   
        }

        public void CalcularPicante(bool b)
        {
            if (b == true)
                Console.WriteLine("Tiene picante");
            else 
                Console.WriteLine("No tiene picante");
        }
        
    }
}
