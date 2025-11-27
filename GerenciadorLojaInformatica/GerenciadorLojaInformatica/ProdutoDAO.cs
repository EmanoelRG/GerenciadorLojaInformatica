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
        //
        //Método para cadastrar produto
        //
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

                //executa o comando da query
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
        //
        //fim do metodo CadastrarProduto
        //

        //
        //Começo método que lista todos os produtos no DataGrid
        //
        public DataTable ListarProdutos()
        {
                conexaoProduto.AbrirBanco();
                //criação da query e comando que vai executar ela no banco de dados 
                string sql_buscar = "SELECT * FROM produtos";
                MySqlCommand listar = new MySqlCommand(sql_buscar,conexaoProduto.conexao);

                MySqlDataAdapter dados = new MySqlDataAdapter(listar);

                DataTable tabela = new DataTable();

                dados.Fill(tabela);

                return tabela;
                
                conexaoProduto.FecharBanco();
        }
        //
        //Fim do Método de listagem

        //
        //Método de busca usando a descrição do produto como filtro
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
        //
        //Fim do método de busca por filtro 

        //
        //Método de alterar o produto imprimindo as informações no formulário
        public Produto PegarProduto(int id)
        {
            Produto produto = new Produto();
            try
            {
                conexaoProduto.AbrirBanco();
                string sql = "SELECT * FROM produtos WHERE id=@id";
                MySqlCommand leitura = new MySqlCommand(sql, conexaoProduto.conexao);
                leitura.Parameters.AddWithValue("@id", id);

                var leitor = leitura.ExecuteReader() ;
                if (leitor.HasRows)
                {
                    if (leitor.Read())
                    {
                        produto.Id = Convert.ToInt32(leitor["id"]);
                        produto.Descricao = leitor["descricao"].ToString();
                        produto.Categoria = leitor["categoria"].ToString();
                        produto.Valor = Convert.ToDouble(leitor["valor"]);
                        produto.Quantidade = Convert.ToInt32(leitor["quantidade"]);

                    }
                }
                return produto;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao buscar produto"+ ex.Message);
                return null;
            }
            finally
            {
                conexaoProduto.FecharBanco();
            }
        }
        //
        //Método para atualizar o produto 
        public bool AtualizarProduto(Produto produto)
        {
           
            try
            {
                conexaoProduto.AbrirBanco();
                string sql = @"UPDATE produtos SET descricao = @descricao, categoria = @categoria," +
                           " valor = @valor, quantidade = @quantidade WHERE id = @id";
                MySqlCommand atualizar = new MySqlCommand(sql, conexaoProduto.conexao);

                atualizar.Parameters.AddWithValue("@descricao", produto.Descricao);
                atualizar.Parameters.AddWithValue("@categoria", produto.Categoria);
                atualizar.Parameters.AddWithValue("@valor", produto.Valor);
                atualizar.Parameters.AddWithValue("@quantidade", produto.Quantidade);
                atualizar.Parameters.AddWithValue("@id", produto.Id);

                atualizar.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar produto!", ex.Message);
                return false;
            }
            finally
            {
                conexaoProduto.FecharBanco();
            }
        }
        public bool DeletarProduto(Produto produto)
        {

            try
            {
                conexaoProduto.AbrirBanco();
                string sql = @"DELETE FROM produtos WHERE id = @id";
                MySqlCommand deletar = new MySqlCommand(sql, conexaoProduto.conexao);
                deletar.Parameters.AddWithValue("@id", produto.Id);

                deletar.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar produto!", ex.Message);
                return false;
            }
            finally
            {
                conexaoProduto.FecharBanco();
            }
        }
    }
}
