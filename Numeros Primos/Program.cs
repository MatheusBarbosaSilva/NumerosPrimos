using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Numeros_Primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Validar de Números Primos------");
            Console.WriteLine();
            Console.WriteLine("Para parar o programa digite: 0");
            Console.WriteLine();
            Console.WriteLine("Informe um número:");

            var exit = 1;

            while(exit != 0) 
            {
                var number = int.Parse(Console.ReadLine());

                if (number == 0)
                {
                    return;
                }
                else
                {
                    var isPrime = PrimeNumber(number);

                    if (isPrime)
                    {
                        Console.WriteLine("O número é Primo");
                    }
                    else
                    {
                        Console.WriteLine("O número NÃO é Primo");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Informe um número:");


                }
            }
        }

        static bool PrimeNumber(int number)
        {
            var count = 0;

            for (int i = 1; i <= number; i++)
            {
                if(number % i == 0)
                {
                    count = count + 1;
                }
            }

            if (count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
