using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class IgrejaBLL : PontoTuristicoBLL
    {
        private DateTime data_construcao;
        private string estilo;
        private int idCidade;

        public DateTime Data_construcao { get => data_construcao; set => data_construcao = value; }
        public string Estilo {
            get
            {
            return estilo;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new Exception("Preencha com amor e carinho o estilo desta igrejinha do inferno");
                }
                else
                {
                    estilo = value;
                }
            }
        }
        public int IdCidade { get => idCidade; set => idCidade = value; }

        //creation of the object that connects this to DAL

        private Conexao dao = new Conexao(); // <---- Same as PHP :D

        //Creating CRUD:

        public void InserirIgreja()
        {
            try
            {
                string inserir = string.Format($@"INSERT INTO igreja VALUES(NULL,'{Descricao}',
                                                                             '{Endereco}',
                                                                             '{Data_construcao.ToString("yyyy/MM/dd")}',
                                                                             '{Estilo}',
                                                                             '{IdCidade}');");
                dao.ExecutarComando(inserir);
            }
            catch(Exception e) 
            {
                throw new Exception("Erro no insert xD");
            }
          
        }

        public void AlterarIgreja()
        {
            try
            {
                string alterar = string.Format($@"UPDATE igreja SET 
                                                                   descricaoIgreja = '{Descricao}',
                                                                   enderecoIgreja = '{Endereco}',
                                                                   dataIgreja = '{Data_construcao.ToString("yyyy/MM/dd")}',
                                                                   estiloIgreja = '{Estilo}',
                                                                   Cidade_idCidade = '{IdCidade}'
                                                             where idIgreja = '{Id}';");
                dao.ExecutarComando(alterar);
            }
            catch (Exception e)
            {
                throw new Exception("Erro no Update xD");
            }


        }

        public void ExcluirIgreja()
        {
            try
            {
                string excluir = string.Format($@"DELETE FROM igreja where idIgreja = '{Id}'");
                dao.ExecutarComando(excluir);
            }
         
             catch (Exception e)
            {
                throw new Exception("Erro no delete xD");
            }
        }

        public DataTable ListarIgrejas() // Utilizar o System.Data
        {
            try
            {
                return dao.ExecutarConsulta($@"SELECT * FROM igreja ORDER BY descricaoIgreja;");
            }
            catch (Exception e)
            {
                throw new Exception("Erro no select da listar Igreja xD (sem parametro)");
            }

        }
        public DataTable ListarIgrejas(string sql) 
        {
            try
            {
                return dao.ExecutarConsulta(sql);
            }
            catch (Exception e)
            {
                throw new Exception("Erro no select da listar Igreja xD (com parametro)");
            }

        }
    }
}
