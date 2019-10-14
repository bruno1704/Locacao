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
            this.TxtLocal = new System.Windows.Forms.TextBox();
            this.BtaCadastrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPonto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.Dt = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMulta = new System.Windows.Forms.ComboBox();
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
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Placa Veiculo";
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(80, 45);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(167, 20);
            this.TxtValor.TabIndex = 3;
            this.TxtValor.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
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
            this.BtaCadastrar.Location = new System.Drawing.Point(172, 212);
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
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(80, 11);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(167, 21);
            this.cmbUsers.TabIndex = 13;
            // 
            // Dt
            // 
            this.Dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dt.Location = new System.Drawing.Point(80, 169);
            this.Dt.Name = "Dt";
            this.Dt.Size = new System.Drawing.Size(167, 20);
            this.Dt.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Data";
            // 
            // cmbMulta
            // 
            this.cmbMulta.FormattingEnabled = true;
            this.cmbMulta.Location = new System.Drawing.Point(106, 110);
            this.cmbMulta.Name = "cmbMulta";
            this.cmbMulta.Size = new System.Drawing.Size(141, 21);
            this.cmbMulta.TabIndex = 16;
            // 
            // CadastrarMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 269);
            this.Controls.Add(this.cmbMulta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Dt);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtaCadastrar);
            this.Controls.Add(this.TxtLocal);
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
        private System.Windows.Forms.TextBox TxtLocal;
        private System.Windows.Forms.Button BtaCadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.DateTimePicker Dt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMulta;
    }
}