using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion
{
    public class Bebida
    {
        private string ingredientes;
        private float temperatura;
        private bool pitillos;
        private string color;
        private float cantidad;

        public Bebida(string ingredientes, float temperatura, bool pitillos, string color, float cantidad)
        {
            Ingredientes = ingredientes;
            Temperatura = temperatura;
            Pitillos = pitillos;
            Color = color;
            Cantidad = cantidad;
        }

        public string Ingredientes { get => ingredientes; set => ingredientes = value; }
        public float Temperatura { get => temperatura; set => temperatura = value; }
        public bool Pitillos { get => pitillos; set => pitillos = value; }
        public string Color { get => color; set => color = value; }
        public float Cantidad { get => Cantidad1; set => Cantidad1 = value; }
        public float Cantidad1 { get => cantidad; set => cantidad = value; }

        public void Preparacion(float temperatura)
        {
            Console.WriteLine("Se saca de la nevera a "+temperatura+"°C");
        }

        public virtual void Servir()
        {
            Console.WriteLine("La bebida está servida");
        }
    }
}
