using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GerenciadorLojaInformatica
{
    public class VendaDAO
    {
        // Método para Registrar a Venda Completa
        public bool RegistrarVenda(decimal valorTotal, DataTable itensCarrinho)
        {
            Conexao_db conexao = new Conexao_db();
            MySqlConnection con = conexao.conexao; // Acessa a conexão da sua classe
            MySqlTransaction transacao = null;

            try
            {
                conexao.AbrirBanco();

                // Inicia a transação 
                transacao = con.BeginTransaction();

                
                string sqlVenda = "INSERT INTO vendas (data_venda, valor_total) VALUES (NOW(), @total)";
                MySqlCommand cmdVenda = new MySqlCommand(sqlVenda, con, transacao);
                cmdVenda.Parameters.AddWithValue("@total", valorTotal);
                cmdVenda.ExecuteNonQuery();

             
                long idVenda = cmdVenda.LastInsertedId;

                
                foreach (DataRow row in itensCarrinho.Rows)
                {
                    int idProduto = Convert.ToInt32(row["ID"]);
                    int qtd = Convert.ToInt32(row["Qtd"]);
                    decimal subtotal = Convert.ToDecimal(row["Subtotal"]);

                   
                    string sqlItem = "INSERT INTO itens_venda (venda_id, produto_id, quantidade, subtotal) " +
                                     "VALUES (@venda, @prod, @qtd, @sub)";
                    MySqlCommand cmdItem = new MySqlCommand(sqlItem, con, transacao);
                    cmdItem.Parameters.AddWithValue("@venda", idVenda);
                    cmdItem.Parameters.AddWithValue("@prod", idProduto);
                    cmdItem.Parameters.AddWithValue("@qtd", qtd);
                    cmdItem.Parameters.AddWithValue("@sub", subtotal);
                    cmdItem.ExecuteNonQuery();

                    
                    string sqlEstoque = "UPDATE produtos SET quantidade = quantidade - @qtd WHERE id = @prod";
                    MySqlCommand cmdEstoque = new MySqlCommand(sqlEstoque, con, transacao);
                    cmdEstoque.Parameters.AddWithValue("@qtd", qtd);
                    cmdEstoque.Parameters.AddWithValue("@prod", idProduto);
                    cmdEstoque.ExecuteNonQuery();
                }

                
                transacao.Commit();
                return true;
            }
            catch (Exception ex)
            {
                // Se deu erro, desfaz tudo o que tentou salvar
                if (transacao != null) transacao.Rollback();
                MessageBox.Show("Erro ao registrar venda: " + ex.Message);
                return false;
            }
            finally
            {
                conexao.FecharBanco();
            }
        }
    }
}