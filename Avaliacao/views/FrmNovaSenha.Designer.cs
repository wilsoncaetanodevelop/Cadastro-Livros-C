
namespace Avaliacao.views
{
    partial class FrmNovaSenha
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
            this.txtsenhaN = new System.Windows.Forms.TextBox();
            this.txtemailN = new System.Windows.Forms.TextBox();
            this.btnRedefinir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtsenhaN
            // 
            this.txtsenhaN.Location = new System.Drawing.Point(87, 127);
            this.txtsenhaN.Name = "txtsenhaN";
            this.txtsenhaN.PasswordChar = '*';
            this.txtsenhaN.Size = new System.Drawing.Size(181, 20);
            this.txtsenhaN.TabIndex = 10;
            // 
            // txtemailN
            // 
            this.txtemailN.Location = new System.Drawing.Point(87, 69);
            this.txtemailN.Name = "txtemailN";
            this.txtemailN.Size = new System.Drawing.Size(181, 20);
            this.txtemailN.TabIndex = 9;
            // 
            // btnRedefinir
            // 
            this.btnRedefinir.Location = new System.Drawing.Point(119, 200);
            this.btnRedefinir.Name = "btnRedefinir";
            this.btnRedefinir.Size = new System.Drawing.Size(104, 23);
            this.btnRedefinir.TabIndex = 8;
            this.btnRedefinir.Text = "Redefinir Senha";
            this.btnRedefinir.UseVisualStyleBackColor = true;
            this.btnRedefinir.Click += new System.EventHandler(this.btnRedefinir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nova Senha :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login :";
            // 
            // FrmNovaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 298);
            this.Controls.Add(this.txtsenhaN);
            this.Controls.Add(this.txtemailN);
            this.Controls.Add(this.btnRedefinir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmNovaSenha";
            this.Text = "Redefinir Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsenhaN;
        private System.Windows.Forms.TextBox txtemailN;
        private System.Windows.Forms.Button btnRedefinir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}