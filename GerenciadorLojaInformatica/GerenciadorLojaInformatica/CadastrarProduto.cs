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
    public partial class CadastrarProduto : Form
    {
        public CadastrarProduto()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto
            {
                Descricao = txtDescricao.Text,
                Categoria = cmbCategoria.Text,
                Valor = Convert.ToDouble(txtValor.Text),
                Quantidade = (int)numQuantidade.Value
            };
            ProdutoDAO produtoDAO = new ProdutoDAO();
            produtoDAO.CadastrarProduto(produto);
       
            txtDescricao.Clear();
            txtValor.Clear();
            cmbCategoria.SelectedIndex = -1;
            numQuantidade.Value = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear();
            txtValor.Clear();
            cmbCategoria.SelectedIndex = -1;
            numQuantidade.Value = 1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
