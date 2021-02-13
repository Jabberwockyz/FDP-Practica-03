using System;

namespace Practica_03___Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            int Sum = 0;

            do
            {
                Console.WriteLine("Escriba un número:");
                Num = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (Num >= 1)
                {
                  Sum = Sum + Num;
                }
            } while (Num >= 1);

            Console.WriteLine("La suma de todos los números introducidos es: " + Sum);
        }
    }
}
