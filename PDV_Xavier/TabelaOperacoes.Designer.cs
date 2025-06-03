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
            this.dgv_operacoes = new System.Windows.Forms.DataGridView();
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
            // TabelaOperacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_operacoes);
            this.Name = "TabelaOperacoes";
            this.Size = new System.Drawing.Size(695, 428);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_operacoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_operacoes;
    }
}
