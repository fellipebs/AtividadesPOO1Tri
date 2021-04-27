using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class HotelBLL : PontoTuristicoBLL
    {
        private int codigo, numero_quartos;
        private string nome, categoria, tipo_de_quarto;

        public int Codigo { get => codigo; set => codigo = value; }
        public int Numero_quartos { get => numero_quartos; set => numero_quartos = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Tipo_de_quarto { get => tipo_de_quarto; set => tipo_de_quarto = value; }
        public int IdCidade { get => idCidade; set => idCidade = value; }

        private int idCidade;
        // private double diaria;


        private Conexao dao = new Conexao();

        public void InserirHotel()
        {
            try {
                string inserir = string.Format($@"INSERT INTO hotel VALUES(NULL,'{Nome}',
                                                                            '{Endereco}',
                                                                            '{Categoria}',
                                                                            '{IdCidade}');");
                dao.ExecutarComando(inserir);
            }
          
              catch (Exception e)
            {
                throw new Exception("Erro no insert xD");
            }
        }

        public void AlterarHotel()
        {
            try {

                string alterar = string.Format($@"UPDATE hotel SET 
                                                                   nomeHotel = '{Nome}',
                                                                   enderecoHotel = '{Endereco}',
                                                                   categoriaHotel = '{Categoria}',
                                                                   Cidade_idCidade = '{IdCidade}'
                                                             where idHotel = '{Id}';");
                dao.ExecutarComando(alterar);
            }
            catch (Exception e)
            {
                throw new Exception("Erro no update xD");
            }

        }

        public void ExcluirHotel()
        {
            try
            {
             string excluir = string.Format($@"DELETE FROM hotel where idHotel = '{Id}'");
             dao.ExecutarComando(excluir);
            }
            catch (Exception e)
            {
                throw new Exception("Erro no delete xD");
            }
            
        }

        public DataTable ListarHotel() // Utilizar o System.Data
        {
            try
            {
            return dao.ExecutarConsulta($@"SELECT * FROM hotel ORDER BY nomeHotel;");
            }
            catch (Exception e)
            {
                throw new Exception("Erro no listarHotel sem parametro xD");
            }

        }
        public DataTable ListarHotel(string sql)
        {
            try
            {
            return dao.ExecutarConsulta(sql);
            }
            catch (Exception e)
            {
                throw new Exception("Erro no listarHotel com parametro xD");
            }


        }
    }
}