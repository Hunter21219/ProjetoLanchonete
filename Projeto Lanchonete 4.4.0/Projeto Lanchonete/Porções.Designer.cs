namespace Projeto_Lanchonete
{
    partial class Porções
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
            this.txtPorçõesNome = new System.Windows.Forms.TextBox();
            this.txtPorçõesValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPorçõesDescrição = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPorçõesAlterar = new System.Windows.Forms.Button();
            this.btnPorçõesCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Porções";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // txtPorçõesNome
            // 
            this.txtPorçõesNome.Location = new System.Drawing.Point(95, 70);
            this.txtPorçõesNome.Name = "txtPorçõesNome";
            this.txtPorçõesNome.Size = new System.Drawing.Size(198, 20);
            this.txtPorçõesNome.TabIndex = 2;
            // 
            // txtPorçõesValor
            // 
            this.txtPorçõesValor.Location = new System.Drawing.Point(95, 109);
            this.txtPorçõesValor.Name = "txtPorçõesValor";
            this.txtPorçõesValor.Size = new System.Drawing.Size(198, 20);
            this.txtPorçõesValor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor";
            // 
            // txtPorçõesDescrição
            // 
            this.txtPorçõesDescrição.Location = new System.Drawing.Point(95, 151);
            this.txtPorçõesDescrição.Name = "txtPorçõesDescrição";
            this.txtPorçõesDescrição.Size = new System.Drawing.Size(198, 20);
            this.txtPorçõesDescrição.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descrição";
            // 
            // btnPorçõesAlterar
            // 
            this.btnPorçõesAlterar.Location = new System.Drawing.Point(218, 186);
            this.btnPorçõesAlterar.Name = "btnPorçõesAlterar";
            this.btnPorçõesAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnPorçõesAlterar.TabIndex = 10;
            this.btnPorçõesAlterar.Text = "Alterar";
            this.btnPorçõesAlterar.UseVisualStyleBackColor = true;
            this.btnPorçõesAlterar.Click += new System.EventHandler(this.btnPorçõesAlterar_Click);
            // 
            // btnPorçõesCadastrar
            // 
            this.btnPorçõesCadastrar.Location = new System.Drawing.Point(95, 186);
            this.btnPorçõesCadastrar.Name = "btnPorçõesCadastrar";
            this.btnPorçõesCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnPorçõesCadastrar.TabIndex = 9;
            this.btnPorçõesCadastrar.Text = "Cadastrar";
            this.btnPorçõesCadastrar.UseVisualStyleBackColor = true;
            this.btnPorçõesCadastrar.Click += new System.EventHandler(this.btnPorçõesCadastrar_Click);
            // 
            // Porções
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 241);
            this.Controls.Add(this.btnPorçõesAlterar);
            this.Controls.Add(this.btnPorçõesCadastrar);
            this.Controls.Add(this.txtPorçõesDescrição);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPorçõesValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPorçõesNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Porções";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Porções";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPorçõesNome;
        private System.Windows.Forms.TextBox txtPorçõesValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPorçõesDescrição;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPorçõesAlterar;
        private System.Windows.Forms.Button btnPorçõesCadastrar;
    }
}