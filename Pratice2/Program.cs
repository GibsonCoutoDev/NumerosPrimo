using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1; int cont = 1;
            Console.WriteLine("Digite um número:");
            num1 = int.Parse(Console.ReadLine());

            for (int i = 1; i < num1; i++)
            {
                if (num1 % i == 0)
                {
                    cont = cont + 1;
                }
            }
            if (cont == 2)
            {
                Console.WriteLine("O número {0} é primo", num1);
            }
            else
            {
                Console.WriteLine("O número {0} não é primo", num1);
            }

            Console.ReadLine();

        }
    }
}
