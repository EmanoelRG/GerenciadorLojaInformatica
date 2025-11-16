namespace GerenciadorLojaInformatica
{
    partial class AlterarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarProduto));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbAlterCat = new ComboBox();
            txtAlterDesc = new TextBox();
            txtAlterProd = new TextBox();
            numAlterQnt = new NumericUpDown();
            btnAlterSalvar = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numAlterQnt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(160, 40);
            label1.Name = "label1";
            label1.Size = new Size(338, 46);
            label1.TabIndex = 0;
            label1.Text = "ALTERAR PRODUTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 125);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 1;
            label2.Text = "Descricao";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 169);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 2;
            label3.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(84, 224);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 3;
            label4.Text = "Valor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 270);
            label5.Name = "label5";
            label5.Size = new Size(122, 28);
            label5.TabIndex = 4;
            label5.Text = "Quantidade";
            // 
            // cmbAlterCat
            // 
            cmbAlterCat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbAlterCat.FormattingEnabled = true;
            cmbAlterCat.Items.AddRange(new object[] { "Hardware", "Periféricos", "SmartPhones", "Desktops", "Notebooks" });
            cmbAlterCat.Location = new Point(160, 166);
            cmbAlterCat.Name = "cmbAlterCat";
            cmbAlterCat.Size = new Size(217, 36);
            cmbAlterCat.TabIndex = 5;
            // 
            // txtAlterDesc
            // 
            txtAlterDesc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAlterDesc.Location = new Point(160, 122);
            txtAlterDesc.Name = "txtAlterDesc";
            txtAlterDesc.Size = new Size(401, 34);
            txtAlterDesc.TabIndex = 6;
            // 
            // txtAlterProd
            // 
            txtAlterProd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAlterProd.Location = new Point(160, 218);
            txtAlterProd.Name = "txtAlterProd";
            txtAlterProd.Size = new Size(217, 34);
            txtAlterProd.TabIndex = 7;
            // 
            // numAlterQnt
            // 
            numAlterQnt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numAlterQnt.Location = new Point(160, 264);
            numAlterQnt.Name = "numAlterQnt";
            numAlterQnt.Size = new Size(111, 34);
            numAlterQnt.TabIndex = 8;
            // 
            // btnAlterSalvar
            // 
            btnAlterSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterSalvar.Image = (Image)resources.GetObject("btnAlterSalvar.Image");
            btnAlterSalvar.Location = new Point(160, 347);
            btnAlterSalvar.Name = "btnAlterSalvar";
            btnAlterSalvar.Size = new Size(148, 58);
            btnAlterSalvar.TabIndex = 9;
            btnAlterSalvar.Text = "Alterar";
            btnAlterSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAlterSalvar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(350, 347);
            button1.Name = "button1";
            button1.Size = new Size(148, 58);
            button1.TabIndex = 10;
            button1.Text = "Cancelar";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(75, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // AlterarProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(650, 434);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(btnAlterSalvar);
            Controls.Add(numAlterQnt);
            Controls.Add(txtAlterProd);
            Controls.Add(txtAlterDesc);
            Controls.Add(cmbAlterCat);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AlterarProduto";
            Text = "AlterarProduto";
            ((System.ComponentModel.ISupportInitialize)numAlterQnt).EndInit();
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
        private ComboBox cmbAlterCat;
        private TextBox txtAlterDesc;
        private TextBox txtAlterProd;
        private NumericUpDown numAlterQnt;
        private Button btnAlterSalvar;
        private Button button1;
        private PictureBox pictureBox1;
    }
}