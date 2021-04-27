using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class CidadeBLL

    {
        private Conexao dao = new Conexao();
        private int codigo;
        private string nome, estado;
        private int populacao;



        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome {
            get
            {
            return nome;
            }
            set
            {
                if(value == string.Empty)
                {
                    throw new Exception("Nome de preenchimento obrigatório");
                }
                else
                {
                    nome = value;
                }
            }
        }
        public string Estado {
            get
            {
                return estado;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new Exception("Estado de preenchimento obrigatório");
                }
                else
                {
                    estado = value;
                }
            }
        }
        public int Populacao { get => populacao; set => populacao = value; }

        
        public DataTable ListarCidades() // Utilizar o System.Data
        {
            return dao.ExecutarConsulta($@"SELECT * FROM cidade ORDER BY nomeCidade;");
        }
        public DataTable ListarCidades(string sql)
        {
            return dao.ExecutarConsulta(sql);
        }
    }
}
