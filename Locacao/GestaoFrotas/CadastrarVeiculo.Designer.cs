namespace GestaoDeFrota.inicio
{
    partial class CadastrarVeiculo
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
            this.BtnVCadastrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.TxtModelo = new System.Windows.Forms.TextBox();
            this.ChkCompleto = new System.Windows.Forms.CheckBox();
            this.TxtPlaca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnVCadastrar
            // 
            this.BtnVCadastrar.Location = new System.Drawing.Point(255, 197);
            this.BtnVCadastrar.Name = "BtnVCadastrar";
            this.BtnVCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnVCadastrar.TabIndex = 13;
            this.BtnVCadastrar.Text = "Cadastrar";
            this.BtnVCadastrar.UseVisualStyleBackColor = true;
            this.BtnVCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Modelo";
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(94, 91);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(236, 20);
            this.TxtMarca.TabIndex = 8;
            // 
            // TxtModelo
            // 
            this.TxtModelo.Location = new System.Drawing.Point(94, 54);
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.Size = new System.Drawing.Size(236, 20);
            this.TxtModelo.TabIndex = 7;
            // 
            // ChkCompleto
            // 
            this.ChkCompleto.AutoSize = true;
            this.ChkCompleto.Location = new System.Drawing.Point(260, 163);
            this.ChkCompleto.Name = "ChkCompleto";
            this.ChkCompleto.Size = new System.Drawing.Size(70, 17);
            this.ChkCompleto.TabIndex = 14;
            this.ChkCompleto.Text = "Completo";
            this.ChkCompleto.UseVisualStyleBackColor = true;
            this.ChkCompleto.CheckedChanged += new System.EventHandler(this.ChkCompleto_CheckedChanged);
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.Location = new System.Drawing.Point(94, 128);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(236, 20);
            this.TxtPlaca.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Placa";
            // 
            // CadastrarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPlaca);
            this.Controls.Add(this.ChkCompleto);
            this.Controls.Add(this.BtnVCadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtMarca);
            this.Controls.Add(this.TxtModelo);
            this.Name = "CadastrarVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Veiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVCadastrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.TextBox TxtModelo;
        private System.Windows.Forms.CheckBox ChkCompleto;
        private System.Windows.Forms.TextBox TxtPlaca;
        private System.Windows.Forms.Label label2;
    }
}