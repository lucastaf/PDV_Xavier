﻿namespace PDV_Xavier
{
    partial class PDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDV));
            this.list_produtos = new System.Windows.Forms.ListBox();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.btn_gerenciar = new System.Windows.Forms.Button();
            this.dgv_produtosSelecionados = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_pesquisar = new System.Windows.Forms.Label();
            this.nud_quantidadeProdutos = new System.Windows.Forms.NumericUpDown();
            this.btn_adicionarProduto = new System.Windows.Forms.Button();
            this.btn_removerSelecao = new System.Windows.Forms.Button();
            this.btn_finalizarPedido = new System.Windows.Forms.Button();
            this.txt_valorFinal = new System.Windows.Forms.TextBox();
            this.cmb_tipoPagamento = new System.Windows.Forms.ComboBox();
            this.chk_operacaoCompra = new System.Windows.Forms.CheckBox();
            this.lbl_valorFinal = new System.Windows.Forms.Label();
            this.lbl_tipoPagamento = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtosSelecionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantidadeProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // list_produtos
            // 
            this.list_produtos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.list_produtos.FormattingEnabled = true;
            this.list_produtos.Location = new System.Drawing.Point(12, 98);
            this.list_produtos.Name = "list_produtos";
            this.list_produtos.Size = new System.Drawing.Size(275, 277);
            this.list_produtos.TabIndex = 1;
            // 
            // txt_productName
            // 
            this.txt_productName.Location = new System.Drawing.Point(13, 72);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(277, 20);
            this.txt_productName.TabIndex = 2;
            this.txt_productName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_productName_KeyDown);
            // 
            // btn_gerenciar
            // 
            this.btn_gerenciar.Location = new System.Drawing.Point(12, 12);
            this.btn_gerenciar.Name = "btn_gerenciar";
            this.btn_gerenciar.Size = new System.Drawing.Size(75, 31);
            this.btn_gerenciar.TabIndex = 4;
            this.btn_gerenciar.Text = "Gerenciar";
            this.btn_gerenciar.UseVisualStyleBackColor = true;
            this.btn_gerenciar.Click += new System.EventHandler(this.btn_gerenciar_Click);
            // 
            // dgv_produtosSelecionados
            // 
            this.dgv_produtosSelecionados.AllowUserToAddRows = false;
            this.dgv_produtosSelecionados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_produtosSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produtosSelecionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nome,
            this.quantidade,
            this.valor});
            this.dgv_produtosSelecionados.Location = new System.Drawing.Point(416, 72);
            this.dgv_produtosSelecionados.Name = "dgv_produtosSelecionados";
            this.dgv_produtosSelecionados.RowHeadersVisible = false;
            this.dgv_produtosSelecionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_produtosSelecionados.Size = new System.Drawing.Size(305, 303);
            this.dgv_produtosSelecionados.TabIndex = 6;
            this.dgv_produtosSelecionados.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_produtosSelecionados_CellEndEdit);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            // 
            // lbl_pesquisar
            // 
            this.lbl_pesquisar.AutoSize = true;
            this.lbl_pesquisar.Location = new System.Drawing.Point(12, 56);
            this.lbl_pesquisar.Name = "lbl_pesquisar";
            this.lbl_pesquisar.Size = new System.Drawing.Size(97, 13);
            this.lbl_pesquisar.TabIndex = 7;
            this.lbl_pesquisar.Text = "Pesquisar produtos";
            // 
            // nud_quantidadeProdutos
            // 
            this.nud_quantidadeProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nud_quantidadeProdutos.Location = new System.Drawing.Point(12, 413);
            this.nud_quantidadeProdutos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_quantidadeProdutos.Name = "nud_quantidadeProdutos";
            this.nud_quantidadeProdutos.Size = new System.Drawing.Size(120, 20);
            this.nud_quantidadeProdutos.TabIndex = 8;
            this.nud_quantidadeProdutos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_adicionarProduto
            // 
            this.btn_adicionarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_adicionarProduto.Location = new System.Drawing.Point(170, 399);
            this.btn_adicionarProduto.Name = "btn_adicionarProduto";
            this.btn_adicionarProduto.Size = new System.Drawing.Size(117, 34);
            this.btn_adicionarProduto.TabIndex = 9;
            this.btn_adicionarProduto.Text = "Adicionar produto";
            this.btn_adicionarProduto.UseVisualStyleBackColor = true;
            this.btn_adicionarProduto.Click += new System.EventHandler(this.btn_adicionarProduto_Click);
            // 
            // btn_removerSelecao
            // 
            this.btn_removerSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_removerSelecao.Location = new System.Drawing.Point(600, 52);
            this.btn_removerSelecao.Name = "btn_removerSelecao";
            this.btn_removerSelecao.Size = new System.Drawing.Size(121, 20);
            this.btn_removerSelecao.TabIndex = 10;
            this.btn_removerSelecao.Text = "Remover selecionado";
            this.btn_removerSelecao.UseVisualStyleBackColor = true;
            this.btn_removerSelecao.Click += new System.EventHandler(this.btn_removerSelecao_Click);
            // 
            // btn_finalizarPedido
            // 
            this.btn_finalizarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_finalizarPedido.Location = new System.Drawing.Point(612, 450);
            this.btn_finalizarPedido.Name = "btn_finalizarPedido";
            this.btn_finalizarPedido.Size = new System.Drawing.Size(109, 41);
            this.btn_finalizarPedido.TabIndex = 11;
            this.btn_finalizarPedido.Text = "Finalizar Pedido";
            this.btn_finalizarPedido.UseVisualStyleBackColor = true;
            this.btn_finalizarPedido.Click += new System.EventHandler(this.btn_finalizarPedido_Click);
            // 
            // txt_valorFinal
            // 
            this.txt_valorFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_valorFinal.Location = new System.Drawing.Point(498, 382);
            this.txt_valorFinal.Name = "txt_valorFinal";
            this.txt_valorFinal.Size = new System.Drawing.Size(223, 20);
            this.txt_valorFinal.TabIndex = 12;
            this.txt_valorFinal.TextChanged += new System.EventHandler(this.txt_valorFinal_TextChanged);
            // 
            // cmb_tipoPagamento
            // 
            this.cmb_tipoPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_tipoPagamento.FormattingEnabled = true;
            this.cmb_tipoPagamento.Items.AddRange(new object[] {
            "Pix",
            "Débito",
            "Crédito",
            "Dinheiro",
            "Pendente"});
            this.cmb_tipoPagamento.Location = new System.Drawing.Point(544, 407);
            this.cmb_tipoPagamento.Name = "cmb_tipoPagamento";
            this.cmb_tipoPagamento.Size = new System.Drawing.Size(177, 21);
            this.cmb_tipoPagamento.TabIndex = 14;
            this.cmb_tipoPagamento.Text = "Pix";
            // 
            // chk_operacaoCompra
            // 
            this.chk_operacaoCompra.AutoSize = true;
            this.chk_operacaoCompra.Location = new System.Drawing.Point(590, 12);
            this.chk_operacaoCompra.Name = "chk_operacaoCompra";
            this.chk_operacaoCompra.Size = new System.Drawing.Size(132, 17);
            this.chk_operacaoCompra.TabIndex = 15;
            this.chk_operacaoCompra.Text = "Operação de restoque";
            this.chk_operacaoCompra.UseVisualStyleBackColor = true;
            // 
            // lbl_valorFinal
            // 
            this.lbl_valorFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_valorFinal.AutoSize = true;
            this.lbl_valorFinal.Location = new System.Drawing.Point(439, 385);
            this.lbl_valorFinal.Name = "lbl_valorFinal";
            this.lbl_valorFinal.Size = new System.Drawing.Size(53, 13);
            this.lbl_valorFinal.TabIndex = 13;
            this.lbl_valorFinal.Text = "Valor final";
            // 
            // lbl_tipoPagamento
            // 
            this.lbl_tipoPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_tipoPagamento.AutoSize = true;
            this.lbl_tipoPagamento.Location = new System.Drawing.Point(439, 410);
            this.lbl_tipoPagamento.Name = "lbl_tipoPagamento";
            this.lbl_tipoPagamento.Size = new System.Drawing.Size(99, 13);
            this.lbl_tipoPagamento.TabIndex = 16;
            this.lbl_tipoPagamento.Text = "Tipo de pagamento";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(12, 397);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(62, 13);
            this.lbl_quantidade.TabIndex = 17;
            this.lbl_quantidade.Text = "Quantidade";
            // 
            // PDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 503);
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.lbl_tipoPagamento);
            this.Controls.Add(this.chk_operacaoCompra);
            this.Controls.Add(this.cmb_tipoPagamento);
            this.Controls.Add(this.lbl_valorFinal);
            this.Controls.Add(this.txt_valorFinal);
            this.Controls.Add(this.btn_finalizarPedido);
            this.Controls.Add(this.btn_removerSelecao);
            this.Controls.Add(this.btn_adicionarProduto);
            this.Controls.Add(this.nud_quantidadeProdutos);
            this.Controls.Add(this.lbl_pesquisar);
            this.Controls.Add(this.dgv_produtosSelecionados);
            this.Controls.Add(this.btn_gerenciar);
            this.Controls.Add(this.txt_productName);
            this.Controls.Add(this.list_produtos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PDV";
            this.Text = "PDV";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtosSelecionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantidadeProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox list_produtos;
        private System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.Button btn_gerenciar;
        private System.Windows.Forms.DataGridView dgv_produtosSelecionados;
        private System.Windows.Forms.Label lbl_pesquisar;
        private System.Windows.Forms.NumericUpDown nud_quantidadeProdutos;
        private System.Windows.Forms.Button btn_adicionarProduto;
        private System.Windows.Forms.Button btn_removerSelecao;
        private System.Windows.Forms.Button btn_finalizarPedido;
        private System.Windows.Forms.TextBox txt_valorFinal;
        private System.Windows.Forms.ComboBox cmb_tipoPagamento;
        private System.Windows.Forms.CheckBox chk_operacaoCompra;
        private System.Windows.Forms.Label lbl_valorFinal;
        private System.Windows.Forms.Label lbl_tipoPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.Label lbl_quantidade;
    }
}

