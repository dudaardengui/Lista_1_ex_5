using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            Console.WriteLine("Digite um valor:");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor:");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor:");
            C = int.Parse(Console.ReadLine());

            if (A == B & B == C)
            {
                Console.WriteLine("Triângulo Equilátero");
            }
            else if (A == B || B == C || A == C)
            {
                Console.WriteLine("Triângulo Isósceles");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno");
            }
            Console.ReadKey();
        }
    }
}
