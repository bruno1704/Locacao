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
            this.label4 = new System.Windows.Forms.Label();
            this.TxtLocal = new System.Windows.Forms.TextBox();
            this.BtnCadastar = new System.Windows.Forms.Button();
            this.chkSin = new System.Windows.Forms.CheckBox();
            this.cmbVei = new System.Windows.Forms.ComboBox();
            this.cmbUsu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DtSini = new System.Windows.Forms.DateTimePicker();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario";
            // 
            // TxtLocal
            // 
            this.TxtLocal.Location = new System.Drawing.Point(143, 64);
            this.TxtLocal.Name = "TxtLocal";
            this.TxtLocal.Size = new System.Drawing.Size(167, 20);
            this.TxtLocal.TabIndex = 5;
            // 
            // BtnCadastar
            // 
            this.BtnCadastar.Location = new System.Drawing.Point(288, 246);
            this.BtnCadastar.Name = "BtnCadastar";
            this.BtnCadastar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastar.TabIndex = 8;
            this.BtnCadastar.Text = "Cadastrar";
            this.BtnCadastar.UseVisualStyleBackColor = true;
            this.BtnCadastar.Click += new System.EventHandler(this.BtnCadastar_Click);
            // 
            // chkSin
            // 
            this.chkSin.AutoSize = true;
            this.chkSin.Location = new System.Drawing.Point(143, 196);
            this.chkSin.Name = "chkSin";
            this.chkSin.Size = new System.Drawing.Size(128, 17);
            this.chkSin.TabIndex = 9;
            this.chkSin.Text = "Roubo e Perda Total ";
            this.chkSin.UseVisualStyleBackColor = true;
            this.chkSin.CheckedChanged += new System.EventHandler(this.Master_CheckedChanged);
            // 
            // cmbVei
            // 
            this.cmbVei.FormattingEnabled = true;
            this.cmbVei.Location = new System.Drawing.Point(143, 26);
            this.cmbVei.Name = "cmbVei";
            this.cmbVei.Size = new System.Drawing.Size(167, 21);
            this.cmbVei.TabIndex = 15;
            // 
            // cmbUsu
            // 
            this.cmbUsu.FormattingEnabled = true;
            this.cmbUsu.Location = new System.Drawing.Point(143, 107);
            this.cmbUsu.Name = "cmbUsu";
            this.cmbUsu.Size = new System.Drawing.Size(167, 21);
            this.cmbUsu.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Data";
            // 
            // DtSini
            // 
            this.DtSini.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtSini.Location = new System.Drawing.Point(143, 159);
            this.DtSini.Name = "DtSini";
            this.DtSini.Size = new System.Drawing.Size(128, 20);
            this.DtSini.TabIndex = 18;
            // 
            // CadastrarSinistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DtSini);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbUsu);
            this.Controls.Add(this.cmbVei);
            this.Controls.Add(this.chkSin);
            this.Controls.Add(this.BtnCadastar);
            this.Controls.Add(this.TxtLocal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "CadastrarSinistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarSinistro";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CadastrarSinistro_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtLocal;
        private System.Windows.Forms.Button BtnCadastar;
        private System.Windows.Forms.CheckBox chkSin;
        private System.Windows.Forms.ComboBox cmbVei;
        private System.Windows.Forms.ComboBox cmbUsu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtSini;
    }
}