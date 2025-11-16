namespace GerenciadorLojaInformatica
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {

        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            ControleEstoque controleEstoque = new ControleEstoque();
            controleEstoque.ShowDialog();
        }
    }
}
