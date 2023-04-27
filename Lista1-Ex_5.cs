using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int média;
            int a1;
            int a2;
            int a3;
            int a4;
            Console.Write("Informe o primeiro valor: ");
            a1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o segundo valor: ");
            a2 = int.Parse(Console.ReadLine());
            Console.Write("Informe o terceiro valor: ");
            a3 = int.Parse(Console.ReadLine());
            Console.Write("Informe o quarto valor: ");
            a4 = int.Parse(Console.ReadLine());
            média = (a1 + a2 + a3 + a4) / 4;
            Console.Write("A média aritmética é: ");
            Console.write(média);
        }
    }
}
