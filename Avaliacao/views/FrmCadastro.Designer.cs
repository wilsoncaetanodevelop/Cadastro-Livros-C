
namespace Avaliacao.views
{
    partial class FrmCadastro
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
            this.btncadas = new System.Windows.Forms.Button();
            this.txtemailC = new System.Windows.Forms.TextBox();
            this.txtsenhaC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha :";
            // 
            // btncadas
            // 
            this.btncadas.Location = new System.Drawing.Point(103, 210);
            this.btncadas.Name = "btncadas";
            this.btncadas.Size = new System.Drawing.Size(75, 23);
            this.btncadas.TabIndex = 3;
            this.btncadas.Text = "Cadastrar";
            this.btncadas.UseVisualStyleBackColor = true;
            this.btncadas.Click += new System.EventHandler(this.btncadas_Click);
            // 
            // txtemailC
            // 
            this.txtemailC.Location = new System.Drawing.Point(62, 57);
            this.txtemailC.Name = "txtemailC";
            this.txtemailC.Size = new System.Drawing.Size(181, 20);
            this.txtemailC.TabIndex = 4;
            // 
            // txtsenhaC
            // 
            this.txtsenhaC.Location = new System.Drawing.Point(62, 115);
            this.txtsenhaC.Name = "txtsenhaC";
            this.txtsenhaC.PasswordChar = '*';
            this.txtsenhaC.Size = new System.Drawing.Size(181, 20);
            this.txtsenhaC.TabIndex = 5;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 330);
            this.Controls.Add(this.txtsenhaC);
            this.Controls.Add(this.txtemailC);
            this.Controls.Add(this.btncadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCadastro";
            this.Text = "Cadastre-se";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncadas;
        private System.Windows.Forms.TextBox txtemailC;
        private System.Windows.Forms.TextBox txtsenhaC;
    }
}