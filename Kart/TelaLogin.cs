using System;
using System.Windows.Forms;

namespace Kart
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            var result = MessageBox.Show("Nome: " + textBox1.Text + "\n" + "E-mail: " + textBox2.Text + "\n" + "CPF:" + maskedTextBox1.Text, "Informações digitadas",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;
                maskedTextBox1.Text = String.Empty;
                textBox1.Focus();
                TelaTodasOp TelaTodasOp = new TelaTodasOp();
                this.Visible = false;
                TelaTodasOp.ShowDialog();
                this.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Caso você precise de algum código específico para o carregamento do formulário, coloque-o aqui.
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
