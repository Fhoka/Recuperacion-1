namespace Recuperacion
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bebida[] bebidas = new Bebida[4];

            bebidas[0] = new Cafe("granos molidos", 30f, false, "negro", 200f);
            bebidas[1] = new Gaseosa("cocaína", 15f, true, "rojo", 250f);
            bebidas[2] = new Cerveza("cebada", 10f, false, "amarillo clarito", 500f);
            bebidas[3] = new Coctel("negroni", "ron", 10f, false, "rojizo", 350f);

            for(int i = 0; i < bebidas.Length; i++){ 
                bebidas[i].Preparacion(bebidas[i].Temperatura);
            }

            for (int i = 0; i < bebidas.Length; i++)
                bebidas[i].Servir();

        }
    }
}