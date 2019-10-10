namespace GestaoDeFrota.inicio
{
    partial class CadastrarMulta
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
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.TxtVeiculo = new System.Windows.Forms.TextBox();
            this.TxtLocal = new System.Windows.Forms.TextBox();
            this.BtaCadastrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPonto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Local";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Veiculo";
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(80, 45);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(167, 20);
            this.TxtValor.TabIndex = 3;
            this.TxtValor.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // TxtVeiculo
            // 
            this.TxtVeiculo.Location = new System.Drawing.Point(80, 110);
            this.TxtVeiculo.Name = "TxtVeiculo";
            this.TxtVeiculo.Size = new System.Drawing.Size(167, 20);
            this.TxtVeiculo.TabIndex = 4;
            // 
            // TxtLocal
            // 
            this.TxtLocal.Location = new System.Drawing.Point(80, 79);
            this.TxtLocal.Name = "TxtLocal";
            this.TxtLocal.Size = new System.Drawing.Size(167, 20);
            this.TxtLocal.TabIndex = 5;
            // 
            // BtaCadastrar
            // 
            this.BtaCadastrar.Location = new System.Drawing.Point(186, 205);
            this.BtaCadastrar.Name = "BtaCadastrar";
            this.BtaCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtaCadastrar.TabIndex = 6;
            this.BtaCadastrar.Text = "Cadastrar";
            this.BtaCadastrar.UseVisualStyleBackColor = true;
            this.BtaCadastrar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ponto";
            // 
            // TxtPonto
            // 
            this.TxtPonto.Location = new System.Drawing.Point(80, 142);
            this.TxtPonto.Name = "TxtPonto";
            this.TxtPonto.Size = new System.Drawing.Size(167, 20);
            this.TxtPonto.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Usuario";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(80, 16);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(167, 20);
            this.TxtUsuario.TabIndex = 10;
            // 
            // CadastrarMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 269);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtaCadastrar);
            this.Controls.Add(this.TxtLocal);
            this.Controls.Add(this.TxtVeiculo);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarMulta";
            this.Text = "CadastrarMulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.TextBox TxtVeiculo;
        private System.Windows.Forms.TextBox TxtLocal;
        private System.Windows.Forms.Button BtaCadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtUsuario;
    }
}