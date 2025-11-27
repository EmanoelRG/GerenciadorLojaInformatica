using System;
using System.Windows.Forms;

namespace GerenciadorLojaInformatica
{
    // 1. O Contrato (Interface)
    public interface IPagamentoStrategy
    {
        void Pagar(decimal valor);
    }

    // 2. Pix (Simples)
    public class PagamentoPix : IPagamentoStrategy
    {
        public void Pagar(decimal valor)
        {
            // Aqui entraria a API do banco para gerar QR Code
            MessageBox.Show($"Pagamento via PIX iniciado.\nValor: {valor:C2}\n\n(Aguardando confirmação do banco...)", "PIX");
        }
    }

    // 3. Débito (Simples)
    public class PagamentoDebito : IPagamentoStrategy
    {
        public void Pagar(decimal valor)
        {
            MessageBox.Show($"Pagamento via DÉBITO.\nValor: {valor:C2}\n\n(Insira o cartão na maquininha)", "DÉBITO");
        }
    }

    // 4. Crédito (Complexo - aceita parcelas)
    public class PagamentoCredito : IPagamentoStrategy
    {
        private int _parcelas;

        public PagamentoCredito(int parcelas)
        {
            _parcelas = parcelas;
        }

        public void Pagar(decimal valor)
        {
            decimal valorParcela = valor / _parcelas;
            MessageBox.Show($"Pagamento via CRÉDITO.\nTotal: {valor:C2}\nParcelado em: {_parcelas}x de {valorParcela:C2}\n\n(Insira o cartão na maquininha)", "CRÉDITO");
        }
    }
}