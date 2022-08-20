using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace relacionamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            jogo jogo1 = new jogo();
            jogo1.nome = "SKYRIM";
            jogo1.desenvolvedor = "BETHESDA GAMES";
            jogo1.lancamento = 2008;

            jogo jogo2 = new jogo();
            jogo2.nome = "GTA V";
            jogo2.desenvolvedor = "Rockstar games";
            jogo2.lancamento = 2012;

            plataforma jogos = new plataforma();
            jogos.jogos = new List<jogo>();
            jogos.jogos.Add(jogo1);
            jogos.jogos.Add(jogo2);

            int cont = 1;
            for (int i = 0; i < jogos.jogos.Count; i++)
            {
                Console.WriteLine($"Jogo número {cont} :");
                Console.WriteLine(jogos.jogos[i].nome);
                Console.WriteLine(jogos.jogos[i].desenvolvedor);
                Console.WriteLine(jogos.jogos[i].lancamento);
                Console.WriteLine();
                cont++;
            }
            Console.ReadKey();
        }
    }
}