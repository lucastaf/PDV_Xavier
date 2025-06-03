namespace PDV_Xavier
{
    partial class TabelaOperacoes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgv_operacoes = new System.Windows.Forms.DataGridView();
            this.txt_contato = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbx_tipoPagamento = new System.Windows.Forms.ComboBox();
            this.cbx_tipoOperacao = new System.Windows.Forms.ComboBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.lbl_nomeContato = new System.Windows.Forms.Label();
            this.lbl_dataInicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_fim = new System.Windows.Forms.DateTimePicker();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.chk_filtrarData = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_operacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_operacoes
            // 
            this.dgv_operacoes.AllowUserToAddRows = false;
            this.dgv_operacoes.AllowUserToDeleteRows = false;
            this.dgv_operacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_operacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_operacoes.Location = new System.Drawing.Point(3, 55);
            this.dgv_operacoes.MultiSelect = false;
            this.dgv_operacoes.Name = "dgv_operacoes";
            this.dgv_operacoes.ReadOnly = true;
            this.dgv_operacoes.RowHeadersVisible = false;
            this.dgv_operacoes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_operacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_operacoes.Size = new System.Drawing.Size(689, 370);
            this.dgv_operacoes.TabIndex = 1;
            this.dgv_operacoes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_operacoes_CellDoubleClick);
            // 
            // txt_contato
            // 
            this.txt_contato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_contato.Location = new System.Drawing.Point(3, 28);
            this.txt_contato.Name = "txt_contato";
            this.txt_contato.Size = new System.Drawing.Size(258, 20);
            this.txt_contato.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cbx_tipoPagamento
            // 
            this.cbx_tipoPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_tipoPagamento.FormattingEnabled = true;
            this.cbx_tipoPagamento.Items.AddRange(new object[] {
            "Pix",
            "Débito",
            "Crédito",
            "Dinheiro",
            "Pendente"});
            this.cbx_tipoPagamento.Location = new System.Drawing.Point(577, 28);
            this.cbx_tipoPagamento.Name = "cbx_tipoPagamento";
            this.cbx_tipoPagamento.Size = new System.Drawing.Size(83, 21);
            this.cbx_tipoPagamento.TabIndex = 4;
            // 
            // cbx_tipoOperacao
            // 
            this.cbx_tipoOperacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_tipoOperacao.FormattingEnabled = true;
            this.cbx_tipoOperacao.Items.AddRange(new object[] {
            "Venda",
            "Restoque"});
            this.cbx_tipoOperacao.Location = new System.Drawing.Point(577, 3);
            this.cbx_tipoOperacao.Name = "cbx_tipoOperacao";
            this.cbx_tipoOperacao.Size = new System.Drawing.Size(83, 21);
            this.cbx_tipoOperacao.TabIndex = 5;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pesquisar.BackgroundImage = global::PDV_Xavier.Properties.Resources.search;
            this.btn_pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_pesquisar.Location = new System.Drawing.Point(666, 26);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(26, 23);
            this.btn_pesquisar.TabIndex = 6;
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // lbl_nomeContato
            // 
            this.lbl_nomeContato.AutoSize = true;
            this.lbl_nomeContato.Location = new System.Drawing.Point(3, 6);
            this.lbl_nomeContato.Name = "lbl_nomeContato";
            this.lbl_nomeContato.Size = new System.Drawing.Size(47, 13);
            this.lbl_nomeContato.TabIndex = 7;
            this.lbl_nomeContato.Text = "Contato:";
            // 
            // lbl_dataInicio
            // 
            this.lbl_dataInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dataInicio.AutoSize = true;
            this.lbl_dataInicio.Location = new System.Drawing.Point(267, 6);
            this.lbl_dataInicio.Name = "lbl_dataInicio";
            this.lbl_dataInicio.Size = new System.Drawing.Size(60, 13);
            this.lbl_dataInicio.TabIndex = 11;
            this.lbl_dataInicio.Text = "Data inicio:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Data fim:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tipo de operação:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tipo de pagamento:";
            // 
            // dtp_fim
            // 
            this.dtp_fim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fim.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtp_fim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fim.Location = new System.Drawing.Point(333, 28);
            this.dtp_fim.Name = "dtp_fim";
            this.dtp_fim.Size = new System.Drawing.Size(130, 20);
            this.dtp_fim.TabIndex = 15;
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_inicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_inicio.Location = new System.Drawing.Point(333, 4);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(130, 20);
            this.dtp_inicio.TabIndex = 9;
            // 
            // chk_filtrarData
            // 
            this.chk_filtrarData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_filtrarData.AutoSize = true;
            this.chk_filtrarData.Location = new System.Drawing.Point(189, 7);
            this.chk_filtrarData.Name = "chk_filtrarData";
            this.chk_filtrarData.Size = new System.Drawing.Size(72, 17);
            this.chk_filtrarData.TabIndex = 16;
            this.chk_filtrarData.Text = "Filtar data";
            this.chk_filtrarData.UseVisualStyleBackColor = true;
            // 
            // TabelaOperacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chk_filtrarData);
            this.Controls.Add(this.dtp_fim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_dataInicio);
            this.Controls.Add(this.dtp_inicio);
            this.Controls.Add(this.lbl_nomeContato);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.cbx_tipoOperacao);
            this.Controls.Add(this.cbx_tipoPagamento);
            this.Controls.Add(this.txt_contato);
            this.Controls.Add(this.dgv_operacoes);
            this.Name = "TabelaOperacoes";
            this.Size = new System.Drawing.Size(695, 428);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_operacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_operacoes;
        private System.Windows.Forms.TextBox txt_contato;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cbx_tipoPagamento;
        private System.Windows.Forms.ComboBox cbx_tipoOperacao;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Label lbl_nomeContato;
        private System.Windows.Forms.Label lbl_dataInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_fim;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.CheckBox chk_filtrarData;
    }
}
