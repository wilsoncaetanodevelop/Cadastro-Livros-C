
namespace Avaliacao
{
    partial class frmLogin
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.btncadastroLogin = new System.Windows.Forms.Button();
            this.btnNovaSenha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_entrar
            // 
            this.btn_entrar.Location = new System.Drawing.Point(202, 364);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(75, 23);
            this.btn_entrar.TabIndex = 1;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(296, 364);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(133, 287);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(46, 13);
            this.lbl_login.TabIndex = 3;
            this.lbl_login.Text = "LOGIN :";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(129, 322);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(50, 13);
            this.lbl_senha.TabIndex = 4;
            this.lbl_senha.Text = "SENHA :";
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(185, 280);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(235, 20);
            this.txtlogin.TabIndex = 5;
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(185, 315);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(235, 20);
            this.txtsenha.TabIndex = 6;
            // 
            // btncadastroLogin
            // 
            this.btncadastroLogin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastroLogin.Location = new System.Drawing.Point(213, 417);
            this.btncadastroLogin.Name = "btncadastroLogin";
            this.btncadastroLogin.Size = new System.Drawing.Size(148, 37);
            this.btncadastroLogin.TabIndex = 7;
            this.btncadastroLogin.Text = "CADASTRE-SE";
            this.btncadastroLogin.UseVisualStyleBackColor = false;
            this.btncadastroLogin.Click += new System.EventHandler(this.btncadastroLogin_Click);
            // 
            // btnNovaSenha
            // 
            this.btnNovaSenha.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaSenha.Location = new System.Drawing.Point(176, 460);
            this.btnNovaSenha.Name = "btnNovaSenha";
            this.btnNovaSenha.Size = new System.Drawing.Size(219, 37);
            this.btnNovaSenha.TabIndex = 8;
            this.btnNovaSenha.Text = "Esqueceu a Senha";
            this.btnNovaSenha.UseVisualStyleBackColor = false;
            this.btnNovaSenha.Click += new System.EventHandler(this.btnNovaSenha_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 561);
            this.Controls.Add(this.btnNovaSenha);
            this.Controls.Add(this.btncadastroLogin);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Button btncadastroLogin;
        private System.Windows.Forms.Button btnNovaSenha;
    }
}

