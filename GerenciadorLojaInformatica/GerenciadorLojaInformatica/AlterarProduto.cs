using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorLojaInformatica
{
    public partial class AlterarProduto : Form
    {
        //criando a variável id para receber o valor do id_parametro
        int id_produto;
        

        //o id_parametro é o que vai receber o id selecionado no DataGridView
        public AlterarProduto(int id_parametro)
        {
            InitializeComponent();
            //o id da classe recebe o parametro passado pela seleção no DataGrid
            this.id_produto = id_parametro;
            //vai servir para instanciar o método de PegarProduto(é o método que lê os resultados vindo do DB)
            ProdutoDAO produtoDAO = new ProdutoDAO();
            if (this.id_produto > 0)
            {
                Produto produto = produtoDAO.PegarProduto(this.id_produto);
                produtoDAO.PegarProduto(this.id_produto);
                lblID.Text = produto.Id.ToString();
                txtAlterDesc.Text = produto.Descricao.ToString();
                txtAlterValor.Text = produto.Valor.ToString();
                cmbAlterCat.Text = produto.Categoria.ToString();
                numAlterQnt.Text = produto.Quantidade.ToString();
            }
        }

        //
        //Botão de cancelar, não mudei o nome pois teria que mexer nos comandos de layout novamente.
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterSalvar_Click(object sender, EventArgs e)
        {
            // Criar objeto produto com os dados da tela
            Produto produto = new Produto();
            produto.Id = this.id_produto;
            produto.Descricao = txtAlterDesc.Text;
            produto.Categoria = cmbAlterCat.Text;
            produto.Valor = Convert.ToDouble(txtAlterValor.Text);
            produto.Quantidade = (int)numAlterQnt.Value;

            // Instanciar o DAO
            ProdutoDAO produtoDAO = new ProdutoDAO();

            // Chamar o método de atualização
            bool sucesso = produtoDAO.AtualizarProduto(produto);

            if (sucesso)
            {
                MessageBox.Show("Produto atualizado com sucesso!");
                this.Close(); // Fechar a janela de alteração
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o produto!");
            }

         }
    }
}
