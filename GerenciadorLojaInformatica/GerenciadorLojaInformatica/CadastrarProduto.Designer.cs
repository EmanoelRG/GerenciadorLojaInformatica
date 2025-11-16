namespace GerenciadorLojaInformatica
{
    partial class CadastrarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarProduto));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbCategoria = new ComboBox();
            txtDescricao = new TextBox();
            txtValor = new TextBox();
            numQuantidade = new NumericUpDown();
            btnSalvar = new Button();
            btnLimpar = new Button();
            btnCancelar = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 142);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 0;
            label1.Text = "Descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(62, 191);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 1;
            label2.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(104, 252);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 2;
            label3.Text = "Valor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 306);
            label4.Name = "label4";
            label4.Size = new Size(122, 28);
            label4.TabIndex = 3;
            label4.Text = "Quantidade";
            // 
            // cmbCategoria
            // 
            cmbCategoria.AutoCompleteCustomSource.AddRange(new string[] { "Hardware", "Periféricos", "Desktops", "Notebooks", "SmartPhones" });
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Hardware", "Periféricos", "SmartPhones", "Desktops", "Notebooks" });
            cmbCategoria.Location = new Point(171, 191);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(226, 36);
            cmbCategoria.TabIndex = 4;
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescricao.Location = new Point(171, 136);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(465, 34);
            txtDescricao.TabIndex = 5;
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtValor.Location = new Point(170, 246);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(226, 34);
            txtValor.TabIndex = 6;
            // 
            // numQuantidade
            // 
            numQuantidade.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numQuantidade.Location = new Point(171, 300);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(93, 34);
            numQuantidade.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(73, 391);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(157, 54);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Image = (Image)resources.GetObject("btnLimpar.Image");
            btnLimpar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpar.Location = new Point(263, 391);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Padding = new Padding(5, 0, 0, 0);
            btnLimpar.Size = new Size(157, 54);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.TextAlign = ContentAlignment.MiddleLeft;
            btnLimpar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(459, 391);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(5, 0, 0, 0);
            btnCancelar.Size = new Size(157, 54);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleLeft;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MediumBlue;
            label5.Location = new Point(170, 38);
            label5.Name = "label5";
            label5.Size = new Size(350, 46);
            label5.TabIndex = 11;
            label5.Text = "Cadastro de Produto";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 92);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // CadastrarProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(700, 484);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(numQuantidade);
            Controls.Add(txtValor);
            Controls.Add(txtDescricao);
            Controls.Add(cmbCategoria);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastrarProduto";
            Text = "CadastrarProduto";
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbCategoria;
        private TextBox txtDescricao;
        private TextBox txtValor;
        private NumericUpDown numQuantidade;
        private Button btnSalvar;
        private Button btnLimpar;
        private Button btnCancelar;
        private Label label5;
        private PictureBox pictureBox1;
    }
}