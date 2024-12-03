using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kart
{
    public partial class Carrinho : Form
    {
        private decimal valorTotal;
        private int duracaoTotal;
        private string resumoEscolhas;
        public Carrinho(int duracaoTotal, decimal valorTotal, string resumoEscolhas)
        {
            InitializeComponent();
            this.duracaoTotal = duracaoTotal;
            this.valorTotal = valorTotal;
            this.resumoEscolhas = resumoEscolhas;
        }

        private void Carrinho_Load(object sender, EventArgs e)
        {
            labelResumo.Text = resumoEscolhas;
            labelDuracao.Text = $"Duração total: {duracaoTotal} minutos";
            labelValorTotal.Text = $"Valor total: R$ {valorTotal:F2}";
        }
        private void labelDuracao_Click(object sender, EventArgs e)
        {

        }

        private void labelDuracao_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelValorTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
