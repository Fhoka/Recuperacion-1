using System;

namespace ejercicio2parcialscripting // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FreddyKrueger Simulator");
            FreddyKrueger f1 = new FreddyKrueger(3, 4f);
            FreddyKrueger f2 = new FreddyKrueger(true, 5F);
            FreddyKrueger f3 = new FreddyKrueger("José", 100);
            FreddyKrueger f4 = new FreddyKrueger(false, 1F);
            FreddyKrueger f5 = new FreddyKrueger(40, 50F);
            FreddyKrueger f6 = new FreddyKrueger("Jaime", 200);

            f1.Perseguir((byte)30);
            f1.Perseguir(10);
            f1.Perseguir("José");
            f1.Perseguir(5f);


        }
    }
}
