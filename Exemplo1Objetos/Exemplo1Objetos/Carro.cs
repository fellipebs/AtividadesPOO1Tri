using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1Objetos
{
    public class Carro
    {
        public int NumeroDePortas, AnoDeFabricacao;
        public string TipoDeCambio, Placa, Cor, Modelo, Fabricante;
        public bool Ligado, usado;
        public double valor, kmRodada;

        public void Ligar()
        {
            Ligado = true;
        }
        public void Desligar()
        {
            Ligado = false;
        }
    }
}
