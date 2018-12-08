namespace GRUD
{
    partial class FrmClientes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.MskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.DtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.BtnPrimeiro = new System.Windows.Forms.Button();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.BtnProximo = new System.Windows.Forms.Button();
            this.BtnUltimo = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.BtnApagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(13, 42);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 74);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(13, 106);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(13, 138);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(13, 174);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(93, 13);
            this.lblDataCadastro.TabIndex = 4;
            this.lblDataCadastro.Text = "Data do Cadastro:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(62, 39);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(60, 20);
            this.TxtCodigo.TabIndex = 5;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(57, 71);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(287, 20);
            this.TxtNome.TabIndex = 6;
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.Location = new System.Drawing.Point(75, 103);
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(269, 20);
            this.TxtEndereco.TabIndex = 7;
            // 
            // MskTelefone
            // 
            this.MskTelefone.Location = new System.Drawing.Point(71, 135);
            this.MskTelefone.Mask = "(99) 90000-0000";
            this.MskTelefone.Name = "MskTelefone";
            this.MskTelefone.Size = new System.Drawing.Size(89, 20);
            this.MskTelefone.TabIndex = 8;
            // 
            // DtpDataCadastro
            // 
            this.DtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataCadastro.Location = new System.Drawing.Point(112, 168);
            this.DtpDataCadastro.Name = "DtpDataCadastro";
            this.DtpDataCadastro.Size = new System.Drawing.Size(95, 20);
            this.DtpDataCadastro.TabIndex = 9;
            // 
            // BtnPrimeiro
            // 
            this.BtnPrimeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrimeiro.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrimeiro.Image")));
            this.BtnPrimeiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrimeiro.Location = new System.Drawing.Point(18, 222);
            this.BtnPrimeiro.Name = "BtnPrimeiro";
            this.BtnPrimeiro.Size = new System.Drawing.Size(80, 23);
            this.BtnPrimeiro.TabIndex = 10;
            this.BtnPrimeiro.Text = "Primeiro";
            this.BtnPrimeiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPrimeiro.UseVisualStyleBackColor = true;
            this.BtnPrimeiro.Click += new System.EventHandler(this.BtnPrimeiro_Click);
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnterior.Image")));
            this.BtnAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAnterior.Location = new System.Drawing.Point(103, 222);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(75, 23);
            this.BtnAnterior.TabIndex = 11;
            this.BtnAnterior.Text = "Anterior";
            this.BtnAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAnterior.UseVisualStyleBackColor = true;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // BtnProximo
            // 
            this.BtnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProximo.Image = ((System.Drawing.Image)(resources.GetObject("BtnProximo.Image")));
            this.BtnProximo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProximo.Location = new System.Drawing.Point(183, 222);
            this.BtnProximo.Name = "BtnProximo";
            this.BtnProximo.Size = new System.Drawing.Size(75, 23);
            this.BtnProximo.TabIndex = 12;
            this.BtnProximo.Text = "Próximo";
            this.BtnProximo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProximo.UseVisualStyleBackColor = true;
            this.BtnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // BtnUltimo
            // 
            this.BtnUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("BtnUltimo.Image")));
            this.BtnUltimo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUltimo.Location = new System.Drawing.Point(263, 222);
            this.BtnUltimo.Name = "BtnUltimo";
            this.BtnUltimo.Size = new System.Drawing.Size(75, 23);
            this.BtnUltimo.TabIndex = 13;
            this.BtnUltimo.Text = "Último";
            this.BtnUltimo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUltimo.UseVisualStyleBackColor = true;
            this.BtnUltimo.Click += new System.EventHandler(this.BtnUltimo_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNovo.Image")));
            this.BtnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNovo.Location = new System.Drawing.Point(61, 261);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 23);
            this.BtnNovo.TabIndex = 14;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnGravar
            // 
            this.BtnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGravar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGravar.Image")));
            this.BtnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGravar.Location = new System.Drawing.Point(142, 261);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(75, 23);
            this.BtnGravar.TabIndex = 15;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // BtnApagar
            // 
            this.BtnApagar.Image = ((System.Drawing.Image)(resources.GetObject("BtnApagar.Image")));
            this.BtnApagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnApagar.Location = new System.Drawing.Point(223, 261);
            this.BtnApagar.Name = "BtnApagar";
            this.BtnApagar.Size = new System.Drawing.Size(75, 23);
            this.BtnApagar.TabIndex = 16;
            this.BtnApagar.Text = "Apagar";
            this.BtnApagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnApagar.UseVisualStyleBackColor = true;
            this.BtnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 306);
            this.Controls.Add(this.BtnApagar);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnUltimo);
            this.Controls.Add(this.BtnProximo);
            this.Controls.Add(this.BtnAnterior);
            this.Controls.Add(this.BtnPrimeiro);
            this.Controls.Add(this.DtpDataCadastro);
            this.Controls.Add(this.MskTelefone);
            this.Controls.Add(this.TxtEndereco);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.lblDataCadastro);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtEndereco;
        private System.Windows.Forms.MaskedTextBox MskTelefone;
        private System.Windows.Forms.DateTimePicker DtpDataCadastro;
        private System.Windows.Forms.Button BtnPrimeiro;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnProximo;
        private System.Windows.Forms.Button BtnUltimo;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Button BtnApagar;
    }
}

