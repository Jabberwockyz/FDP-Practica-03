    using System;

    namespace Practica_03___Ejercicio_04
    {
        class Program
        {
            static void Main(string[] args)
            {
                char Letra;
                Letra = 'Z';
                Console.WriteLine(Letra);

                do
                {
                    Letra--;
                    Console.WriteLine(Letra);
                } 
                while (Letra != 'A');
            }
        }
    }
