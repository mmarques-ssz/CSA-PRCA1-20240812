using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj20240812
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int nj;
            do
            {
                Console.Write("Quantos jogadores? ");
                nj = int.Parse(Console.ReadLine());
            }
            while (nj < 2 || nj > 5);

            string[] nomes;
            nomes = new string[nj];

            for(i=0; i<nj; i++)
            {
                Console.Write("Digite do nome do {0}º jogador: ", i+1);
                nomes[i] = Console.ReadLine();
            }

            for (i = 0; i < nj; i++)
            {
                Console.WriteLine("Nome do {0}º jogador: {1}", i + 1, nomes[i]);
            }



        }
    }
}
