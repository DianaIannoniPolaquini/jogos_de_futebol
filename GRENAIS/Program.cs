using System;

namespace GRENAIS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int golI, golG, vitoriaI, vitoriaG, grenal, decisao, cont, empate;
            double soma, media;

            cont = 0;
            vitoriaG = 0;
            vitoriaI = 0;
            empate = 0;

            do
            {
                cont++;
                Console.Write("Quantos gols do Inter?");
                golI = int.Parse(Console.ReadLine());
                Console.Write("Quantos gols do Grêmio?");
                golG = int.Parse(Console.ReadLine());

                if (golG > golI)
                {
                    vitoriaG++;
                }
                else if (golG < golI)
                {
                    vitoriaI++;
                }
                else
                {
                    empate++;
                }

                Console.Write("Novo grenal? 1 -sim/2 -não");
                decisao = int.Parse(Console.ReadLine());
                Console.WriteLine();

            }
            while (decisao == 1);

         
            Console.WriteLine("Quantidade de vitorias do Inter = {0}", vitoriaI);
            Console.WriteLine("Quantidade de vitorias do Grêmio = {0}", vitoriaG);
            Console.WriteLine("Quantidade de empates = {0}", empate);
            Console.WriteLine("Quantidade de grenais = {0}", cont);

            if (vitoriaI > vitoriaG)
            {
                Console.WriteLine("Vitoria = Inter");
            }
            else if (vitoriaI < vitoriaG)
            {
                Console.WriteLine("Vitoria = Grêmio");
            }
            else
            {
                Console.WriteLine("Não houve vencedor!");
            }
        }
    }
}
