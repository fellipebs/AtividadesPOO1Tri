using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class OrdemServicoBLL
    {
        private DateTime data_chamado;
        private int id;
        private string descricao, departamento, nomeUsuario,  tecnicoResponsavel, situacaoOrdem;

        public DateTime Data_chamado { get => data_chamado; set => data_chamado = value; }
        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }
        public string TecnicoResponsavel { get => tecnicoResponsavel; set => tecnicoResponsavel = value; }
        public string SituacaoOrdem { get => situacaoOrdem; set => situacaoOrdem = value; }

        private Conexao dao = new Conexao();

        public void InserirOrdemServico()
        {
            string inserir = string.Format($@"INSERT INTO ordemservico VALUES(NULL,'{Descricao}',
                                                                             '{Departamento}',
                                                                             '{NomeUsuario}',
                                                                             '{Data_chamado.ToString("yyyy/MM/dd")}',
                                                                             '{TecnicoResponsavel}',
                                                                             '{SituacaoOrdem}');");
            dao.ExecutarComando(inserir);
        }

        public void AlterarOrdemServico()
        {


            string alterar = string.Format($@"UPDATE ordemservico SET 
                                                                   descricao = '{Descricao}',
                                                                   departamento = '{Departamento}',
                                                                   nomeUsuario = '{NomeUsuario}',
                                                                   dataChamado = '{Data_chamado.ToString("yyyy/MM/dd")}',
                                                                   tecnicoResponsavel = '{TecnicoResponsavel}',
                                                                   situacaoOrdem = '{SituacaoOrdem}'
                                                             where id = '{Id}';");
            dao.ExecutarComando(alterar);
        }

        public void ExcluirOrdemServico()
        {
            string excluir = string.Format($@"DELETE FROM ordemservico where id = '{Id}'");
            dao.ExecutarComando(excluir);
        }

        public DataTable ListarOrdemServico() // Utilizar o System.Data
        {
            return dao.ExecutarConsulta($@"SELECT * FROM ordemservico ORDER BY id;");
        }
        public DataTable ListarOrdemServico(string sql) //caso queira utilizar o select com um parametro xD 
        {
            return dao.ExecutarConsulta(sql);
        }
    }
}
