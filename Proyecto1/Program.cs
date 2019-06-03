using System;

namespace Proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo...");
            int a = 5;
            int b = 3;
            int resultado = 0;
            resultado = a + b;

            Console.WriteLine("LA SUMA ES: -------------->" + resultado.ToString());
            Console.WriteLine("OPRIMA UNA TECLA PARA TERMINAR...");
            Console.ReadLine();
        }
    }
}
