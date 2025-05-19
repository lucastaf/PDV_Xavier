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
            this.btn_conectar_banco = new System.Windows.Forms.Button();
            this.list_produtos = new System.Windows.Forms.ListBox();
            this.txt_productName = new System.Windows.Forms.TextBox();
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
            this.list_produtos.Location = new System.Drawing.Point(12, 144);
            this.list_produtos.Name = "list_produtos";
            this.list_produtos.Size = new System.Drawing.Size(277, 108);
            this.list_produtos.TabIndex = 1;
            this.list_produtos.SelectedIndexChanged += new System.EventHandler(this.list_produtos_SelectedIndexChanged);
            // 
            // txt_productName
            // 
            this.txt_productName.Location = new System.Drawing.Point(12, 118);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(277, 20);
            this.txt_productName.TabIndex = 2;
            this.txt_productName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_productName_KeyDown);
            // 
            // PDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_productName);
            this.Controls.Add(this.list_produtos);
            this.Controls.Add(this.btn_conectar_banco);
            this.Name = "PDV";
            this.Text = "PDV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_conectar_banco;
        private System.Windows.Forms.ListBox list_produtos;
        private System.Windows.Forms.TextBox txt_productName;
    }
}

