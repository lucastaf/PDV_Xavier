namespace PDV_Xavier
{
    partial class Tela_Gerencial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Gerencial));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tab_clientes = new System.Windows.Forms.TabPage();
            this.btn_cadastrarCliente = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.mtx_telefone = new System.Windows.Forms.MaskedTextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_contato = new System.Windows.Forms.TextBox();
            this.tab_produtos = new System.Windows.Forms.TabPage();
            this.btn_cadastrarProduto = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmb_marca = new System.Windows.Forms.ComboBox();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_produtos = new System.Windows.Forms.TextBox();
            this.lbl_produto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.tab_banco = new System.Windows.Forms.TabPage();
            this.lbl_bdStatus = new System.Windows.Forms.Label();
            this.btn_conectar_banco = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbl_isFornecedor = new System.Windows.Forms.Label();
            this.chk_isFornecedor = new System.Windows.Forms.CheckBox();
            this.tabs.SuspendLayout();
            this.tab_clientes.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tab_produtos.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab_banco.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(248, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(82, 13);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Menu Gerencial";
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tab_clientes);
            this.tabs.Controls.Add(this.tab_produtos);
            this.tabs.Controls.Add(this.tab_banco);
            this.tabs.Location = new System.Drawing.Point(12, 23);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(525, 317);
            this.tabs.TabIndex = 1;
            // 
            // tab_clientes
            // 
            this.tab_clientes.AutoScroll = true;
            this.tab_clientes.Controls.Add(this.panel9);
            this.tab_clientes.Controls.Add(this.btn_cadastrarCliente);
            this.tab_clientes.Controls.Add(this.panel8);
            this.tab_clientes.Controls.Add(this.panel7);
            this.tab_clientes.Controls.Add(this.panel6);
            this.tab_clientes.Location = new System.Drawing.Point(4, 22);
            this.tab_clientes.Name = "tab_clientes";
            this.tab_clientes.Padding = new System.Windows.Forms.Padding(3);
            this.tab_clientes.Size = new System.Drawing.Size(517, 291);
            this.tab_clientes.TabIndex = 0;
            this.tab_clientes.Text = "Contatos";
            this.tab_clientes.UseVisualStyleBackColor = true;
            // 
            // btn_cadastrarCliente
            // 
            this.btn_cadastrarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cadastrarCliente.Location = new System.Drawing.Point(390, 250);
            this.btn_cadastrarCliente.Name = "btn_cadastrarCliente";
            this.btn_cadastrarCliente.Size = new System.Drawing.Size(109, 35);
            this.btn_cadastrarCliente.TabIndex = 11;
            this.btn_cadastrarCliente.Text = "Cadastrar Contatos";
            this.btn_cadastrarCliente.UseVisualStyleBackColor = true;
            this.btn_cadastrarCliente.Click += new System.EventHandler(this.btn_cadastrarCliente_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.lbl_email);
            this.panel8.Controls.Add(this.txt_email);
            this.panel8.Location = new System.Drawing.Point(17, 103);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(482, 34);
            this.panel8.TabIndex = 3;
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(6, 10);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_email.Location = new System.Drawing.Point(179, 7);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(300, 20);
            this.txt_email.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.mtx_telefone);
            this.panel7.Controls.Add(this.lbl_telefone);
            this.panel7.Location = new System.Drawing.Point(17, 63);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(482, 34);
            this.panel7.TabIndex = 2;
            // 
            // mtx_telefone
            // 
            this.mtx_telefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtx_telefone.Location = new System.Drawing.Point(179, 7);
            this.mtx_telefone.Mask = "(99) 00000-0000";
            this.mtx_telefone.Name = "mtx_telefone";
            this.mtx_telefone.Size = new System.Drawing.Size(300, 20);
            this.mtx_telefone.TabIndex = 1;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(6, 10);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefone.TabIndex = 0;
            this.lbl_telefone.Text = "Telefone";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.lbl_nome);
            this.panel6.Controls.Add(this.txt_contato);
            this.panel6.Location = new System.Drawing.Point(17, 23);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(482, 34);
            this.panel6.TabIndex = 1;
            // 
            // lbl_nome
            // 
            this.lbl_nome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(6, 10);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // txt_contato
            // 
            this.txt_contato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_contato.Location = new System.Drawing.Point(179, 7);
            this.txt_contato.Name = "txt_contato";
            this.txt_contato.Size = new System.Drawing.Size(300, 20);
            this.txt_contato.TabIndex = 0;
            // 
            // tab_produtos
            // 
            this.tab_produtos.Controls.Add(this.btn_cadastrarProduto);
            this.tab_produtos.Controls.Add(this.panel5);
            this.tab_produtos.Controls.Add(this.panel4);
            this.tab_produtos.Controls.Add(this.panel3);
            this.tab_produtos.Controls.Add(this.panel2);
            this.tab_produtos.Controls.Add(this.panel1);
            this.tab_produtos.Location = new System.Drawing.Point(4, 22);
            this.tab_produtos.Name = "tab_produtos";
            this.tab_produtos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_produtos.Size = new System.Drawing.Size(517, 291);
            this.tab_produtos.TabIndex = 1;
            this.tab_produtos.Text = "Produtos";
            this.tab_produtos.UseVisualStyleBackColor = true;
            this.tab_produtos.Enter += new System.EventHandler(this.tab_produtos_Enter);
            // 
            // btn_cadastrarProduto
            // 
            this.btn_cadastrarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cadastrarProduto.Location = new System.Drawing.Point(390, 250);
            this.btn_cadastrarProduto.Name = "btn_cadastrarProduto";
            this.btn_cadastrarProduto.Size = new System.Drawing.Size(109, 35);
            this.btn_cadastrarProduto.TabIndex = 10;
            this.btn_cadastrarProduto.Text = "Cadastrar Produto";
            this.btn_cadastrarProduto.UseVisualStyleBackColor = true;
            this.btn_cadastrarProduto.Click += new System.EventHandler(this.btn_cadastrarProduto_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.txt_preco);
            this.panel5.Controls.Add(this.lbl_preco);
            this.panel5.Location = new System.Drawing.Point(17, 183);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(482, 34);
            this.panel5.TabIndex = 9;
            // 
            // txt_preco
            // 
            this.txt_preco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_preco.Location = new System.Drawing.Point(179, 7);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(300, 20);
            this.txt_preco.TabIndex = 4;
            this.txt_preco.TextChanged += new System.EventHandler(this.txt_preco_TextChanged);
            // 
            // lbl_preco
            // 
            this.lbl_preco.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(6, 11);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(35, 13);
            this.lbl_preco.TabIndex = 3;
            this.lbl_preco.Text = "Preço";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.cmb_tipo);
            this.panel4.Controls.Add(this.lbl_tipo);
            this.panel4.Location = new System.Drawing.Point(17, 143);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(482, 34);
            this.panel4.TabIndex = 3;
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Items.AddRange(new object[] {
            "Item1",
            "Item2",
            "Kanye West"});
            this.cmb_tipo.Location = new System.Drawing.Point(179, 7);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(300, 21);
            this.cmb_tipo.TabIndex = 3;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(6, 11);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(28, 13);
            this.lbl_tipo.TabIndex = 0;
            this.lbl_tipo.Text = "Tipo";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.cmb_marca);
            this.panel3.Controls.Add(this.lbl_marca);
            this.panel3.Location = new System.Drawing.Point(17, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(482, 34);
            this.panel3.TabIndex = 2;
            // 
            // cmb_marca
            // 
            this.cmb_marca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_marca.FormattingEnabled = true;
            this.cmb_marca.Items.AddRange(new object[] {
            "Item1",
            "Item2",
            "Kanye West"});
            this.cmb_marca.Location = new System.Drawing.Point(179, 7);
            this.cmb_marca.Name = "cmb_marca";
            this.cmb_marca.Size = new System.Drawing.Size(300, 21);
            this.cmb_marca.TabIndex = 1;
            // 
            // lbl_marca
            // 
            this.lbl_marca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(6, 11);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(37, 13);
            this.lbl_marca.TabIndex = 3;
            this.lbl_marca.Text = "Marca";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.txt_produtos);
            this.panel2.Controls.Add(this.lbl_produto);
            this.panel2.Location = new System.Drawing.Point(17, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 34);
            this.panel2.TabIndex = 1;
            // 
            // txt_produtos
            // 
            this.txt_produtos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_produtos.Location = new System.Drawing.Point(179, 7);
            this.txt_produtos.Name = "txt_produtos";
            this.txt_produtos.Size = new System.Drawing.Size(300, 20);
            this.txt_produtos.TabIndex = 1;
            // 
            // lbl_produto
            // 
            this.lbl_produto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_produto.AutoSize = true;
            this.lbl_produto.Location = new System.Drawing.Point(6, 11);
            this.lbl_produto.Name = "lbl_produto";
            this.lbl_produto.Size = new System.Drawing.Size(35, 13);
            this.lbl_produto.TabIndex = 3;
            this.lbl_produto.Text = "Nome";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbl_codigo);
            this.panel1.Controls.Add(this.txt_codigo);
            this.panel1.Location = new System.Drawing.Point(17, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 34);
            this.panel1.TabIndex = 0;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(6, 10);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(40, 13);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Código";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_codigo.Location = new System.Drawing.Point(179, 7);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(300, 20);
            this.txt_codigo.TabIndex = 0;
            // 
            // tab_banco
            // 
            this.tab_banco.Controls.Add(this.lbl_bdStatus);
            this.tab_banco.Controls.Add(this.btn_conectar_banco);
            this.tab_banco.Location = new System.Drawing.Point(4, 22);
            this.tab_banco.Name = "tab_banco";
            this.tab_banco.Padding = new System.Windows.Forms.Padding(3);
            this.tab_banco.Size = new System.Drawing.Size(517, 291);
            this.tab_banco.TabIndex = 2;
            this.tab_banco.Text = "Banco";
            this.tab_banco.UseVisualStyleBackColor = true;
            // 
            // lbl_bdStatus
            // 
            this.lbl_bdStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_bdStatus.AutoSize = true;
            this.lbl_bdStatus.Location = new System.Drawing.Point(150, 39);
            this.lbl_bdStatus.Name = "lbl_bdStatus";
            this.lbl_bdStatus.Size = new System.Drawing.Size(85, 13);
            this.lbl_bdStatus.TabIndex = 5;
            this.lbl_bdStatus.Text = "Status do banco";
            // 
            // btn_conectar_banco
            // 
            this.btn_conectar_banco.Location = new System.Drawing.Point(6, 22);
            this.btn_conectar_banco.Name = "btn_conectar_banco";
            this.btn_conectar_banco.Size = new System.Drawing.Size(138, 46);
            this.btn_conectar_banco.TabIndex = 4;
            this.btn_conectar_banco.Text = "Conectar Banco";
            this.btn_conectar_banco.UseVisualStyleBackColor = true;
            this.btn_conectar_banco.Click += new System.EventHandler(this.btn_conectar_banco_Click);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.chk_isFornecedor);
            this.panel9.Controls.Add(this.lbl_isFornecedor);
            this.panel9.Location = new System.Drawing.Point(17, 143);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(482, 34);
            this.panel9.TabIndex = 4;
            // 
            // lbl_isFornecedor
            // 
            this.lbl_isFornecedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_isFornecedor.AutoSize = true;
            this.lbl_isFornecedor.Location = new System.Drawing.Point(6, 10);
            this.lbl_isFornecedor.Name = "lbl_isFornecedor";
            this.lbl_isFornecedor.Size = new System.Drawing.Size(122, 13);
            this.lbl_isFornecedor.TabIndex = 0;
            this.lbl_isFornecedor.Text = "Contato é de fornecedor";
            // 
            // chk_isFornecedor
            // 
            this.chk_isFornecedor.AutoSize = true;
            this.chk_isFornecedor.Location = new System.Drawing.Point(464, 9);
            this.chk_isFornecedor.Name = "chk_isFornecedor";
            this.chk_isFornecedor.Size = new System.Drawing.Size(15, 14);
            this.chk_isFornecedor.TabIndex = 1;
            this.chk_isFornecedor.UseVisualStyleBackColor = true;
            // 
            // Tela_Gerencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(549, 352);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.lbl_titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_Gerencial";
            this.Text = "Tela_Gerencial";
            this.tabs.ResumeLayout(false);
            this.tab_clientes.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tab_produtos.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab_banco.ResumeLayout(false);
            this.tab_banco.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tab_clientes;
        private System.Windows.Forms.TabPage tab_produtos;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox txt_produtos;
        private System.Windows.Forms.Label lbl_produto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.ComboBox cmb_marca;
        private System.Windows.Forms.Button btn_cadastrarProduto;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_contato;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.MaskedTextBox mtx_telefone;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_cadastrarCliente;
        private System.Windows.Forms.TabPage tab_banco;
        private System.Windows.Forms.Label lbl_bdStatus;
        private System.Windows.Forms.Button btn_conectar_banco;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lbl_isFornecedor;
        private System.Windows.Forms.CheckBox chk_isFornecedor;
    }
}