using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorLojaInformatica
{
    public partial class MenuVendas : Form
    {
        // DataTable global do carrinho
        DataTable dtCarrinho = new DataTable();
        decimal valorTotalVenda = 0;

        public MenuVendas()
        {
            InitializeComponent();


            this.Load += new EventHandler(MenuVendas_Load);

            // Grid
            dgvVendaProdutos.CellDoubleClick += new DataGridViewCellEventHandler(dgvVendaProdutos_CellDoubleClick);

            // Botões (Atenção: Os nomes devem ser iguais aos do Designer)
            // Se der erro aqui, verifique se o nome do botão no design é btnLimparCarrinho mesmo
            btnLimparCarrinho.Click += new EventHandler(btnLimparCarrinho_Click);
            btnFinalizarCompra.Click += new EventHandler(btnFinalizarCompra_Click);
        }

        private void MenuVendas_Load(object sender, EventArgs e)
        {
            CarregarListaProdutos();
            InicializarCarrinho();
        }

        // Método separado para poder recarregar a lista apos a venda
        private void CarregarListaProdutos()
        {
            try
            {
                ProdutoDAO dao = new ProdutoDAO();
                DataTable tabelaProdutos = dao.ListarProdutos();

                if (tabelaProdutos.Rows.Count > 0)
                {
                    dgvVendaProdutos.DataSource = tabelaProdutos;
                    ConfigurarGridProdutos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
        }

        private void ConfigurarGridProdutos()
        {
            dgvVendaProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVendaProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVendaProdutos.MultiSelect = false;
            dgvVendaProdutos.ReadOnly = true;

            if (dgvVendaProdutos.Columns.Contains("valor"))
                dgvVendaProdutos.Columns["valor"].DefaultCellStyle.Format = "C2";
        }

        private void InicializarCarrinho()
        {
            if (dtCarrinho.Columns.Count == 0)
            {
                dtCarrinho.Columns.Add("ID", typeof(int));
                dtCarrinho.Columns.Add("Produto", typeof(string));
                dtCarrinho.Columns.Add("Qtd", typeof(int));
                dtCarrinho.Columns.Add("Unitário", typeof(decimal));
                dtCarrinho.Columns.Add("Subtotal", typeof(decimal));
            }

            dgvCarrinho.DataSource = dtCarrinho;

            // Estilização
            dgvCarrinho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrinho.Columns["Unitário"].DefaultCellStyle.Format = "C2";
            dgvCarrinho.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
            dgvCarrinho.AllowUserToAddRows = false;
            dgvCarrinho.ReadOnly = true;
        }

        // ADICIONAR AO CARRINHO COM TRAVA DE ESTOQUE
        private void dgvVendaProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgvVendaProdutos.Rows[e.RowIndex];
                int idProduto = Convert.ToInt32(row.Cells["id"].Value);
                string nomeProduto = row.Cells["descricao"].Value.ToString();
                decimal precoUnitario = Convert.ToDecimal(row.Cells["valor"].Value);
                int estoqueDisponivel = Convert.ToInt32(row.Cells["quantidade"].Value);

                if (estoqueDisponivel <= 0)
                {
                    MessageBox.Show("Produto esgotado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool itemExiste = false;

                foreach (DataRow dr in dtCarrinho.Rows)
                {
                    if (Convert.ToInt32(dr["ID"]) == idProduto)
                    {
                        int novaQtd = Convert.ToInt32(dr["Qtd"]) + 1;

                        if (novaQtd > estoqueDisponivel)
                        {
                            MessageBox.Show($"Estoque insuficiente! Apenas {estoqueDisponivel} disponíveis.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }

                        dr["Qtd"] = novaQtd;
                        dr["Subtotal"] = novaQtd * precoUnitario;
                        itemExiste = true;
                        break;
                    }
                }

                if (!itemExiste)
                {
                    dtCarrinho.Rows.Add(idProduto, nomeProduto, 1, precoUnitario, precoUnitario);
                }

                RecalcularTotalVenda();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void RecalcularTotalVenda()
        {
            valorTotalVenda = 0;
            foreach (DataRow row in dtCarrinho.Rows)
            {
                valorTotalVenda += Convert.ToDecimal(row["Subtotal"]);
            }
            lblTotal.Text = valorTotalVenda.ToString("C2");
        }


        //LIMPAR CARRINHO
        private void btnLimparCarrinho_Click(object sender, EventArgs e)
        {
            if (dtCarrinho.Rows.Count > 0)
            {
                if (MessageBox.Show("Deseja limpar o carrinho?", "Limpar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dtCarrinho.Rows.Clear();
                    RecalcularTotalVenda();
                }
            }
        }


        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {





        }



        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void dgvCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void btnFinalizarCompra_Click_1(object sender, EventArgs e)
        {
            
            if (this.valorTotalVenda <= 0)
            {
                MessageBox.Show("O carrinho está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            MenuPagamento telaPagamento = new MenuPagamento(this.valorTotalVenda);

           
            DialogResult resultado = telaPagamento.ShowDialog();

            
            if (resultado == DialogResult.OK)
            {
                dtCarrinho.Rows.Clear();
                RecalcularTotalVenda();
                
            }

           
        }

        
    }
}