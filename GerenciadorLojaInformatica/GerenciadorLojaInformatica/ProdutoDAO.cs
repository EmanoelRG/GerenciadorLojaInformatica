using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GerenciadorLojaInformatica
{
    internal class ProdutoDAO
    {
        //chamando as classes para conectar e repassar os valores coletados no formulário
        Conexao_db conexaoProduto = new Conexao_db();
        Produto produto = new Produto();

        //Método para cadastrar produto
        public void CadastrarProduto(Produto produto)
        {
            try
            {
                conexaoProduto.AbrirBanco();
                //criando o comando sql para inserir o produto
                string sql_cad = "INSERT INTO produtos(descricao,categoria,valor,quantidade)" +
                    " VALUES(@descricao,@categoria,@valor,@quantidade)";

                MySqlCommand cadastrar = new MySqlCommand(sql_cad,conexaoProduto.conexao);
                cadastrar.Parameters.Add("@descricao", MySqlDbType.VarChar, 100).Value = produto.Descricao;
                cadastrar.Parameters.Add("@categoria", MySqlDbType.VarChar, 30).Value = produto.Categoria;
                cadastrar.Parameters.Add("@valor", MySqlDbType.Double).Value = produto.Valor;
                cadastrar.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = produto.Quantidade;

                cadastrar.ExecuteNonQuery();
                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produto" + ex.Message);
            }

             finally
            {
                conexaoProduto.FecharBanco();
            }
        }
        public DataTable ListarProdutos()
        {
                conexaoProduto.AbrirBanco();
                
                string sql_buscar = "SELECT * FROM produtos";
                MySqlCommand listar = new MySqlCommand(sql_buscar,conexaoProduto.conexao);

                MySqlDataAdapter dados = new MySqlDataAdapter(listar);

                DataTable tabela = new DataTable();

                dados.Fill(tabela);

                return tabela;
                
                conexaoProduto.FecharBanco();
        }
        public DataTable Buscar(string descricao)
        {
            DataTable tabela = new DataTable();

            try
            {
                conexaoProduto.AbrirBanco();

                string sql = "SELECT * FROM produtos WHERE 1=1";

                if (!string.IsNullOrEmpty(descricao))
                    sql += " AND descricao LIKE @descricao";

                //if (!string.IsNullOrEmpty(categoria))
                //    sql += " AND categoria = @categoria";

                MySqlCommand comando = new MySqlCommand(sql, conexaoProduto.conexao);

                if (!string.IsNullOrEmpty(descricao))
                    comando.Parameters.AddWithValue("@descricao", "%" + descricao + "%");

                //if (!string.IsNullOrEmpty(categoria))
                //    comando.Parameters.AddWithValue("@categoria", categoria);

                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(tabela);

                conexaoProduto.FecharBanco();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produtos: " + ex.Message);
            }

            return tabela;
        }


    }
}
