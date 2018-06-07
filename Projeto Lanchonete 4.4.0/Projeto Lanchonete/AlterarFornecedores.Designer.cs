namespace Projeto_Lanchonete
{
    partial class AlterarFornecedores
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
            this.dgvAlterarFornecedores = new System.Windows.Forms.DataGridView();
            this.btnAlterarFornecedores = new System.Windows.Forms.Button();
            this.btnExcluirFornecedores = new System.Windows.Forms.Button();
            this.txtAlterarFornecedores = new System.Windows.Forms.TextBox();
            this.btnPesquisarFornecedores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlterarFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlterarFornecedores
            // 
            this.dgvAlterarFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlterarFornecedores.Location = new System.Drawing.Point(21, 59);
            this.dgvAlterarFornecedores.Name = "dgvAlterarFornecedores";
            this.dgvAlterarFornecedores.Size = new System.Drawing.Size(538, 282);
            this.dgvAlterarFornecedores.TabIndex = 0;
            // 
            // btnAlterarFornecedores
            // 
            this.btnAlterarFornecedores.Location = new System.Drawing.Point(51, 356);
            this.btnAlterarFornecedores.Name = "btnAlterarFornecedores";
            this.btnAlterarFornecedores.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarFornecedores.TabIndex = 1;
            this.btnAlterarFornecedores.Text = "Alterar";
            this.btnAlterarFornecedores.UseVisualStyleBackColor = true;
            // 
            // btnExcluirFornecedores
            // 
            this.btnExcluirFornecedores.Location = new System.Drawing.Point(155, 356);
            this.btnExcluirFornecedores.Name = "btnExcluirFornecedores";
            this.btnExcluirFornecedores.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirFornecedores.TabIndex = 2;
            this.btnExcluirFornecedores.Text = "Excluir";
            this.btnExcluirFornecedores.UseVisualStyleBackColor = true;
            // 
            // txtAlterarFornecedores
            // 
            this.txtAlterarFornecedores.Location = new System.Drawing.Point(21, 20);
            this.txtAlterarFornecedores.Name = "txtAlterarFornecedores";
            this.txtAlterarFornecedores.Size = new System.Drawing.Size(209, 20);
            this.txtAlterarFornecedores.TabIndex = 3;
            // 
            // btnPesquisarFornecedores
            // 
            this.btnPesquisarFornecedores.Location = new System.Drawing.Point(237, 16);
            this.btnPesquisarFornecedores.Name = "btnPesquisarFornecedores";
            this.btnPesquisarFornecedores.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarFornecedores.TabIndex = 4;
            this.btnPesquisarFornecedores.Text = "Pesquisar";
            this.btnPesquisarFornecedores.UseVisualStyleBackColor = true;
            // 
            // AlterarFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 398);
            this.Controls.Add(this.btnPesquisarFornecedores);
            this.Controls.Add(this.txtAlterarFornecedores);
            this.Controls.Add(this.btnExcluirFornecedores);
            this.Controls.Add(this.btnAlterarFornecedores);
            this.Controls.Add(this.dgvAlterarFornecedores);
            this.Name = "AlterarFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Fornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlterarFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlterarFornecedores;
        private System.Windows.Forms.Button btnAlterarFornecedores;
        private System.Windows.Forms.Button btnExcluirFornecedores;
        private System.Windows.Forms.TextBox txtAlterarFornecedores;
        private System.Windows.Forms.Button btnPesquisarFornecedores;
    }
}