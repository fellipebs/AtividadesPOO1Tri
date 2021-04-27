using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class MuseuBLL : PontoTuristicoBLL
    {
        //ctrl+r+e
        private DateTime data_fundacao;
        private int n_salas;
        private int idCidade;

        public DateTime Data_fundacao { get => data_fundacao; set => data_fundacao = value; }
        public int N_salas {
            get {
                return n_salas;
            }
            set
            {
                if (value < 1){
                    throw new Exception("Por favor dê número de salas correto! Consagrado.");
                }
                else
                {
                    n_salas = value;
                }
            }  
                 }
        public int IdCidade { get => idCidade; set => idCidade = value; }

        private Conexao dao = new Conexao();

        public void InserirMuseu()
        {
            try
            {
                string inserir = string.Format($@"INSERT INTO museu VALUES(NULL,'{Descricao}',
                                                                             '{Endereco}',
                                                                             '{Data_fundacao.ToString("yyyy/MM/dd")}',
                                                                             '{N_salas}',
                                                                             '{IdCidade}')");
                dao.ExecutarComando(inserir);
            }
            catch(Exception e)
            {
                throw new Exception("Erro no insert.");
            }
           
        }

        public void AlterarMuseu()
        {
            try
            {
                string alterar = string.Format($@"UPDATE museu SET 
                                                                   descricaoMuseu = '{Descricao}',
                                                                   enderecoMuseu = '{Endereco}',
                                                                   dataMuseu = '{Data_fundacao.ToString("yyyy/MM/dd")}',
                                                                   salasMuseu = '{N_salas}',
                                                                   Cidade_idCidade = '{IdCidade}'
                                                             where idMuseu = '{Id}';");
                dao.ExecutarComando(alterar);
            }
            catch(Exception e)
            {
                throw new Exception("Erro no update xD");
            }
            
        }
        public void ExcluirMuseu()
        {
            try
            {
                string excluir = string.Format($@"DELETE FROM museu where idMuseu = '{Id}'");
                dao.ExecutarComando(excluir);
            }
            catch (Exception e)
            {
                throw new Exception("Erro no delete xD");
            }
        }

        public DataTable ListarMuseus() // Utilizar o System.Data
        {
            try
            {
             return dao.ExecutarConsulta($@"SELECT * FROM museu ORDER BY descricaoMuseu;");
            }
            catch (Exception e)
            {
                throw new Exception("Erro no listar sem parametro xD");
            }

        }
        public DataTable ListarMuseus(string sql)
        {
            try
            {
                return dao.ExecutarConsulta(sql);
            }
            catch (Exception e)
            {
                throw new Exception("Erro no listar com parametro xD");
            }
        }
    }
}