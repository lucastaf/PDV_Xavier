namespace PDV_Xavier
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
            this.btn_conectar_banco = new System.Windows.Forms.Button();
            this.list_produtos = new System.Windows.Forms.ListBox();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.lbl_bdStatus = new System.Windows.Forms.Label();
            this.btn_gerenciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_conectar_banco
            // 
            this.btn_conectar_banco.Location = new System.Drawing.Point(12, 12);
            this.btn_conectar_banco.Name = "btn_conectar_banco";
            this.btn_conectar_banco.Size = new System.Drawing.Size(99, 32);
            this.btn_conectar_banco.TabIndex = 0;
            this.btn_conectar_banco.Text = "Conectar Banco";
            this.btn_conectar_banco.UseVisualStyleBackColor = true;
            this.btn_conectar_banco.Click += new System.EventHandler(this.btn_conectar_banco_Click);
            // 
            // list_produtos
            // 
            this.list_produtos.FormattingEnabled = true;
            this.list_produtos.Location = new System.Drawing.Point(12, 141);
            this.list_produtos.Name = "list_produtos";
            this.list_produtos.Size = new System.Drawing.Size(277, 108);
            this.list_produtos.TabIndex = 1;
            this.list_produtos.SelectedIndexChanged += new System.EventHandler(this.list_produtos_SelectedIndexChanged);
            // 
            // txt_productName
            // 
            this.txt_productName.Location = new System.Drawing.Point(12, 115);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(277, 20);
            this.txt_productName.TabIndex = 2;
            this.txt_productName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_productName_KeyDown);
            // 
            // lbl_bdStatus
            // 
            this.lbl_bdStatus.AutoSize = true;
            this.lbl_bdStatus.Location = new System.Drawing.Point(12, 47);
            this.lbl_bdStatus.Name = "lbl_bdStatus";
            this.lbl_bdStatus.Size = new System.Drawing.Size(85, 13);
            this.lbl_bdStatus.TabIndex = 3;
            this.lbl_bdStatus.Text = "Status do banco";
            // 
            // btn_gerenciar
            // 
            this.btn_gerenciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_gerenciar.Location = new System.Drawing.Point(506, 13);
            this.btn_gerenciar.Name = "btn_gerenciar";
            this.btn_gerenciar.Size = new System.Drawing.Size(75, 31);
            this.btn_gerenciar.TabIndex = 4;
            this.btn_gerenciar.Text = "Gerenciar";
            this.btn_gerenciar.UseVisualStyleBackColor = true;
            this.btn_gerenciar.Click += new System.EventHandler(this.btn_gerenciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Produto";
            // 
            // PDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_gerenciar);
            this.Controls.Add(this.lbl_bdStatus);
            this.Controls.Add(this.txt_productName);
            this.Controls.Add(this.list_produtos);
            this.Controls.Add(this.btn_conectar_banco);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PDV";
            this.Text = "PDV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_conectar_banco;
        private System.Windows.Forms.ListBox list_produtos;
        private System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.Label lbl_bdStatus;
        private System.Windows.Forms.Button btn_gerenciar;
        private System.Windows.Forms.Label label1;
    }
}

