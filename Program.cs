using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n1;
           int n2;     
           int n3;

            Console.WriteLine("A partir de três valores, vamos ver se conseguimos criar um triângulo");
            Console.Write("gite o primeiro valor: ");
            n1=int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            n2=int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            n3=int.Parse(Console.ReadLine());

            if ((n1 + n2 <= n3) & (n1 + n3 <= n2))
                Console.WriteLine("Não é Triângulo");
            else
                if ((n1 == n2) & (n1 == n3) & (n1 == n3))
                Console.WriteLine("Triângulo Equilatero");
            else
                if ((n1 == n2) & (n1 != n3) & (n2 != n3))
                Console.WriteLine("Triângulo Isosceles");
            else Console.WriteLine("Triângulo Escaleno");



        }
    }
}
