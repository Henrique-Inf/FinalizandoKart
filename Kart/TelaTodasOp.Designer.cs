namespace Kart
{
    partial class TelaTodasOp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaTodasOp));
            this.ButtonAdt2 = new System.Windows.Forms.Button();
            this.ButtonAdt1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonAdt2
            // 
            this.ButtonAdt2.BackColor = System.Drawing.Color.DimGray;
            this.ButtonAdt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdt2.ForeColor = System.Drawing.Color.Black;
            this.ButtonAdt2.Location = new System.Drawing.Point(1078, 490);
            this.ButtonAdt2.Name = "ButtonAdt2";
            this.ButtonAdt2.Size = new System.Drawing.Size(249, 60);
            this.ButtonAdt2.TabIndex = 0;
            this.ButtonAdt2.Text = "Alugar";
            this.ButtonAdt2.UseVisualStyleBackColor = false;
            this.ButtonAdt2.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // ButtonAdt1
            // 
            this.ButtonAdt1.BackColor = System.Drawing.Color.DimGray;
            this.ButtonAdt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdt1.ForeColor = System.Drawing.Color.Black;
            this.ButtonAdt1.Location = new System.Drawing.Point(647, 490);
            this.ButtonAdt1.Name = "ButtonAdt1";
            this.ButtonAdt1.Size = new System.Drawing.Size(249, 60);
            this.ButtonAdt1.TabIndex = 1;
            this.ButtonAdt1.Text = "Alugar";
            this.ButtonAdt1.UseVisualStyleBackColor = false;
            this.ButtonAdt1.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1412, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 97);
            this.button3.TabIndex = 2;
            this.button3.Text = "Carrinho";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TelaTodasOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1440, 862);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ButtonAdt1);
            this.Controls.Add(this.ButtonAdt2);
            this.Name = "TelaTodasOp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Tela2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAdt2;
        private System.Windows.Forms.Button ButtonAdt1;
        private System.Windows.Forms.Button button3;
    }
}