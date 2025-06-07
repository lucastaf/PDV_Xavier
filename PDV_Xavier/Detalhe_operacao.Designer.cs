namespace PDV_Xavier
{
    partial class Detalhe_operacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detalhe_operacao));
            this.dgv_regitstros = new System.Windows.Forms.DataGridView();
            this.lbl_id_header = new System.Windows.Forms.Label();
            this.lbl_tipoPagamento_header = new System.Windows.Forms.Label();
            this.lbl_tipoOperacao_header = new System.Windows.Forms.Label();
            this.lbl_infoContato_header = new System.Windows.Forms.Label();
            this.lbl_data_header = new System.Windows.Forms.Label();
            this.btn_telefone = new System.Windows.Forms.Button();
            this.lbl_registros_header = new System.Windows.Forms.Label();
            this.lbl_nomeContato_header = new System.Windows.Forms.Label();
            this.btn_email = new System.Windows.Forms.Button();
            this.lbl_nome_contato = new System.Windows.Forms.Label();
            this.lbl_idContato_header = new System.Windows.Forms.Label();
            this.lbl_telefoneContato_header = new System.Windows.Forms.Label();
            this.lbl_emailContato_header = new System.Windows.Forms.Label();
            this.lbl_id_contato = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_tipo_pagamento = new System.Windows.Forms.Label();
            this.lbl_tipo_operacao = new System.Windows.Forms.Label();
            this.lbl_data_operacao = new System.Windows.Forms.Label();
            this.lbl_valor_header = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.btn_confirmarPagamento = new System.Windows.Forms.Button();
            this.cmb_tipoPagamento = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_regitstros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_regitstros
            // 
            this.dgv_regitstros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_regitstros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_regitstros.Location = new System.Drawing.Point(12, 263);
            this.dgv_regitstros.Name = "dgv_regitstros";
            this.dgv_regitstros.ReadOnly = true;
            this.dgv_regitstros.RowHeadersVisible = false;
            this.dgv_regitstros.Size = new System.Drawing.Size(504, 258);
            this.dgv_regitstros.TabIndex = 0;
            // 
            // lbl_id_header
            // 
            this.lbl_id_header.AutoSize = true;
            this.lbl_id_header.Location = new System.Drawing.Point(13, 13);
            this.lbl_id_header.Name = "lbl_id_header";
            this.lbl_id_header.Size = new System.Drawing.Size(84, 13);
            this.lbl_id_header.TabIndex = 1;
            this.lbl_id_header.Text = "ID da operação:";
            // 
            // lbl_tipoPagamento_header
            // 
            this.lbl_tipoPagamento_header.AutoSize = true;
            this.lbl_tipoPagamento_header.Location = new System.Drawing.Point(12, 47);
            this.lbl_tipoPagamento_header.Name = "lbl_tipoPagamento_header";
            this.lbl_tipoPagamento_header.Size = new System.Drawing.Size(102, 13);
            this.lbl_tipoPagamento_header.TabIndex = 2;
            this.lbl_tipoPagamento_header.Text = "Tipo de pagamento:";
            // 
            // lbl_tipoOperacao_header
            // 
            this.lbl_tipoOperacao_header.AutoSize = true;
            this.lbl_tipoOperacao_header.Location = new System.Drawing.Point(12, 68);
            this.lbl_tipoOperacao_header.Name = "lbl_tipoOperacao_header";
            this.lbl_tipoOperacao_header.Size = new System.Drawing.Size(94, 13);
            this.lbl_tipoOperacao_header.TabIndex = 3;
            this.lbl_tipoOperacao_header.Text = "Tipo de operação:";
            // 
            // lbl_infoContato_header
            // 
            this.lbl_infoContato_header.AutoSize = true;
            this.lbl_infoContato_header.Location = new System.Drawing.Point(12, 130);
            this.lbl_infoContato_header.Name = "lbl_infoContato_header";
            this.lbl_infoContato_header.Size = new System.Drawing.Size(122, 13);
            this.lbl_infoContato_header.TabIndex = 4;
            this.lbl_infoContato_header.Text = "Informações do contato:";
            // 
            // lbl_data_header
            // 
            this.lbl_data_header.AutoSize = true;
            this.lbl_data_header.Location = new System.Drawing.Point(12, 89);
            this.lbl_data_header.Name = "lbl_data_header";
            this.lbl_data_header.Size = new System.Drawing.Size(96, 13);
            this.lbl_data_header.TabIndex = 5;
            this.lbl_data_header.Text = "Data da operação:";
            // 
            // btn_telefone
            // 
            this.btn_telefone.Location = new System.Drawing.Point(86, 183);
            this.btn_telefone.Name = "btn_telefone";
            this.btn_telefone.Size = new System.Drawing.Size(311, 23);
            this.btn_telefone.TabIndex = 6;
            this.btn_telefone.Text = "(00) 00000-0000";
            this.btn_telefone.UseVisualStyleBackColor = true;
            this.btn_telefone.Click += new System.EventHandler(this.btn_telefone_Click);
            // 
            // lbl_registros_header
            // 
            this.lbl_registros_header.AutoSize = true;
            this.lbl_registros_header.Location = new System.Drawing.Point(13, 247);
            this.lbl_registros_header.Name = "lbl_registros_header";
            this.lbl_registros_header.Size = new System.Drawing.Size(54, 13);
            this.lbl_registros_header.TabIndex = 7;
            this.lbl_registros_header.Text = "Registros:";
            // 
            // lbl_nomeContato_header
            // 
            this.lbl_nomeContato_header.AutoSize = true;
            this.lbl_nomeContato_header.Location = new System.Drawing.Point(13, 165);
            this.lbl_nomeContato_header.Name = "lbl_nomeContato_header";
            this.lbl_nomeContato_header.Size = new System.Drawing.Size(38, 13);
            this.lbl_nomeContato_header.TabIndex = 8;
            this.lbl_nomeContato_header.Text = "Nome:";
            // 
            // btn_email
            // 
            this.btn_email.Location = new System.Drawing.Point(86, 212);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(311, 23);
            this.btn_email.TabIndex = 9;
            this.btn_email.Text = "endereçodeemailgrandao@gmail.com";
            this.btn_email.UseVisualStyleBackColor = true;
            this.btn_email.Click += new System.EventHandler(this.btn_email_Click);
            // 
            // lbl_nome_contato
            // 
            this.lbl_nome_contato.AutoSize = true;
            this.lbl_nome_contato.Location = new System.Drawing.Point(84, 165);
            this.lbl_nome_contato.Name = "lbl_nome_contato";
            this.lbl_nome_contato.Size = new System.Drawing.Size(90, 13);
            this.lbl_nome_contato.TabIndex = 10;
            this.lbl_nome_contato.Text = "Nome do Contato";
            // 
            // lbl_idContato_header
            // 
            this.lbl_idContato_header.AutoSize = true;
            this.lbl_idContato_header.Location = new System.Drawing.Point(13, 149);
            this.lbl_idContato_header.Name = "lbl_idContato_header";
            this.lbl_idContato_header.Size = new System.Drawing.Size(21, 13);
            this.lbl_idContato_header.TabIndex = 11;
            this.lbl_idContato_header.Text = "ID:";
            // 
            // lbl_telefoneContato_header
            // 
            this.lbl_telefoneContato_header.AutoSize = true;
            this.lbl_telefoneContato_header.Location = new System.Drawing.Point(12, 188);
            this.lbl_telefoneContato_header.Name = "lbl_telefoneContato_header";
            this.lbl_telefoneContato_header.Size = new System.Drawing.Size(52, 13);
            this.lbl_telefoneContato_header.TabIndex = 12;
            this.lbl_telefoneContato_header.Text = "Telefone:";
            // 
            // lbl_emailContato_header
            // 
            this.lbl_emailContato_header.AutoSize = true;
            this.lbl_emailContato_header.Location = new System.Drawing.Point(12, 217);
            this.lbl_emailContato_header.Name = "lbl_emailContato_header";
            this.lbl_emailContato_header.Size = new System.Drawing.Size(35, 13);
            this.lbl_emailContato_header.TabIndex = 13;
            this.lbl_emailContato_header.Text = "Email:";
            // 
            // lbl_id_contato
            // 
            this.lbl_id_contato.AutoSize = true;
            this.lbl_id_contato.Location = new System.Drawing.Point(84, 149);
            this.lbl_id_contato.Name = "lbl_id_contato";
            this.lbl_id_contato.Size = new System.Drawing.Size(38, 13);
            this.lbl_id_contato.TabIndex = 14;
            this.lbl_id_contato.Text = "Nome:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(141, 13);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(84, 13);
            this.lbl_id.TabIndex = 15;
            this.lbl_id.Text = "ID da operação:";
            // 
            // lbl_tipo_pagamento
            // 
            this.lbl_tipo_pagamento.AutoSize = true;
            this.lbl_tipo_pagamento.Location = new System.Drawing.Point(141, 47);
            this.lbl_tipo_pagamento.Name = "lbl_tipo_pagamento";
            this.lbl_tipo_pagamento.Size = new System.Drawing.Size(84, 13);
            this.lbl_tipo_pagamento.TabIndex = 17;
            this.lbl_tipo_pagamento.Text = "ID da operação:";
            // 
            // lbl_tipo_operacao
            // 
            this.lbl_tipo_operacao.AutoSize = true;
            this.lbl_tipo_operacao.Location = new System.Drawing.Point(141, 68);
            this.lbl_tipo_operacao.Name = "lbl_tipo_operacao";
            this.lbl_tipo_operacao.Size = new System.Drawing.Size(84, 13);
            this.lbl_tipo_operacao.TabIndex = 18;
            this.lbl_tipo_operacao.Text = "ID da operação:";
            // 
            // lbl_data_operacao
            // 
            this.lbl_data_operacao.AutoSize = true;
            this.lbl_data_operacao.Location = new System.Drawing.Point(141, 89);
            this.lbl_data_operacao.Name = "lbl_data_operacao";
            this.lbl_data_operacao.Size = new System.Drawing.Size(84, 13);
            this.lbl_data_operacao.TabIndex = 19;
            this.lbl_data_operacao.Text = "ID da operação:";
            // 
            // lbl_valor_header
            // 
            this.lbl_valor_header.AutoSize = true;
            this.lbl_valor_header.Location = new System.Drawing.Point(253, 16);
            this.lbl_valor_header.Name = "lbl_valor_header";
            this.lbl_valor_header.Size = new System.Drawing.Size(76, 13);
            this.lbl_valor_header.TabIndex = 20;
            this.lbl_valor_header.Text = "Valor cobrado:";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(335, 13);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.ReadOnly = true;
            this.txt_valor.Size = new System.Drawing.Size(181, 20);
            this.txt_valor.TabIndex = 21;
            // 
            // btn_confirmarPagamento
            // 
            this.btn_confirmarPagamento.Location = new System.Drawing.Point(335, 68);
            this.btn_confirmarPagamento.Name = "btn_confirmarPagamento";
            this.btn_confirmarPagamento.Size = new System.Drawing.Size(182, 23);
            this.btn_confirmarPagamento.TabIndex = 22;
            this.btn_confirmarPagamento.Text = "Confirmar pagamento";
            this.btn_confirmarPagamento.UseVisualStyleBackColor = true;
            this.btn_confirmarPagamento.Visible = false;
            this.btn_confirmarPagamento.Click += new System.EventHandler(this.btn_confirmarPagamento_Click);
            // 
            // cmb_tipoPagamento
            // 
            this.cmb_tipoPagamento.FormattingEnabled = true;
            this.cmb_tipoPagamento.Items.AddRange(new object[] {
            "Pix",
            "Débito",
            "Crédito",
            "Dinheiro"});
            this.cmb_tipoPagamento.Location = new System.Drawing.Point(336, 44);
            this.cmb_tipoPagamento.Name = "cmb_tipoPagamento";
            this.cmb_tipoPagamento.Size = new System.Drawing.Size(181, 21);
            this.cmb_tipoPagamento.TabIndex = 23;
            this.cmb_tipoPagamento.Visible = false;
            // 
            // Detalhe_operacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 533);
            this.Controls.Add(this.cmb_tipoPagamento);
            this.Controls.Add(this.btn_confirmarPagamento);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.lbl_valor_header);
            this.Controls.Add(this.lbl_data_operacao);
            this.Controls.Add(this.lbl_tipo_operacao);
            this.Controls.Add(this.lbl_tipo_pagamento);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_id_contato);
            this.Controls.Add(this.lbl_emailContato_header);
            this.Controls.Add(this.lbl_telefoneContato_header);
            this.Controls.Add(this.lbl_idContato_header);
            this.Controls.Add(this.lbl_nome_contato);
            this.Controls.Add(this.btn_email);
            this.Controls.Add(this.lbl_nomeContato_header);
            this.Controls.Add(this.lbl_registros_header);
            this.Controls.Add(this.btn_telefone);
            this.Controls.Add(this.lbl_data_header);
            this.Controls.Add(this.lbl_infoContato_header);
            this.Controls.Add(this.lbl_tipoOperacao_header);
            this.Controls.Add(this.lbl_tipoPagamento_header);
            this.Controls.Add(this.lbl_id_header);
            this.Controls.Add(this.dgv_regitstros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Detalhe_operacao";
            this.Text = "Detalhe_operacao";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_regitstros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_regitstros;
        private System.Windows.Forms.Label lbl_id_header;
        private System.Windows.Forms.Label lbl_tipoPagamento_header;
        private System.Windows.Forms.Label lbl_tipoOperacao_header;
        private System.Windows.Forms.Label lbl_infoContato_header;
        private System.Windows.Forms.Label lbl_data_header;
        private System.Windows.Forms.Button btn_telefone;
        private System.Windows.Forms.Label lbl_registros_header;
        private System.Windows.Forms.Label lbl_nomeContato_header;
        private System.Windows.Forms.Button btn_email;
        private System.Windows.Forms.Label lbl_nome_contato;
        private System.Windows.Forms.Label lbl_idContato_header;
        private System.Windows.Forms.Label lbl_telefoneContato_header;
        private System.Windows.Forms.Label lbl_emailContato_header;
        private System.Windows.Forms.Label lbl_id_contato;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_tipo_pagamento;
        private System.Windows.Forms.Label lbl_tipo_operacao;
        private System.Windows.Forms.Label lbl_data_operacao;
        private System.Windows.Forms.Label lbl_valor_header;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Button btn_confirmarPagamento;
        private System.Windows.Forms.ComboBox cmb_tipoPagamento;
    }
}