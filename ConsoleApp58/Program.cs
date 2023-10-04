using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor de n: ");
            int n = int.Parse(Console.ReadLine());
            double i = 1;
            double resultado = 0;

            do
            {
                resultado = (16 - i) / ( 3 * i ) ;
                Console.WriteLine("Resultado: " + resultado);
                i++;
            } while (i <= n);
            Console.ReadKey();
        }
    }
}
