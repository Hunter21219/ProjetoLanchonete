namespace Projeto_Lanchonete
{
    partial class Cadastro_Bebidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Bebidas));
            this.dgvCadastroBebidas = new System.Windows.Forms.DataGridView();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AlterarBebidas = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.txtCadastroBebidas = new System.Windows.Forms.TextBox();
            this.btnPesquisarBebidas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroBebidas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCadastroBebidas
            // 
            this.dgvCadastroBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroBebidas.Location = new System.Drawing.Point(14, 93);
            this.dgvCadastroBebidas.Name = "dgvCadastroBebidas";
            this.dgvCadastroBebidas.Size = new System.Drawing.Size(517, 267);
            this.dgvCadastroBebidas.TabIndex = 0;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(14, 378);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cadastrar.TabIndex = 1;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastro de Bebidas";
            // 
            // btn_AlterarBebidas
            // 
            this.btn_AlterarBebidas.Location = new System.Drawing.Point(122, 377);
            this.btn_AlterarBebidas.Name = "btn_AlterarBebidas";
            this.btn_AlterarBebidas.Size = new System.Drawing.Size(75, 23);
            this.btn_AlterarBebidas.TabIndex = 3;
            this.btn_AlterarBebidas.Text = "Alterar";
            this.btn_AlterarBebidas.UseVisualStyleBackColor = true;
            this.btn_AlterarBebidas.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(227, 377);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 4;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // txtCadastroBebidas
            // 
            this.txtCadastroBebidas.Location = new System.Drawing.Point(14, 60);
            this.txtCadastroBebidas.Name = "txtCadastroBebidas";
            this.txtCadastroBebidas.Size = new System.Drawing.Size(288, 20);
            this.txtCadastroBebidas.TabIndex = 5;
            // 
            // btnPesquisarBebidas
            // 
            this.btnPesquisarBebidas.Location = new System.Drawing.Point(325, 56);
            this.btnPesquisarBebidas.Name = "btnPesquisarBebidas";
            this.btnPesquisarBebidas.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarBebidas.TabIndex = 6;
            this.btnPesquisarBebidas.Text = "Pesquisar";
            this.btnPesquisarBebidas.UseVisualStyleBackColor = true;
            // 
            // Cadastro_Bebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 414);
            this.Controls.Add(this.btnPesquisarBebidas);
            this.Controls.Add(this.txtCadastroBebidas);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_AlterarBebidas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.dgvCadastroBebidas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro_Bebidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Bebidas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroBebidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCadastroBebidas;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AlterarBebidas;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.TextBox txtCadastroBebidas;
        private System.Windows.Forms.Button btnPesquisarBebidas;
    }
}