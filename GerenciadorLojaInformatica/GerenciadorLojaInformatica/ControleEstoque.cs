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
            var id = Convert.ToInt32(dgvListarProdutos.Rows[dgvListarProdutos.CurrentCell.RowIndex].Cells["id"].Value);

            AlterarProduto alterarProduto = new AlterarProduto(id);
            alterarProduto.ShowDialog();

        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            if (dgvListarProdutos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um produto!");
                return;
            }

            int id = Convert.ToInt32(
                dgvListarProdutos.CurrentRow.Cells["id"].Value
            );

            var confirma = MessageBox.Show(
                "Deseja excluir este produto?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirma == DialogResult.Yes)
            {
                Produto p = new Produto { Id = id };
                ProdutoDAO dao = new ProdutoDAO();

                if (dao.DeletarProduto(p))
                {
                    MessageBox.Show("Produto excluído!");
                    dgvListarProdutos.DataSource = dao.ListarProdutos();
                }
            }

        }

        private void ControleEstoque_Load(object sender, EventArgs e)
        {
            //comando para imprimir os dados no DataGrid
            ProdutoDAO dao = new ProdutoDAO();
            dgvListarProdutos.DataSource = dao.ListarProdutos();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ProdutoDAO dao = new ProdutoDAO();
            dgvListarProdutos.DataSource = dao.Buscar(txtDescricaoProduto.Text);

        }

        private void dgvListarProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListarProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
