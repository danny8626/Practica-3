using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0,sum= 0;
              do
            {  
                Console.Write("Ingresa un numero: ");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine(num);
                sum += num;
            } while (num != 0 || num < 0);

            Console.WriteLine($"El Total de la suma es de: {sum}");

        }
    }
}
