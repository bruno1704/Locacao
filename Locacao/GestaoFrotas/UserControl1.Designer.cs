namespace GestaoFrotas
{
    partial class UserControl1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtEntrar = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Inicio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtEntrar
            // 
            this.BtEntrar.Location = new System.Drawing.Point(75, 231);
            this.BtEntrar.Name = "BtEntrar";
            this.BtEntrar.Size = new System.Drawing.Size(144, 38);
            this.BtEntrar.TabIndex = 0;
            this.BtEntrar.Text = "Entrar";
            this.BtEntrar.UseVisualStyleBackColor = true;
            this.BtEntrar.Click += new System.EventHandler(this.BtEntrar_Click);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(55, 119);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(48, 16);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 175);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // Inicio
            // 
            this.Inicio.AutoSize = true;
            this.Inicio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inicio.Location = new System.Drawing.Point(71, 58);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(170, 19);
            this.Inicio.TabIndex = 5;
            this.Inicio.Text = "Sistema surpevisorio";
            this.Inicio.Click += new System.EventHandler(this.Label3_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Inicio);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.BtEntrar);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(292, 332);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtEntrar;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Inicio;
    }
}
