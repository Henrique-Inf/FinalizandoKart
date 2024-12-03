using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kart
{
    public partial class TelaTodasOp : Form
    {
        private decimal valorTotal;
        private int valorDuracaoTotal;
        private int duracaoTotal;
        private string resumoEscolhas;

        public TelaTodasOp()
        {
            InitializeComponent();
            valorTotal = 0;
            valorDuracaoTotal = 0;
            resumoEscolhas = string.Empty;

        }
        private void Tela2_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Por quanto tempo deseja alugar?\nSim - 15 Minutos - R$100,00\nNão - 30 Minutos - R$130,00\nCancelar - Para sair",
                "Escolha a duração do aluguel",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                AtualizarResumo("Kart Adulto 13HP", 15, 100);
            }
            else if (resultado == DialogResult.No)
            {
                AtualizarResumo("Kart Adulto 10HP", 30, 130);
            }
            else
            {
                MessageBox.Show("Você não escolheu nenhuma opção. Operação cancelada.");
            }
        }

        private void AtualizarValor(int duracao, decimal valor)
        {
            valorTotal += valor;
            valorDuracaoTotal += duracao;
            MessageBox.Show($"Você escolheu alugar por {duracao} minutos.\nValor total: R$ {valorTotal:F2}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Por quanto tempo deseja alugar?\nSim - 15 Minutos - R$100,00\nNão - 30 Minutos - R$130,00\nCancelar - Para sair",
                "Escolha a duração do aluguel",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                AtualizarValor(15, 110);
            }
            else if (resultado == DialogResult.No)
            {
                AtualizarValor(30, 140);
            }
            else
            {
                MessageBox.Show("Você não escolheu nenhuma opção. Operação cancelada.");
            }
        }

        private void AtualizarResumo(string nome, int duracao, decimal valor)
        {
            resumoEscolhas += $"Você alugou {duracao} minutos do {nome}, o valor foi de R$ {valor:F2}\n";

            duracaoTotal += duracao;
            valorTotal += valor;

            MessageBox.Show($"Você escolheu: {nome}\nDuração: {duracao} minutos\nValor: R$ {valor:F2}");
        }






        private void button3_Click(object sender, EventArgs e)
        {
            Carrinho carrinho = new Carrinho(valorDuracaoTotal, valorTotal, resumoEscolhas);
            carrinho.ShowDialog();
        }

    }
    }





