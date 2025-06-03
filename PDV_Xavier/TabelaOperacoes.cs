using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV_Xavier
{
    internal partial class TabelaOperacoes : UserControl
    {
        AppDbContext db;
        public TabelaOperacoes()
        {
            InitializeComponent();
        }

        public void loadData(AppDbContext db)
        {
            dgv_operacoes.DataSource = (
            from o in db.operacoes
            join c in db.contatos on o.id_contato equals c.id
            orderby o.criado_em descending
            select new
            {
                o.id,
                contato = c.nome,
                Valor = $"{o.valor:C}",
                o.tipo_pagamento,
                o.tipo_operacao,
                o.criado_em,
            }).ToList();
            dgv_operacoes.Columns["id"].Visible = false;
            dgv_operacoes.Columns["contato"].HeaderText = "Contato";
            dgv_operacoes.Columns["Valor"].HeaderText = "Valor (R$)";
            dgv_operacoes.Columns["tipo_pagamento"].HeaderText = "Tipo de Pagamento";
            dgv_operacoes.Columns["tipo_operacao"].HeaderText = "Tipo de Operação";
            dgv_operacoes.Columns["criado_em"].HeaderText = "Criado em";

            this.db = db;
        }

        private void dgv_operacoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idSelecionado = (int)dgv_operacoes.Rows[e.RowIndex].Cells["id"].Value;
            Detalhe_operacao detalhe_operacao = new Detalhe_operacao(idSelecionado);
            detalhe_operacao.ShowDialog();
        }
    }
}
