using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leilao
{
    class Avaliador
    {
        private double maiorDeTodos = Double.MinValue;
        private double menorDeTodos = Double.MaxValue;
        public double MaiorLance { get; private set; }
        public double MenorLance { get; private set; }
        public void Avalia(Leilao leilao)
        {
            foreach(var lance in leilao.Lances)
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
