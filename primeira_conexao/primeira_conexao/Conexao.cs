using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace primeira_conexao
{
    public class Conexao
    {
        MySqlConnection conexao;
        private string string_conexao = "Persist security info = false; server = localhost; database = NomeDoDB; user = root; pwd =;";
        
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
            
        }
    }
}
