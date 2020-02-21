using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leilao
{
    class TesteDoAvaliador
    {
        static void Main(string[] args)
        {
            //Criar os usuarios
            Usuario Sonic = new Usuario("Jonatas");
            Usuario Knuckles = new Usuario("Matheus");
            Usuario Eggman = new Usuario("Andrew");
            Usuario Amy = new Usuario("Malu");

            Leilao leilao = new Leilao("Esmeralda do Caos");
            leilao.Propoe(new Lance(Knuckles, 500));
            leilao.Propoe(new Lance(Eggman, 650));
            leilao.Propoe(new Lance(Amy, 1500));
            leilao.Propoe(new Lance(Sonic, 700));
            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            Console.WriteLine(leiloeiro.MaiorLance);
            Console.WriteLine(leiloeiro.MenorLance);

            Console.ReadKey();
        }
    }
}
