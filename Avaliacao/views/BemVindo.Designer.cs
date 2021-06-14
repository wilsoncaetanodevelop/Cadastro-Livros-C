
namespace Avaliacao.views
{
    partial class BemVindo
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
            this.btn_cadastro_B = new System.Windows.Forms.Button();
            this.btn_pesquisa_B = new System.Windows.Forms.Button();
            this.btn_Editora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem Vindo !!";
            // 
            // btn_cadastro_B
            // 
            this.btn_cadastro_B.Location = new System.Drawing.Point(163, 293);
            this.btn_cadastro_B.Name = "btn_cadastro_B";
            this.btn_cadastro_B.Size = new System.Drawing.Size(134, 23);
            this.btn_cadastro_B.TabIndex = 1;
            this.btn_cadastro_B.Text = "Cadastro de Livros";
            this.btn_cadastro_B.UseVisualStyleBackColor = true;
            this.btn_cadastro_B.Click += new System.EventHandler(this.btn_cadastro_B_Click);
            // 
            // btn_pesquisa_B
            // 
            this.btn_pesquisa_B.Location = new System.Drawing.Point(330, 293);
            this.btn_pesquisa_B.Name = "btn_pesquisa_B";
            this.btn_pesquisa_B.Size = new System.Drawing.Size(129, 23);
            this.btn_pesquisa_B.TabIndex = 2;
            this.btn_pesquisa_B.Text = "Pesquisa de Livros";
            this.btn_pesquisa_B.UseVisualStyleBackColor = true;
            this.btn_pesquisa_B.Click += new System.EventHandler(this.btn_pesquisa_B_Click);
            // 
            // btn_Editora
            // 
            this.btn_Editora.Location = new System.Drawing.Point(229, 357);
            this.btn_Editora.Name = "btn_Editora";
            this.btn_Editora.Size = new System.Drawing.Size(161, 23);
            this.btn_Editora.TabIndex = 3;
            this.btn_Editora.Text = "Cadastro Editora";
            this.btn_Editora.UseVisualStyleBackColor = true;
            this.btn_Editora.Click += new System.EventHandler(this.btn_Editora_Click);
            // 
            // BemVindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 475);
            this.Controls.Add(this.btn_Editora);
            this.Controls.Add(this.btn_pesquisa_B);
            this.Controls.Add(this.btn_cadastro_B);
            this.Controls.Add(this.label1);
            this.Name = "BemVindo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tela Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cadastro_B;
        private System.Windows.Forms.Button btn_pesquisa_B;
        private System.Windows.Forms.Button btn_Editora;
    }
}