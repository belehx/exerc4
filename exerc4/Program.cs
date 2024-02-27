using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace exerc4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, x, p1, p2;
            Console.WriteLine("digite um número: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("digite outro número: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("digite outro número: ");
            x = int.Parse(Console.ReadLine());

          

            if (x > 5)
            {
               p2 = (b - a) * x;
                Console.WriteLine("seu terceiro número digitado foi MAIOR que 5, portanto aqui está a solução: " + p2);
            }else
            {
                p1 = (a + b) * x;
                Console.WriteLine("seu terceiro número digitado foi MENOR que 5, portanto aqui está a solução: " + p1);
            } 

            Console.ReadKey();

        }
    }
}
