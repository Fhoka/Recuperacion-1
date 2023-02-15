using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion
{
    public class Cerveza : Bebida, IPicante
    {
        public Cerveza(string ingredientes, float temperatura, bool pitillos, string color, float cantidad) : base(ingredientes, 
            temperatura, pitillos, color, cantidad)
        {
        }

        public string Destapar()
        {
            return "Cerveza Destapada ";
        }

        public string Michelar()
        {
            return "... Ahora esta Michelada";
        }

        public override void Servir()
        {
            string a = Destapar() + Michelar();
            Console.WriteLine(a);
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
