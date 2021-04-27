using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    class Conexao
    {
        MySqlConnection conexao;
        private string string_conexao = "Persist security info = false; server = localhost; database = bd_escola_poo; user = root; pwd =;";

        //"Primeiro" método que servira para conectar ao DB e irá abri-lo.

        private void Conectar()
        {
            conexao = new MySqlConnection(string_conexao);
            conexao.Open();
        }

        public void ExecutarComando(string sql)  // O mesmo método para executar INSERT, UPDATE E DELETE.
        {
            Conectar();
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public DataTable ExecutarConsulta(string sql)
        {
            Conectar();
            DataTable dados = new DataTable(); // Cria-se uma tabela temporaria na memoria apenas para retornar o select;
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao);
            da.Fill(dados);
            conexao.Close();
            return dados;
        }

    }
}

