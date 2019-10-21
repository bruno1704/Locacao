namespace GestaoDeFrota.inicio
{
    partial class ReservaCadastrar
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
            this.DtSinis = new System.Windows.Forms.DateTimePicker();
            this.BotCadastrar = new System.Windows.Forms.Button();
            this.cmbsUsu = new System.Windows.Forms.ComboBox();
            this.cmbsVei = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEstatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Veiculo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Data:";
            // 
            // DtSinis
            // 
            this.DtSinis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtSinis.Location = new System.Drawing.Point(82, 135);
            this.DtSinis.Name = "DtSinis";
            this.DtSinis.Size = new System.Drawing.Size(167, 20);
            this.DtSinis.TabIndex = 19;
            // 
            // BotCadastrar
            // 
            this.BotCadastrar.Location = new System.Drawing.Point(174, 178);
            this.BotCadastrar.Name = "BotCadastrar";
            this.BotCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BotCadastrar.TabIndex = 20;
            this.BotCadastrar.Text = "Cadastrar";
            this.BotCadastrar.UseVisualStyleBackColor = true;
            this.BotCadastrar.Click += new System.EventHandler(this.BotCadastrar_Click);
            // 
            // cmbsUsu
            // 
            this.cmbsUsu.FormattingEnabled = true;
            this.cmbsUsu.Location = new System.Drawing.Point(81, 12);
            this.cmbsUsu.Name = "cmbsUsu";
            this.cmbsUsu.Size = new System.Drawing.Size(167, 21);
            this.cmbsUsu.TabIndex = 23;
            // 
            // cmbsVei
            // 
            this.cmbsVei.FormattingEnabled = true;
            this.cmbsVei.Location = new System.Drawing.Point(81, 50);
            this.cmbsVei.Name = "cmbsVei";
            this.cmbsVei.Size = new System.Drawing.Size(167, 21);
            this.cmbsVei.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Estatus Pedido:";
            // 
            // textBoxEstatus
            // 
            this.textBoxEstatus.Location = new System.Drawing.Point(117, 97);
            this.textBoxEstatus.Name = "textBoxEstatus";
            this.textBoxEstatus.Size = new System.Drawing.Size(131, 20);
            this.textBoxEstatus.TabIndex = 26;
            // 
            // ReservaCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 408);
            this.Controls.Add(this.textBoxEstatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbsVei);
            this.Controls.Add(this.cmbsUsu);
            this.Controls.Add(this.BotCadastrar);
            this.Controls.Add(this.DtSinis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReservaCadastrar";
            this.Text = "ReservaCadastrar";
            this.Load += new System.EventHandler(this.ReservaCadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtSinis;
        private System.Windows.Forms.Button BotCadastrar;
        private System.Windows.Forms.ComboBox cmbsUsu;
        private System.Windows.Forms.ComboBox cmbsVei;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEstatus;
    }
}