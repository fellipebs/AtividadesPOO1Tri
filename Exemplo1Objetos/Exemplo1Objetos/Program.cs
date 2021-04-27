using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            // como criar uma instancia da classe carro? Criar uma instancia é criar um objeto
            Carro objetoCarro = new Carro(); // um objeto de nome objetoCarro foi criado na memória
            Aluno objetoaluno = new Aluno();

            //Agora queremos dar valores aos atributos da classe carro - faremos isso usando o objeto criado.

            objetoCarro.AnoDeFabricacao = 2015;
            objetoCarro.Cor = "Preto";
            objetoCarro.Fabricante = "Hyundai";
            objetoCarro.kmRodada = 1523;
            objetoCarro.Modelo = "Sonata";
            objetoCarro.NumeroDePortas = 5;
            objetoCarro.Placa = "GOI-1234";
            objetoCarro.TipoDeCambio = "Manual";
            objetoCarro.usado = true;
            objetoCarro.valor = 100000.32;

            // um objeto carro foi criado no nosso programa e agora ele armazena os dados fornecidos

            //Agora usaremos os métodos;

            objetoCarro.Ligar();

            Console.WriteLine("O carro tá ligado!" + "\n" + objetoCarro.Modelo);
            Console.WriteLine(objetoCarro.Ligado);
            // Agora desligar o carro
            objetoCarro.Desligar();
            Console.WriteLine("O carro tá desligado!" + "\n" + objetoCarro.Modelo);
            Console.WriteLine(objetoCarro.Ligado);
            Console.ReadKey();
            Console.Clear();
            //aluno

            objetoaluno.CPF = "123456";
            objetoaluno.dataAula = DateTime.Now; // data atual
            objetoaluno.idade = 10;
            objetoaluno.matricula = 123;
            objetoaluno.nome = "Joaozinho123vrau";
            objetoaluno.sexo = 'M';
            objetoaluno.turma = "3B";

            objetoaluno.RegistrarPresenca();
            Console.WriteLine("O aluno está presente!" + "\n" + objetoaluno.nome + " no dia " + objetoaluno.dataAula.ToString("dd/MM/yyyy"));
            Console.WriteLine(objetoaluno.frequencia);
            objetoaluno.RegistrarAusencia();
            Console.WriteLine("O aluno está ausente!" + "\n" + objetoaluno.nome + " no dia " + objetoaluno.dataAula.ToString("dd/MM/yyyy"));
            Console.WriteLine(objetoaluno.frequencia);


            Console.ReadKey();

        }
    }
}
