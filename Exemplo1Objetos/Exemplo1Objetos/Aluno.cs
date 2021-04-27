using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1Objetos
{
    public class Aluno
    {
        public string nome, CPF;
        public int matricula, idade;
        public char sexo;
        public string turma;
        public DateTime dataAula; // dataAula será preenchida com a data atual DateTime.Now
        public char frequencia; //P = Presente or F = Falta

        public void  RegistrarPresenca()
        {
            frequencia = 'P';
        }

        public void RegistrarAusencia()
        {
            frequencia = 'F';
        }
    }
}
