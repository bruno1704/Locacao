namespace GestaoDeFrota.inicio
{
    partial class CadastrarSinistro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtVeiculo = new System.Windows.Forms.TextBox();
            this.TxtLocal = new System.Windows.Forms.TextBox();
            this.TxtPerdaTotal = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.BtnCadastar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veiculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Local";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Perda Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario";
            // 
            // TxtVeiculo
            // 
            this.TxtVeiculo.Location = new System.Drawing.Point(143, 34);
            this.TxtVeiculo.Name = "TxtVeiculo";
            this.TxtVeiculo.Size = new System.Drawing.Size(209, 20);
            this.TxtVeiculo.TabIndex = 4;
            // 
            // TxtLocal
            // 
            this.TxtLocal.Location = new System.Drawing.Point(143, 64);
            this.TxtLocal.Name = "TxtLocal";
            this.TxtLocal.Size = new System.Drawing.Size(209, 20);
            this.TxtLocal.TabIndex = 5;
            // 
            // TxtPerdaTotal
            // 
            this.TxtPerdaTotal.Location = new System.Drawing.Point(143, 96);
            this.TxtPerdaTotal.Name = "TxtPerdaTotal";
            this.TxtPerdaTotal.Size = new System.Drawing.Size(209, 20);
            this.TxtPerdaTotal.TabIndex = 6;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(143, 130);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(209, 20);
            this.TxtUsuario.TabIndex = 7;
            // 
            // BtnCadastar
            // 
            this.BtnCadastar.Location = new System.Drawing.Point(277, 170);
            this.BtnCadastar.Name = "BtnCadastar";
            this.BtnCadastar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastar.TabIndex = 8;
            this.BtnCadastar.Text = "Cadastrar";
            this.BtnCadastar.UseVisualStyleBackColor = true;
            this.BtnCadastar.Click += new System.EventHandler(this.BtnCadastar_Click);
            // 
            // CadastrarSinistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCadastar);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.TxtPerdaTotal);
            this.Controls.Add(this.TxtLocal);
            this.Controls.Add(this.TxtVeiculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarSinistro";
            this.Text = "CadastrarSinistro";
            this.Load += new System.EventHandler(this.CadastrarSinistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtVeiculo;
        private System.Windows.Forms.TextBox TxtLocal;
        private System.Windows.Forms.TextBox TxtPerdaTotal;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Button BtnCadastar;
    }
}