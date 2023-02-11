using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2parcialscripting
{
    internal class FreddyKrueger
    {
        int vidas;
        float velocidad;
        bool enojado;
        string victima = "";


        public FreddyKrueger(int vidas, float velocidad)
        {
            this.vidas = vidas;
            this.velocidad = velocidad;
        }
        public FreddyKrueger(bool enojado, float velocidad)
        {
            this.enojado = enojado;
            this.velocidad = velocidad;
        }
        public FreddyKrueger(string victima, int vidas)
        {
            this.vidas = vidas;
            this.victima = victima;
        }
        public string Asustar(string grito)
        {
            Console.Write("AAAAA!" + grito);
            Console.WriteLine(grito);
            return grito;
        }
        public string Perseguir(float rapidez)
        {
            string respuesta = "Persigo a " + rapidez + " m/s";
            Console.WriteLine(respuesta);
            return respuesta;
        }
        public string Perseguir(int Nvictimas)
        {
            string respuesta = "Persigo a esta cantidad de víctimas: " + Nvictimas;
            Console.WriteLine(respuesta);
            return respuesta;
        }
        public string Perseguir(byte tiempoM)
        {
            string respuesta = "Persigo durante: " + tiempoM + " minutos";
            Console.WriteLine(respuesta);
            return respuesta;
        }
        public string Perseguir(string objetivo)
        {
            string respuesta = "Persigo a: " + objetivo;
            Console.WriteLine(respuesta);
            return respuesta;
        }


    }


}
