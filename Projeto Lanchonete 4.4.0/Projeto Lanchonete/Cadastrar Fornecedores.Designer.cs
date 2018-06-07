namespace Projeto_Lanchonete
{
    partial class Cadastrar_Fornecedores
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
            this.txtFornecedoresProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFornecedoresNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFornecedoresQuantidade = new System.Windows.Forms.TextBox();
            this.btnFornecedoresCadastrar = new System.Windows.Forms.Button();
            this.btnFornecedoresAlterar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mskFornecedoresTelefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtFornecedoresProduto
            // 
            this.txtFornecedoresProduto.Location = new System.Drawing.Point(125, 147);
            this.txtFornecedoresProduto.Name = "txtFornecedoresProduto";
            this.txtFornecedoresProduto.Size = new System.Drawing.Size(200, 20);
            this.txtFornecedoresProduto.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Telefone";
            // 
            // txtFornecedoresNome
            // 
            this.txtFornecedoresNome.Location = new System.Drawing.Point(125, 77);
            this.txtFornecedoresNome.Name = "txtFornecedoresNome";
            this.txtFornecedoresNome.Size = new System.Drawing.Size(200, 20);
            this.txtFornecedoresNome.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome";
            // 
            // txtFornecedoresQuantidade
            // 
            this.txtFornecedoresQuantidade.Location = new System.Drawing.Point(125, 179);
            this.txtFornecedoresQuantidade.Name = "txtFornecedoresQuantidade";
            this.txtFornecedoresQuantidade.Size = new System.Drawing.Size(200, 20);
            this.txtFornecedoresQuantidade.TabIndex = 22;
            // 
            // btnFornecedoresCadastrar
            // 
            this.btnFornecedoresCadastrar.Location = new System.Drawing.Point(250, 213);
            this.btnFornecedoresCadastrar.Name = "btnFornecedoresCadastrar";
            this.btnFornecedoresCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnFornecedoresCadastrar.TabIndex = 23;
            this.btnFornecedoresCadastrar.Text = "Cadastrar";
            this.btnFornecedoresCadastrar.UseVisualStyleBackColor = true;
            this.btnFornecedoresCadastrar.Click += new System.EventHandler(this.btnFornecedoresCadastrar_Click);
            // 
            // btnFornecedoresAlterar
            // 
            this.btnFornecedoresAlterar.Location = new System.Drawing.Point(125, 213);
            this.btnFornecedoresAlterar.Name = "btnFornecedoresAlterar";
            this.btnFornecedoresAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnFornecedoresAlterar.TabIndex = 24;
            this.btnFornecedoresAlterar.Text = "Alterar";
            this.btnFornecedoresAlterar.UseVisualStyleBackColor = true;
            this.btnFornecedoresAlterar.Click += new System.EventHandler(this.btnFornecedoresAlterar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cadastrar Fornecedores";
            // 
            // mskFornecedoresTelefone
            // 
            this.mskFornecedoresTelefone.Location = new System.Drawing.Point(125, 110);
            this.mskFornecedoresTelefone.Mask = "(00) 0000-0000";
            this.mskFornecedoresTelefone.Name = "mskFornecedoresTelefone";
            this.mskFornecedoresTelefone.Size = new System.Drawing.Size(200, 20);
            this.mskFornecedoresTelefone.TabIndex = 26;
            this.mskFornecedoresTelefone.Click += new System.EventHandler(this.mskFornecedoresTelefone_Click);
            // 
            // Cadastrar_Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 261);
            this.Controls.Add(this.mskFornecedoresTelefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFornecedoresAlterar);
            this.Controls.Add(this.btnFornecedoresCadastrar);
            this.Controls.Add(this.txtFornecedoresQuantidade);
            this.Controls.Add(this.txtFornecedoresProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFornecedoresNome);
            this.Controls.Add(this.label1);
            this.Name = "Cadastrar_Fornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Fornecedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFornecedoresProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFornecedoresNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFornecedoresQuantidade;
        private System.Windows.Forms.Button btnFornecedoresCadastrar;
        private System.Windows.Forms.Button btnFornecedoresAlterar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskFornecedoresTelefone;
    }
}