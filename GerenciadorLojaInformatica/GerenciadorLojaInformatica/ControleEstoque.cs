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
    public partial class ControleEstoque : Form
    {
        public ControleEstoque()
        {
            InitializeComponent();
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            CadastrarProduto cadastrarProduto = new CadastrarProduto();
            cadastrarProduto.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarProduto alterarProduto = new AlterarProduto();
            alterarProduto.ShowDialog();
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            ExcluirProduto excluirProduto = new ExcluirProduto();
            excluirProduto.ShowDialog();
        }

        private void ControleEstoque_Load(object sender, EventArgs e)
        {
            //comando para imprimir os dados no DataGrid
            ProdutoDAO dao = new ProdutoDAO();
            dgvListarProdutos.DataSource = dao.ListarProdutos();

        }
    }
}
