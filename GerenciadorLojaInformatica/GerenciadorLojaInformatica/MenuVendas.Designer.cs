namespace GerenciadorLojaInformatica
{
    partial class MenuVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVendas));
            txtVendas = new Label();
            dgvVendaProdutos = new DataGridView();
            dgvCarrinho = new DataGridView();
            lblTotal = new Label();
            panel1 = new Panel();
            txtTotal = new Label();
            btnLimparCarrinho = new Button();
            btnFinalizarCompra = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVendaProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtVendas
            // 
            txtVendas.AutoSize = true;
            txtVendas.Font = new Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtVendas.ForeColor = Color.Coral;
            txtVendas.Location = new Point(164, 31);
            txtVendas.Name = "txtVendas";
            txtVendas.Size = new Size(305, 89);
            txtVendas.TabIndex = 5;
            txtVendas.Text = "VENDAS";
            // 
            // dgvVendaProdutos
            // 
            dgvVendaProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvVendaProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendaProdutos.Location = new Point(14, 155);
            dgvVendaProdutos.Name = "dgvVendaProdutos";
            dgvVendaProdutos.RowHeadersWidth = 51;
            dgvVendaProdutos.Size = new Size(573, 459);
            dgvVendaProdutos.TabIndex = 8;
            // 
            // dgvCarrinho
            // 
            dgvCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrinho.Location = new Point(656, 155);
            dgvCarrinho.Margin = new Padding(3, 4, 3, 4);
            dgvCarrinho.Name = "dgvCarrinho";
            dgvCarrinho.RowHeadersWidth = 51;
            dgvCarrinho.Size = new Size(562, 242);
            dgvCarrinho.TabIndex = 9;
            dgvCarrinho.CellContentClick += dgvCarrinho_CellContentClick;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(85, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(105, 32);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "R$: 0,00";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtTotal);
            panel1.Controls.Add(lblTotal);
            panel1.Location = new Point(986, 416);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 42);
            panel1.TabIndex = 11;
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(5, 0);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(78, 32);
            txtTotal.TabIndex = 11;
            txtTotal.Text = "Total:";
            // 
            // btnLimparCarrinho
            // 
            btnLimparCarrinho.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimparCarrinho.Image = (Image)resources.GetObject("btnLimparCarrinho.Image");
            btnLimparCarrinho.Location = new Point(656, 416);
            btnLimparCarrinho.Name = "btnLimparCarrinho";
            btnLimparCarrinho.Size = new Size(205, 57);
            btnLimparCarrinho.TabIndex = 12;
            btnLimparCarrinho.Text = "Limpar Carrinho";
            btnLimparCarrinho.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimparCarrinho.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarCompra
            // 
            btnFinalizarCompra.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizarCompra.Image = (Image)resources.GetObject("btnFinalizarCompra.Image");
            btnFinalizarCompra.Location = new Point(656, 498);
            btnFinalizarCompra.Name = "btnFinalizarCompra";
            btnFinalizarCompra.Size = new Size(205, 64);
            btnFinalizarCompra.TabIndex = 13;
            btnFinalizarCompra.Text = "Finalizar Compra";
            btnFinalizarCompra.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFinalizarCompra.UseVisualStyleBackColor = true;
            btnFinalizarCompra.Click += btnFinalizarCompra_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 118);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(656, 109);
            label1.Name = "label1";
            label1.Size = new Size(209, 31);
            label1.TabIndex = 15;
            label1.Text = "Itens selecionados";
            // 
            // MenuVendas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1232, 629);
            Controls.Add(label1);
            Controls.Add(txtVendas);
            Controls.Add(pictureBox1);
            Controls.Add(btnFinalizarCompra);
            Controls.Add(btnLimparCarrinho);
            Controls.Add(panel1);
            Controls.Add(dgvCarrinho);
            Controls.Add(dgvVendaProdutos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuVendas";
            Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)dgvVendaProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtVendas;
        private DataGridView dgvVendaProdutos;
        private DataGridView dgvCarrinho;
        private Label lblTotal;
        private Panel panel1;
        private Label txtTotal;
        private Button btnLimparCarrinho;
        private Button btnFinalizarCompra;
        private PictureBox pictureBox1;
        private Label label1;
    }
}