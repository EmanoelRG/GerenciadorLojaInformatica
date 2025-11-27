using System;
using System.Drawing;
using System.Windows.Forms;

namespace GerenciadorLojaInformatica
{
    public partial class MenuPagamento : Form
    {
        // Variáveis visuais criadas via código
        private Label lblParcelas;
        private ComboBox cbParcelas;
        private Label lblResumoValores;
        private Button btnFinalizar;

        // Variável para guardar o valor recebido do carrinho
        private decimal _valorVenda;

        // CONSTRUTOR: Agora exige um valor decimal para abrir
        public MenuPagamento(decimal valorRecebido)
        {
            InitializeComponent();

            _valorVenda = valorRecebido; // Guarda o valor

            ConfigurarControlesDinamicos();

            // Eventos para atualizar a tela quando trocar a opção
            radioCredito.CheckedChanged += (s, e) => AtualizarInterface();
            radioDebito.CheckedChanged += (s, e) => AtualizarInterface();
            radioPix.CheckedChanged += (s, e) => AtualizarInterface();

            AtualizarInterface(); // Roda a primeira vez para ajustar a tela
        }

        private void ConfigurarControlesDinamicos()
        {
           
            this.Size = new Size(450, 350);

            
            lblParcelas = new Label { Text = "Qtd Parcelas:", Location = new Point(10, 15), AutoSize = true };

            cbParcelas = new ComboBox { Location = new Point(100, 12), Width = 80, DropDownStyle = ComboBoxStyle.DropDownList };
            for (int i = 1; i <= 12; i++) cbParcelas.Items.Add($"{i}x");
            cbParcelas.SelectedIndex = 0;
            cbParcelas.SelectedIndexChanged += (s, e) => AtualizarResumoPreco();

            pnlPagamento.Controls.Add(lblParcelas);
            pnlPagamento.Controls.Add(cbParcelas);


            lblResumoValores = new Label
            {
                Location = new Point(20, 210), // Posição X=20, Y=210
                AutoSize = true,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                Text = $"Total: {_valorVenda:C2}"
            };
            this.Controls.Add(lblResumoValores);

            
            btnFinalizar = new Button
            {
                Text = "CONFIRMAR PAGAMENTO",
                Size = new Size(200, 45),
                Location = new Point(210, 250), 
                BackColor = Color.LightGreen,
                Cursor = Cursors.Hand 
            };
            btnFinalizar.Click += BtnFinalizar_Click;
            this.Controls.Add(btnFinalizar);
        }

        private void AtualizarInterface()
        {
            // Só mostra painel de parcelas se for Crédito
            pnlPagamento.Visible = radioCredito.Checked;
            AtualizarResumoPreco();
        }

        private void AtualizarResumoPreco()
        {
            if (radioPix.Checked || radioDebito.Checked)
            {
                lblResumoValores.Text = $"À vista: {_valorVenda:C2}";
                lblResumoValores.ForeColor = Color.Green;
            }
            else if (radioCredito.Checked)
            {
                int qtdParcelas = cbParcelas.SelectedIndex + 1;
                decimal valorParcela = _valorVenda / qtdParcelas;
                lblResumoValores.Text = $"Total: {_valorVenda:C2}\n{qtdParcelas}x de {valorParcela:C2}";
                lblResumoValores.ForeColor = Color.DarkBlue;
            }
            else
            {
                lblResumoValores.Text = "Selecione a forma de pagamento";
                lblResumoValores.ForeColor = Color.Red;
            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            IPagamentoStrategy pagamento = null;

            if (radioPix.Checked) pagamento = new PagamentoPix();
            else if (radioDebito.Checked) pagamento = new PagamentoDebito();
            else if (radioCredito.Checked)
            {
                int parcelas = cbParcelas.SelectedIndex + 1;
                pagamento = new PagamentoCredito(parcelas);
            }
            else
            {
                MessageBox.Show("Selecione uma forma de pagamento!");
                return;
            }

            // Executa o pagamento
            pagamento.Pagar(_valorVenda);

            // Fecha a tela de pagamento e retorna OK para a tela de vendas
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}