namespace Projeto_Lanchonete
{
    partial class Combos_e_Promoções
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
            this.txtCBNome = new System.Windows.Forms.TextBox();
            this.txtCBValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCBDescrição = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCBCadastrar = new System.Windows.Forms.Button();
            this.btnCBAlterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Combos e Promoções";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // txtCBNome
            // 
            this.txtCBNome.Location = new System.Drawing.Point(88, 81);
            this.txtCBNome.Name = "txtCBNome";
            this.txtCBNome.Size = new System.Drawing.Size(207, 20);
            this.txtCBNome.TabIndex = 2;
            // 
            // txtCBValor
            // 
            this.txtCBValor.Location = new System.Drawing.Point(88, 117);
            this.txtCBValor.Name = "txtCBValor";
            this.txtCBValor.Size = new System.Drawing.Size(207, 20);
            this.txtCBValor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor";
            // 
            // txtCBDescrição
            // 
            this.txtCBDescrição.Location = new System.Drawing.Point(88, 155);
            this.txtCBDescrição.Name = "txtCBDescrição";
            this.txtCBDescrição.Size = new System.Drawing.Size(207, 20);
            this.txtCBDescrição.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descrição";
            // 
            // btnCBCadastrar
            // 
            this.btnCBCadastrar.Location = new System.Drawing.Point(88, 195);
            this.btnCBCadastrar.Name = "btnCBCadastrar";
            this.btnCBCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCBCadastrar.TabIndex = 7;
            this.btnCBCadastrar.Text = "Cadastrar";
            this.btnCBCadastrar.UseVisualStyleBackColor = true;
            this.btnCBCadastrar.Click += new System.EventHandler(this.btnCBCadastrar_Click);
            // 
            // btnCBAlterar
            // 
            this.btnCBAlterar.Location = new System.Drawing.Point(219, 194);
            this.btnCBAlterar.Name = "btnCBAlterar";
            this.btnCBAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnCBAlterar.TabIndex = 8;
            this.btnCBAlterar.Text = "Alterar";
            this.btnCBAlterar.UseVisualStyleBackColor = true;
            this.btnCBAlterar.Click += new System.EventHandler(this.btnCBAlterar_Click);
            // 
            // Combos_e_Promoções
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 246);
            this.Controls.Add(this.btnCBAlterar);
            this.Controls.Add(this.btnCBCadastrar);
            this.Controls.Add(this.txtCBDescrição);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCBValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCBNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Combos_e_Promoções";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Combos e Promoções";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCBNome;
        private System.Windows.Forms.TextBox txtCBValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCBDescrição;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCBCadastrar;
        private System.Windows.Forms.Button btnCBAlterar;
    }
}