using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PontoTuristicoBLL
    {
        // mudar namespace e deixar a classe pública!
        private int id;
        private string endereco;
        private string descricao;

        public int Id { get => id; set => id = value; }
        public string Endereco
        {
            get
            {
                return endereco;
            }
            set {
                if (value == string.Empty)
                {
                    throw new Exception("Preencha o endereco");
                }
                else
                {
                    endereco = value;
                }
            }
        }
        public string Descricao {
            get
            {
            return descricao;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new Exception("Preencha a Descricao");
                }
                else
                {
                    descricao = value;
                }

            }
        }

    }
}
