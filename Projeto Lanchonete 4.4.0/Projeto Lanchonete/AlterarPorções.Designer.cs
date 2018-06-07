namespace Projeto_Lanchonete
{
    partial class Alterar_Porções
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
            this.btnPesquisarPorções = new System.Windows.Forms.Button();
            this.txtPorçõesAlterar = new System.Windows.Forms.TextBox();
            this.btnExcluirPorções = new System.Windows.Forms.Button();
            this.btnAlterarPorções = new System.Windows.Forms.Button();
            this.dgvAlterarPorções = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlterarPorções)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisarPorções
            // 
            this.btnPesquisarPorções.Location = new System.Drawing.Point(228, 11);
            this.btnPesquisarPorções.Name = "btnPesquisarPorções";
            this.btnPesquisarPorções.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarPorções.TabIndex = 14;
            this.btnPesquisarPorções.Text = "Pesquisar";
            this.btnPesquisarPorções.UseVisualStyleBackColor = true;
            // 
            // txtPorçõesAlterar
            // 
            this.txtPorçõesAlterar.Location = new System.Drawing.Point(12, 15);
            this.txtPorçõesAlterar.Name = "txtPorçõesAlterar";
            this.txtPorçõesAlterar.Size = new System.Drawing.Size(209, 20);
            this.txtPorçõesAlterar.TabIndex = 13;
            // 
            // btnExcluirPorções
            // 
            this.btnExcluirPorções.Location = new System.Drawing.Point(146, 351);
            this.btnExcluirPorções.Name = "btnExcluirPorções";
            this.btnExcluirPorções.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirPorções.TabIndex = 12;
            this.btnExcluirPorções.Text = "Excluir";
            this.btnExcluirPorções.UseVisualStyleBackColor = true;
            // 
            // btnAlterarPorções
            // 
            this.btnAlterarPorções.Location = new System.Drawing.Point(42, 351);
            this.btnAlterarPorções.Name = "btnAlterarPorções";
            this.btnAlterarPorções.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarPorções.TabIndex = 11;
            this.btnAlterarPorções.Text = "Alterar";
            this.btnAlterarPorções.UseVisualStyleBackColor = true;
            this.btnAlterarPorções.Click += new System.EventHandler(this.btnAlterarPorções_Click);
            // 
            // dgvAlterarPorções
            // 
            this.dgvAlterarPorções.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlterarPorções.Location = new System.Drawing.Point(12, 54);
            this.dgvAlterarPorções.Name = "dgvAlterarPorções";
            this.dgvAlterarPorções.Size = new System.Drawing.Size(538, 282);
            this.dgvAlterarPorções.TabIndex = 10;
            // 
            // Alterar_Porções
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 388);
            this.Controls.Add(this.btnPesquisarPorções);
            this.Controls.Add(this.txtPorçõesAlterar);
            this.Controls.Add(this.btnExcluirPorções);
            this.Controls.Add(this.btnAlterarPorções);
            this.Controls.Add(this.dgvAlterarPorções);
            this.Name = "Alterar_Porções";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Porções";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlterarPorções)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisarPorções;
        private System.Windows.Forms.TextBox txtPorçõesAlterar;
        private System.Windows.Forms.Button btnExcluirPorções;
        private System.Windows.Forms.Button btnAlterarPorções;
        private System.Windows.Forms.DataGridView dgvAlterarPorções;
    }
}