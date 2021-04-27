using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class RestauranteBLL : PontoTuristicoBLL
    {
        private int codigo;
        private string nome, endereco, categoria;
        private int idCidade;
        private int idHotel;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public int IdCidade { get => idCidade; set => idCidade = value; }
        public int IdHotel { get => idHotel; set => idHotel = value; }


        // private int codigo_hotel;



        private Conexao dao = new Conexao();

        public void InserirRestaurante()
        {
            try
            {
                string inserir = string.Format($@"INSERT INTO restaurante VALUES(NULL,'{Nome}',
                                                                             '{Endereco}',
                                                                             '{IdCidade}',
                                                                             '{IdHotel}');");
                dao.ExecutarComando(inserir);
            }
            catch (Exception e)
            {
                throw new Exception("Erro no insert xD");
            }

        }

        public void AlterarRestaurante()
        {
            try
            {
                string alterar = string.Format($@"UPDATE restaurante SET 
                                                                   nomeRestaurante = '{Nome}',
                                                                   enderecoRestaurante = '{Endereco}',
                                                                   Cidade_idCidade = '{IdCidade}',
                                                                   Hotel_idHotel = '{IdHotel}'
                                                             where idRestaurante = '{Id}';");
                dao.ExecutarComando(alterar);
            }
           
            catch (Exception e)
            {
                throw new Exception("Erro no update xD");
            }
        }

        public void ExcluirRestaurante()
        {
            try
            {
                string excluir = string.Format($@"DELETE FROM restaurante where idRestaurante = '{Id}'");
                dao.ExecutarComando(excluir);
            }
            catch (Exception e)
            {
                throw new Exception("Erro no delete xD");
            }

        }

        public DataTable ListarRestaurante() // Utilizar o System.Data
        {
            try
            {
                return dao.ExecutarConsulta($@"SELECT * FROM restaurante ORDER BY nomeRestaurante;");
            }
            catch (Exception e)
            {
                throw new Exception("Erro no listar sem parametro xD");
            }

        }
        public DataTable ListarRestaurante(string sql)
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