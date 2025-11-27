using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GerenciadorLojaInformatica
{
    internal class Conexao_db
    {
        //caminho para o banco de dados
        string sql = "server=localhost;user=root;password=;database=lojainformatica";
        //variável que percorre a minha string e conecta ao banco de dados
        public MySqlConnection conexao;
        //Construtor que inicializa minha variável de conexão passando o meu "caminho" sql como parametro
        public Conexao_db()
        { 
            conexao = new MySqlConnection(sql);
        }
        //contrução de métodos para a abertura e fechamento do bando de dados
        public void AbrirBanco()
        {
            try
            {
                if(conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco" + ex.Message);
            }
            
        }
        public void FecharBanco()
        {
            if(conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }

    }
}
