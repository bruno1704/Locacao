namespace GestaoDeFrota.inicio
{
    partial class CadastrarSeguro
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
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCadastarSeg = new System.Windows.Forms.Button();
            this.ChkPerda = new System.Windows.Forms.CheckBox();
            this.cmbV = new System.Windows.Forms.ComboBox();
            this.cmbUs = new System.Windows.Forms.ComboBox();
            this.TxtVlr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtini = new System.Windows.Forms.DateTimePicker();
            this.dtfina = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veiculo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario:";
            // 
            // BtnCadastarSeg
            // 
            this.BtnCadastarSeg.Location = new System.Drawing.Point(186, 234);
            this.BtnCadastarSeg.Name = "BtnCadastarSeg";
            this.BtnCadastarSeg.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastarSeg.TabIndex = 9;
            this.BtnCadastarSeg.Text = "Cadastrar";
            this.BtnCadastarSeg.UseVisualStyleBackColor = true;
            this.BtnCadastarSeg.Click += new System.EventHandler(this.BtnCadastarSeg_Click);
            // 
            // ChkPerda
            // 
            this.ChkPerda.AutoSize = true;
            this.ChkPerda.Location = new System.Drawing.Point(191, 98);
            this.ChkPerda.Name = "ChkPerda";
            this.ChkPerda.Size = new System.Drawing.Size(78, 17);
            this.ChkPerda.TabIndex = 10;
            this.ChkPerda.Text = "PerdaTotal";
            this.ChkPerda.UseVisualStyleBackColor = true;
            this.ChkPerda.CheckedChanged += new System.EventHandler(this.ChkPerda_CheckedChanged);
            // 
            // cmbV
            // 
            this.cmbV.FormattingEnabled = true;
            this.cmbV.Location = new System.Drawing.Point(94, 12);
            this.cmbV.Name = "cmbV";
            this.cmbV.Size = new System.Drawing.Size(167, 21);
            this.cmbV.TabIndex = 14;
            // 
            // cmbUs
            // 
            this.cmbUs.FormattingEnabled = true;
            this.cmbUs.Location = new System.Drawing.Point(94, 51);
            this.cmbUs.Name = "cmbUs";
            this.cmbUs.Size = new System.Drawing.Size(167, 21);
            this.cmbUs.TabIndex = 15;
            // 
            // TxtVlr
            // 
            this.TxtVlr.Location = new System.Drawing.Point(94, 95);
            this.TxtVlr.Name = "TxtVlr";
            this.TxtVlr.Size = new System.Drawing.Size(91, 20);
            this.TxtVlr.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Valor:";
            // 
            // dtini
            // 
            this.dtini.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtini.Location = new System.Drawing.Point(94, 140);
            this.dtini.Name = "dtini";
            this.dtini.Size = new System.Drawing.Size(167, 20);
            this.dtini.TabIndex = 18;
            // 
            // dtfina
            // 
            this.dtfina.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfina.Location = new System.Drawing.Point(94, 179);
            this.dtfina.Name = "dtfina";
            this.dtfina.Size = new System.Drawing.Size(167, 20);
            this.dtfina.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Inicio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Final:";
            // 
            // CadastrarSeguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtfina);
            this.Controls.Add(this.dtini);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtVlr);
            this.Controls.Add(this.cmbUs);
            this.Controls.Add(this.cmbV);
            this.Controls.Add(this.ChkPerda);
            this.Controls.Add(this.BtnCadastarSeg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarSeguro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarSeguro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCadastarSeg;
        private System.Windows.Forms.CheckBox ChkPerda;
        private System.Windows.Forms.ComboBox cmbV;
        private System.Windows.Forms.ComboBox cmbUs;
        private System.Windows.Forms.TextBox TxtVlr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtini;
        private System.Windows.Forms.DateTimePicker dtfina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}