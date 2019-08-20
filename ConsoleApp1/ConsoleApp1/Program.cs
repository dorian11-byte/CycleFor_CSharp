using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y,z;
            Console.WriteLine("Impprime los numeros del X hasta Y de -1");
            Console.WriteLine("Donde arrancamos el ciclo (mayor):");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De donde termiamos el ciclo (menor):");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De cuanto en cuanto:");
            z = Convert.ToInt32(Console.ReadLine());

            for (int i=x; i > y; i-=z)
            {
                Console.WriteLine("i =" + i);
            }
        }
    }
}
