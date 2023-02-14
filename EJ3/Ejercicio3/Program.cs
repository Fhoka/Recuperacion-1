namespace Ejercicio3
{
    public class Program
    {
        static void Main(string[] args)
        {
            PesoArgentino argentino = new PesoArgentino(5, 3.5F, "niquel");
            Dolar gringo = new Dolar(3, 3.0F, "bronce");
            Libra europeo = new Libra(6, 4.0F, "latón");

            int indice = 1;

            Console.WriteLine("Ahora el peso argentino vale: " + argentino.Devaluarse(argentino.Valor, indice));
            Console.WriteLine("Ahora el dolar vale: " + gringo.Revaluarse(gringo.Valor, indice));
            Console.WriteLine("Ahora la libra vale: " + europeo.Brexit(europeo.Valor));
        }
    }
}