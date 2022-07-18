using System;

namespace Tabuada_CSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("ENTRADA: ");
            double entrada = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("SAIDA: ");
           
            for (int x = 0; x <= 10; x++)
            {
                double total = entrada * x;
                Console.WriteLine(entrada + " X " + x + " = " + total);
            }

        }
    }
}
