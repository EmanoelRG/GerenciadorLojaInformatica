namespace GerenciadorLojaInformatica
{
    partial class MenuPagamento
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
            gpbPagamento = new GroupBox();
            radioDebito = new RadioButton();
            radioCredito = new RadioButton();
            radioPix = new RadioButton();
            pnlPagamento = new Panel();
            gpbPagamento.SuspendLayout();
            SuspendLayout();
            // 
            // gpbPagamento
            // 
            gpbPagamento.BackColor = SystemColors.Control;
            gpbPagamento.Controls.Add(radioDebito);
            gpbPagamento.Controls.Add(radioCredito);
            gpbPagamento.Controls.Add(radioPix);
            gpbPagamento.Location = new Point(12, 12);
            gpbPagamento.Name = "gpbPagamento";
            gpbPagamento.Size = new Size(369, 67);
            gpbPagamento.TabIndex = 0;
            gpbPagamento.TabStop = false;
            gpbPagamento.Text = "Formas de Pagamento";
            
            // 
            // radioDebito
            // 
            radioDebito.AutoSize = true;
            radioDebito.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioDebito.Location = new Point(88, 22);
            radioDebito.Name = "radioDebito";
            radioDebito.Size = new Size(73, 24);
            radioDebito.TabIndex = 5;
            radioDebito.TabStop = true;
            radioDebito.Text = "Débito";
            radioDebito.UseVisualStyleBackColor = true;
            // 
            // radioCredito
            // 
            radioCredito.AutoSize = true;
            radioCredito.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioCredito.Location = new Point(6, 22);
            radioCredito.Name = "radioCredito";
            radioCredito.Size = new Size(76, 24);
            radioCredito.TabIndex = 4;
            radioCredito.TabStop = true;
            radioCredito.Text = "Crédito";
            radioCredito.UseVisualStyleBackColor = true;
            // 
            // radioPix
            // 
            radioPix.AutoSize = true;
            radioPix.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioPix.Location = new Point(167, 22);
            radioPix.Name = "radioPix";
            radioPix.Size = new Size(46, 24);
            radioPix.TabIndex = 3;
            radioPix.TabStop = true;
            radioPix.Text = "Pix";
            radioPix.UseVisualStyleBackColor = true;
            // 
            // pnlPagamento
            // 
            pnlPagamento.BackColor = SystemColors.Control;
            pnlPagamento.Location = new Point(12, 93);
            pnlPagamento.Name = "pnlPagamento";
            pnlPagamento.Size = new Size(369, 100);
            pnlPagamento.TabIndex = 1;
            // 
            // MenuPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(389, 244);
            Controls.Add(pnlPagamento);
            Controls.Add(gpbPagamento);
            Name = "MenuPagamento";
            Text = "Pagamento";
            gpbPagamento.ResumeLayout(false);
            gpbPagamento.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbPagamento;
        private RadioButton radioPix;
        private RadioButton radioDebito;
        private RadioButton radioCredito;
        private Panel pnlPagamento;
    }
}