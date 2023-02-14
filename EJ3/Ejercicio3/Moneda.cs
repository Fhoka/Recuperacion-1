using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Moneda
    {
        private int valor;
        private float peso;
        private string materiales;

        public Moneda(int valor, float peso, string materiales)
        {
            Valor = valor;
            Peso = peso;
            Materiales = materiales;
        }

        public int Valor { get => valor; set => valor = value; }
        public float Peso { get => peso; set => peso = value; }
        public string Materiales { get => materiales; set => materiales = value; }
    }
}
