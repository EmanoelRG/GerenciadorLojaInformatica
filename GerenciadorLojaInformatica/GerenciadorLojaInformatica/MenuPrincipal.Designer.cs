namespace GerenciadorLojaInformatica
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            panel1 = new Panel();
            btnVendas = new Button();
            btnEstoque = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnEstoque);
            panel1.Controls.Add(btnVendas);
            panel1.Location = new Point(88, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 341);
            panel1.TabIndex = 0;
            // 
            // btnVendas
            // 
            btnVendas.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVendas.Image = (Image)resources.GetObject("btnVendas.Image");
            btnVendas.Location = new Point(66, 47);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(242, 74);
            btnVendas.TabIndex = 0;
            btnVendas.Text = "Vendas";
            btnVendas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVendas.UseVisualStyleBackColor = true;
            btnVendas.Click += btnVendas_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEstoque.Image = (Image)resources.GetObject("btnEstoque.Image");
            btnEstoque.Location = new Point(66, 159);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(242, 74);
            btnEstoque.TabIndex = 1;
            btnEstoque.Text = "Estoque";
            btnEstoque.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEstoque.UseVisualStyleBackColor = true;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(-7, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(588, 573);
            panel2.TabIndex = 1;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(578, 581);
            Controls.Add(panel2);
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnEstoque;
        private Button btnVendas;
        private Panel panel2;
    }
}
