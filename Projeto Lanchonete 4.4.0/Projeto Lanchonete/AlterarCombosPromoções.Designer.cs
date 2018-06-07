namespace Projeto_Lanchonete
{
    partial class AlterarCombosPromoções
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
            this.btnPesquisarCombosPromoções = new System.Windows.Forms.Button();
            this.txtCombosAlterar = new System.Windows.Forms.TextBox();
            this.btnExcluirCombosPromoções = new System.Windows.Forms.Button();
            this.btnAlterarCombosPromoções = new System.Windows.Forms.Button();
            this.dgvAlterarCombosPromoções = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlterarCombosPromoções)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisarCombosPromoções
            // 
            this.btnPesquisarCombosPromoções.Location = new System.Drawing.Point(228, 11);
            this.btnPesquisarCombosPromoções.Name = "btnPesquisarCombosPromoções";
            this.btnPesquisarCombosPromoções.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarCombosPromoções.TabIndex = 9;
            this.btnPesquisarCombosPromoções.Text = "Pesquisar";
            this.btnPesquisarCombosPromoções.UseVisualStyleBackColor = true;
            // 
            // txtCombosAlterar
            // 
            this.txtCombosAlterar.Location = new System.Drawing.Point(12, 15);
            this.txtCombosAlterar.Name = "txtCombosAlterar";
            this.txtCombosAlterar.Size = new System.Drawing.Size(209, 20);
            this.txtCombosAlterar.TabIndex = 8;
            // 
            // btnExcluirCombosPromoções
            // 
            this.btnExcluirCombosPromoções.Location = new System.Drawing.Point(146, 351);
            this.btnExcluirCombosPromoções.Name = "btnExcluirCombosPromoções";
            this.btnExcluirCombosPromoções.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirCombosPromoções.TabIndex = 7;
            this.btnExcluirCombosPromoções.Text = "Excluir";
            this.btnExcluirCombosPromoções.UseVisualStyleBackColor = true;
            // 
            // btnAlterarCombosPromoções
            // 
            this.btnAlterarCombosPromoções.Location = new System.Drawing.Point(42, 351);
            this.btnAlterarCombosPromoções.Name = "btnAlterarCombosPromoções";
            this.btnAlterarCombosPromoções.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarCombosPromoções.TabIndex = 6;
            this.btnAlterarCombosPromoções.Text = "Alterar";
            this.btnAlterarCombosPromoções.UseVisualStyleBackColor = true;
            // 
            // dgvAlterarCombosPromoções
            // 
            this.dgvAlterarCombosPromoções.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlterarCombosPromoções.Location = new System.Drawing.Point(12, 54);
            this.dgvAlterarCombosPromoções.Name = "dgvAlterarCombosPromoções";
            this.dgvAlterarCombosPromoções.Size = new System.Drawing.Size(538, 282);
            this.dgvAlterarCombosPromoções.TabIndex = 5;
            // 
            // AlterarCombosPromoções
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 386);
            this.Controls.Add(this.btnPesquisarCombosPromoções);
            this.Controls.Add(this.txtCombosAlterar);
            this.Controls.Add(this.btnExcluirCombosPromoções);
            this.Controls.Add(this.btnAlterarCombosPromoções);
            this.Controls.Add(this.dgvAlterarCombosPromoções);
            this.Name = "AlterarCombosPromoções";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Combos e Promoções";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlterarCombosPromoções)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisarCombosPromoções;
        private System.Windows.Forms.TextBox txtCombosAlterar;
        private System.Windows.Forms.Button btnExcluirCombosPromoções;
        private System.Windows.Forms.Button btnAlterarCombosPromoções;
        private System.Windows.Forms.DataGridView dgvAlterarCombosPromoções;
    }
}