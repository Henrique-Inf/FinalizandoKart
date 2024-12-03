namespace Kart
{
    partial class Carrinho
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
        

        #endregion

        private System.Windows.Forms.Label labelDuracao;
        private System.Windows.Forms.Label labelValorTotal;

        private void InitializeComponent()
        {
            this.labelDuracao = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.labelResumo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDuracao
            // 
            this.labelDuracao.AutoSize = true;
            this.labelDuracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuracao.Location = new System.Drawing.Point(12, 131);
            this.labelDuracao.Name = "labelDuracao";
            this.labelDuracao.Size = new System.Drawing.Size(331, 33);
            this.labelDuracao.TabIndex = 0;
            this.labelDuracao.Text = "Duração total: 0 minutos";
            this.labelDuracao.Click += new System.EventHandler(this.labelDuracao_Click_1);
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotal.Location = new System.Drawing.Point(16, 98);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(223, 33);
            this.labelValorTotal.TabIndex = 1;
            this.labelValorTotal.Text = "Valor total: R$ 0";
            this.labelValorTotal.Click += new System.EventHandler(this.labelValorTotal_Click);
            // 
            // labelResumo
            // 
            this.labelResumo.AutoSize = true;
            this.labelResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResumo.Location = new System.Drawing.Point(16, 216);
            this.labelResumo.Name = "labelResumo";
            this.labelResumo.Size = new System.Drawing.Size(124, 33);
            this.labelResumo.TabIndex = 2;
            this.labelResumo.Text = "Resumo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 83);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARRINHO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Carrinho
            // 
            this.ClientSize = new System.Drawing.Size(913, 508);
            this.Controls.Add(this.labelDuracao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelResumo);
            this.Controls.Add(this.labelValorTotal);
            this.Name = "Carrinho";
            this.Text = "Carrinho de Compras";
            this.Load += new System.EventHandler(this.Carrinho_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelResumo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}