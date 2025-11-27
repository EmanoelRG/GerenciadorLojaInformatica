namespace GerenciadorLojaInformatica
{
    partial class ControleEstoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControleEstoque));
            dgvListarProdutos = new DataGridView();
            btnCadProduto = new Button();
            btnAlterar = new Button();
            btnExcluirProduto = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtDescricaoProduto = new TextBox();
            btnBuscar = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListarProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvListarProdutos
            // 
            dgvListarProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvListarProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListarProdutos.Location = new Point(40, 309);
            dgvListarProdutos.Name = "dgvListarProdutos";
            dgvListarProdutos.RowHeadersWidth = 51;
            dgvListarProdutos.Size = new Size(715, 377);
            dgvListarProdutos.TabIndex = 0;
            dgvListarProdutos.CellClick += dgvListarProdutos_CellClick;
            dgvListarProdutos.CellContentClick += dgvListarProdutos_CellContentClick;
            // 
            // btnCadProduto
            // 
            btnCadProduto.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadProduto.Image = (Image)resources.GetObject("btnCadProduto.Image");
            btnCadProduto.Location = new Point(40, 216);
            btnCadProduto.Name = "btnCadProduto";
            btnCadProduto.Size = new Size(228, 64);
            btnCadProduto.TabIndex = 1;
            btnCadProduto.Text = "Cadastrar Produto";
            btnCadProduto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadProduto.UseVisualStyleBackColor = true;
            btnCadProduto.Click += btnCadProduto_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.Image = (Image)resources.GetObject("btnAlterar.Image");
            btnAlterar.Location = new Point(283, 216);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(206, 64);
            btnAlterar.TabIndex = 2;
            btnAlterar.Text = "Alterar Produto";
            btnAlterar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluirProduto
            // 
            btnExcluirProduto.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluirProduto.Image = (Image)resources.GetObject("btnExcluirProduto.Image");
            btnExcluirProduto.Location = new Point(510, 216);
            btnExcluirProduto.Name = "btnExcluirProduto";
            btnExcluirProduto.Size = new Size(191, 64);
            btnExcluirProduto.TabIndex = 3;
            btnExcluirProduto.Text = "Excluir Produto";
            btnExcluirProduto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExcluirProduto.UseVisualStyleBackColor = true;
            btnExcluirProduto.Click += btnExcluirProduto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(133, 27);
            label1.Name = "label1";
            label1.Size = new Size(447, 50);
            label1.TabIndex = 4;
            label1.Text = "CONTROLE DE ESTOQUE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // txtDescricaoProduto
            // 
            txtDescricaoProduto.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescricaoProduto.Location = new Point(40, 149);
            txtDescricaoProduto.Name = "txtDescricaoProduto";
            txtDescricaoProduto.Size = new Size(520, 30);
            txtDescricaoProduto.TabIndex = 6;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(566, 145);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(135, 34);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 123);
            label2.Name = "label2";
            label2.Size = new Size(155, 23);
            label2.TabIndex = 8;
            label2.Text = "Nome do produto";
            // 
            // ControleEstoque
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(904, 698);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(txtDescricaoProduto);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnExcluirProduto);
            Controls.Add(btnAlterar);
            Controls.Add(btnCadProduto);
            Controls.Add(dgvListarProdutos);
            Name = "ControleEstoque";
            Text = "Estoque";
            Load += ControleEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListarProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListarProdutos;
        private Button btnCadProduto;
        private Button btnAlterar;
        private Button btnExcluirProduto;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtDescricaoProduto;
        private Button btnBuscar;
        private Label label2;
    }
}