namespace GerenciadorLojaInformatica
{
    partial class ExcluirProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcluirProduto));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbCatDelete = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            txtValorDelete = new TextBox();
            txtDescDelete = new TextBox();
            btnDelete = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(174, 55);
            label1.Name = "label1";
            label1.Size = new Size(259, 46);
            label1.TabIndex = 0;
            label1.Text = "ExcluirProduto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 129);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 1;
            label2.Text = "Descricao";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 185);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 2;
            label3.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(98, 244);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 3;
            label4.Text = "Valor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 296);
            label5.Name = "label5";
            label5.Size = new Size(122, 28);
            label5.TabIndex = 4;
            label5.Text = "Quantidade";
            // 
            // cmbCatDelete
            // 
            cmbCatDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCatDelete.FormattingEnabled = true;
            cmbCatDelete.Items.AddRange(new object[] { "Hardware", "Periféricos", "SmartPhones", "Desktops", "Notebooks" });
            cmbCatDelete.Location = new Point(174, 185);
            cmbCatDelete.Name = "cmbCatDelete";
            cmbCatDelete.Size = new Size(259, 36);
            cmbCatDelete.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(174, 290);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 34);
            numericUpDown1.TabIndex = 6;
            // 
            // txtValorDelete
            // 
            txtValorDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtValorDelete.Location = new Point(174, 238);
            txtValorDelete.Name = "txtValorDelete";
            txtValorDelete.Size = new Size(259, 34);
            txtValorDelete.TabIndex = 7;
            // 
            // txtDescDelete
            // 
            txtDescDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescDelete.Location = new Point(174, 123);
            txtDescDelete.Name = "txtDescDelete";
            txtDescDelete.Size = new Size(437, 34);
            txtDescDelete.TabIndex = 8;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(151, 390);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 51);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Excluir";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(319, 390);
            button1.Name = "button1";
            button1.Size = new Size(154, 51);
            button1.TabIndex = 10;
            button1.Text = "Cancelar";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(82, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 89);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // ExcluirProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(669, 464);
            Controls.Add(button1);
            Controls.Add(btnDelete);
            Controls.Add(txtDescDelete);
            Controls.Add(txtValorDelete);
            Controls.Add(numericUpDown1);
            Controls.Add(cmbCatDelete);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "ExcluirProduto";
            Text = "ExcluirProduto";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbCatDelete;
        private NumericUpDown numericUpDown1;
        private TextBox txtValorDelete;
        private TextBox txtDescDelete;
        private Button btnDelete;
        private Button button1;
        private PictureBox pictureBox1;
    }
}