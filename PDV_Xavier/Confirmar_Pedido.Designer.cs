namespace PDV_Xavier
{
    partial class Confirmar_Pedido
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
            this.components = new System.ComponentModel.Container();
            this.dgv_contatos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_contato = new System.Windows.Forms.TextBox();
            this.lbl_contato = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_tipoPagamento = new System.Windows.Forms.Label();
            this.lbl_valorTotal = new System.Windows.Forms.Label();
            this.lbl_tipoOperacao = new System.Windows.Forms.Label();
            this.lbl_tipoPagamentoHeader = new System.Windows.Forms.Label();
            this.lbl_valorTotalHeader = new System.Windows.Forms.Label();
            this.lbl_tipoOperacaoHeader = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_adicionarContato = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_contatos
            // 
            this.dgv_contatos.AllowUserToAddRows = false;
            this.dgv_contatos.AllowUserToDeleteRows = false;
            this.dgv_contatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_contatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.phone,
            this.email});
            this.dgv_contatos.Location = new System.Drawing.Point(11, 142);
            this.dgv_contatos.Name = "dgv_contatos";
            this.dgv_contatos.ReadOnly = true;
            this.dgv_contatos.RowHeadersVisible = false;
            this.dgv_contatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_contatos.Size = new System.Drawing.Size(304, 198);
            this.dgv_contatos.TabIndex = 0;
            this.dgv_contatos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_contatos_RowEnter);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Nome";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.HeaderText = "Telefone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // txt_contato
            // 
            this.txt_contato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_contato.Location = new System.Drawing.Point(44, 117);
            this.txt_contato.Name = "txt_contato";
            this.txt_contato.Size = new System.Drawing.Size(270, 20);
            this.txt_contato.TabIndex = 1;
            this.txt_contato.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_contato_KeyDown);
            // 
            // lbl_contato
            // 
            this.lbl_contato.AutoSize = true;
            this.lbl_contato.Location = new System.Drawing.Point(13, 101);
            this.lbl_contato.Name = "lbl_contato";
            this.lbl_contato.Size = new System.Drawing.Size(92, 13);
            this.lbl_contato.TabIndex = 2;
            this.lbl_contato.Text = "Pesquisar contato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirme valores:";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirmar.Location = new System.Drawing.Point(12, 346);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(302, 36);
            this.btn_confirmar.TabIndex = 4;
            this.btn_confirmar.Text = "Confirmar operação";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbl_tipoPagamento);
            this.panel1.Controls.Add(this.lbl_valorTotal);
            this.panel1.Controls.Add(this.lbl_tipoOperacao);
            this.panel1.Controls.Add(this.lbl_tipoPagamentoHeader);
            this.panel1.Controls.Add(this.lbl_valorTotalHeader);
            this.panel1.Controls.Add(this.lbl_tipoOperacaoHeader);
            this.panel1.Location = new System.Drawing.Point(16, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 57);
            this.panel1.TabIndex = 5;
            // 
            // lbl_tipoPagamento
            // 
            this.lbl_tipoPagamento.AutoSize = true;
            this.lbl_tipoPagamento.Location = new System.Drawing.Point(146, 40);
            this.lbl_tipoPagamento.Name = "lbl_tipoPagamento";
            this.lbl_tipoPagamento.Size = new System.Drawing.Size(10, 13);
            this.lbl_tipoPagamento.TabIndex = 5;
            this.lbl_tipoPagamento.Text = "-";
            // 
            // lbl_valorTotal
            // 
            this.lbl_valorTotal.AutoSize = true;
            this.lbl_valorTotal.Location = new System.Drawing.Point(146, 22);
            this.lbl_valorTotal.Name = "lbl_valorTotal";
            this.lbl_valorTotal.Size = new System.Drawing.Size(10, 13);
            this.lbl_valorTotal.TabIndex = 4;
            this.lbl_valorTotal.Text = "-";
            // 
            // lbl_tipoOperacao
            // 
            this.lbl_tipoOperacao.AutoSize = true;
            this.lbl_tipoOperacao.Location = new System.Drawing.Point(146, 4);
            this.lbl_tipoOperacao.Name = "lbl_tipoOperacao";
            this.lbl_tipoOperacao.Size = new System.Drawing.Size(10, 13);
            this.lbl_tipoOperacao.TabIndex = 3;
            this.lbl_tipoOperacao.Text = "-";
            // 
            // lbl_tipoPagamentoHeader
            // 
            this.lbl_tipoPagamentoHeader.AutoSize = true;
            this.lbl_tipoPagamentoHeader.Location = new System.Drawing.Point(3, 40);
            this.lbl_tipoPagamentoHeader.Name = "lbl_tipoPagamentoHeader";
            this.lbl_tipoPagamentoHeader.Size = new System.Drawing.Size(110, 13);
            this.lbl_tipoPagamentoHeader.TabIndex = 2;
            this.lbl_tipoPagamentoHeader.Text = "Forma de pagamento:";
            // 
            // lbl_valorTotalHeader
            // 
            this.lbl_valorTotalHeader.AutoSize = true;
            this.lbl_valorTotalHeader.Location = new System.Drawing.Point(3, 22);
            this.lbl_valorTotalHeader.Name = "lbl_valorTotalHeader";
            this.lbl_valorTotalHeader.Size = new System.Drawing.Size(61, 13);
            this.lbl_valorTotalHeader.TabIndex = 1;
            this.lbl_valorTotalHeader.Text = "Valor Total:";
            // 
            // lbl_tipoOperacaoHeader
            // 
            this.lbl_tipoOperacaoHeader.AutoSize = true;
            this.lbl_tipoOperacaoHeader.Location = new System.Drawing.Point(3, 4);
            this.lbl_tipoOperacaoHeader.Name = "lbl_tipoOperacaoHeader";
            this.lbl_tipoOperacaoHeader.Size = new System.Drawing.Size(94, 13);
            this.lbl_tipoOperacaoHeader.TabIndex = 0;
            this.lbl_tipoOperacaoHeader.Text = "Tipo de operação:";
            // 
            // btn_adicionarContato
            // 
            this.btn_adicionarContato.BackgroundImage = global::PDV_Xavier.Properties.Resources.user_plus;
            this.btn_adicionarContato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_adicionarContato.Location = new System.Drawing.Point(16, 116);
            this.btn_adicionarContato.Name = "btn_adicionarContato";
            this.btn_adicionarContato.Size = new System.Drawing.Size(22, 20);
            this.btn_adicionarContato.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btn_adicionarContato, "Adicionar Contato");
            this.btn_adicionarContato.UseVisualStyleBackColor = true;
            this.btn_adicionarContato.Click += new System.EventHandler(this.btn_adicionarContato_Click);
            // 
            // Confirmar_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 394);
            this.Controls.Add(this.btn_adicionarContato);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_contato);
            this.Controls.Add(this.txt_contato);
            this.Controls.Add(this.dgv_contatos);
            this.Name = "Confirmar_Pedido";
            this.Text = "Confirmar pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_contatos;
        private System.Windows.Forms.TextBox txt_contato;
        private System.Windows.Forms.Label lbl_contato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_tipoPagamentoHeader;
        private System.Windows.Forms.Label lbl_valorTotalHeader;
        private System.Windows.Forms.Label lbl_tipoOperacaoHeader;
        private System.Windows.Forms.Label lbl_tipoPagamento;
        private System.Windows.Forms.Label lbl_valorTotal;
        private System.Windows.Forms.Label lbl_tipoOperacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Button btn_adicionarContato;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}