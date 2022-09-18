using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_com_Recursividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Digite o termo de sua escolha para a sequência de fibonacci: ");
            n=int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine(fibo(n));

            Console.ReadLine();
        }
        static int fibo(int n)
        {
            int res;

            if(n == 1 || n == 2)
            {
                res= 1;
            }
            else
            {
                res= fibo(n-1) + fibo(n-2);
            }
            return res;
        }
    }
}
