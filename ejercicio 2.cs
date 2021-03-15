using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 2*/
            int numero=1;

            do
            {
                Console.WriteLine("Numero: " + numero);
                numero++; 
            }
            while (numero <= 10);

            Console.ReadKey();
        }
    }
}


