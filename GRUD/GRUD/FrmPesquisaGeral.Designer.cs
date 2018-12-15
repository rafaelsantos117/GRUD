namespace GRUD
{
    partial class FrmPesquisaGeral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisaGeral));
            this.grbFiltros = new System.Windows.Forms.GroupBox();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.DgdPesquisa = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbOrdenacao = new System.Windows.Forms.GroupBox();
            this.RdbNumerica = new System.Windows.Forms.RadioButton();
            this.RdbAlfabetica = new System.Windows.Forms.RadioButton();
            this.grbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgdPesquisa)).BeginInit();
            this.grbOrdenacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbFiltros
            // 
            this.grbFiltros.Controls.Add(this.lblFiltros);
            this.grbFiltros.Controls.Add(this.TxtDescricao);
            this.grbFiltros.Location = new System.Drawing.Point(11, 3);
            this.grbFiltros.Name = "grbFiltros";
            this.grbFiltros.Size = new System.Drawing.Size(334, 58);
            this.grbFiltros.TabIndex = 0;
            this.grbFiltros.TabStop = false;
            this.grbFiltros.Text = "Filtros";
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Location = new System.Drawing.Point(5, 25);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(58, 13);
            this.lblFiltros.TabIndex = 0;
            this.lblFiltros.Text = "Descrição:";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(63, 22);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(263, 20);
            this.TxtDescricao.TabIndex = 0;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(86, 71);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BtnPesquisar.TabIndex = 1;
            this.BtnPesquisar.Text = "&Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(193, 71);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpar.TabIndex = 2;
            this.BtnLimpar.Text = "&Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // DgdPesquisa
            // 
            this.DgdPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgdPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome});
            this.DgdPesquisa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgdPesquisa.Location = new System.Drawing.Point(11, 104);
            this.DgdPesquisa.Name = "DgdPesquisa";
            this.DgdPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgdPesquisa.Size = new System.Drawing.Size(334, 150);
            this.DgdPesquisa.TabIndex = 3;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 60;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 300;
            // 
            // grbOrdenacao
            // 
            this.grbOrdenacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grbOrdenacao.Controls.Add(this.RdbNumerica);
            this.grbOrdenacao.Controls.Add(this.RdbAlfabetica);
            this.grbOrdenacao.Location = new System.Drawing.Point(11, 260);
            this.grbOrdenacao.Name = "grbOrdenacao";
            this.grbOrdenacao.Size = new System.Drawing.Size(224, 42);
            this.grbOrdenacao.TabIndex = 4;
            this.grbOrdenacao.TabStop = false;
            this.grbOrdenacao.Text = "Ordenação da Pesquisa";
            // 
            // RdbNumerica
            // 
            this.RdbNumerica.AutoSize = true;
            this.RdbNumerica.Location = new System.Drawing.Point(120, 19);
            this.RdbNumerica.Name = "RdbNumerica";
            this.RdbNumerica.Size = new System.Drawing.Size(104, 17);
            this.RdbNumerica.TabIndex = 5;
            this.RdbNumerica.TabStop = true;
            this.RdbNumerica.Text = "Ordem Numérica";
            this.RdbNumerica.UseVisualStyleBackColor = true;
            // 
            // RdbAlfabetica
            // 
            this.RdbAlfabetica.AutoSize = true;
            this.RdbAlfabetica.Location = new System.Drawing.Point(8, 19);
            this.RdbAlfabetica.Name = "RdbAlfabetica";
            this.RdbAlfabetica.Size = new System.Drawing.Size(106, 17);
            this.RdbAlfabetica.TabIndex = 4;
            this.RdbAlfabetica.TabStop = true;
            this.RdbAlfabetica.Text = "Ordem Alfabética";
            this.RdbAlfabetica.UseVisualStyleBackColor = true;
            // 
            // FrmPesquisaGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(356, 306);
            this.Controls.Add(this.grbOrdenacao);
            this.Controls.Add(this.DgdPesquisa);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.grbFiltros);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPesquisaGeral";
            this.Text = "Pesquisa Geral";
            this.grbFiltros.ResumeLayout(false);
            this.grbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgdPesquisa)).EndInit();
            this.grbOrdenacao.ResumeLayout(false);
            this.grbOrdenacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFiltros;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.GroupBox grbOrdenacao;
        private System.Windows.Forms.RadioButton RdbNumerica;
        private System.Windows.Forms.RadioButton RdbAlfabetica;
        public System.Windows.Forms.TextBox TxtDescricao;
        public System.Windows.Forms.DataGridView DgdPesquisa;
    }
}