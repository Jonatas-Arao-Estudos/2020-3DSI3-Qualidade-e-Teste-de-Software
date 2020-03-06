using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leilao
{
    class Avaliador
    {
        private double maiorDeTodos;
        private double menorDeTodos;
        public double MaiorLance { get; private set; }
        public double MenorLance { get; private set; }
        public void Avalia(Leilao leilao)
        {
            maiorDeTodos = leilao.Lances[0].Valor;
            menorDeTodos = leilao.Lances[0].Valor;
            foreach (var lance in leilao.Lances)
            {
                if(lance.Valor > maiorDeTodos)
                {
                    maiorDeTodos = lance.Valor;
                }else if (lance.Valor < menorDeTodos)
                {
                    menorDeTodos = lance.Valor;
                }
                this.MaiorLance = maiorDeTodos;
                this.MenorLance = menorDeTodos;
            }
        }
    }
}
