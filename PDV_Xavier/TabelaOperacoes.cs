using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        private void configureColumns()
        {
            dgv_operacoes.Columns["id"].Visible = false;
            dgv_operacoes.Columns["contato"].HeaderText = "Contato";
            dgv_operacoes.Columns["contato"].Width = 200;
            dgv_operacoes.Columns["Valor"].HeaderText = "Valor (R$)";
            dgv_operacoes.Columns["tipo_pagamento"].HeaderText = "Tipo de Pagamento";
            dgv_operacoes.Columns["tipo_operacao"].HeaderText = "Tipo de Operação";
            dgv_operacoes.Columns["criado_em"].HeaderText = "Criado em";
            dgv_operacoes.Columns["criado_em"].Width = 150;
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
            this.configureColumns();

            this.db = db;
        }

        private void dgv_operacoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex > dgv_operacoes.Rows.Count)
                return;

            int idSelecionado = (int)dgv_operacoes.Rows[e.RowIndex].Cells["id"].Value;
            Detalhe_operacao detalhe_operacao = new Detalhe_operacao(idSelecionado);
            detalhe_operacao.ShowDialog();
        }

        public void btn_pesquisar_Click(object sender, EventArgs e)
        {
            dgv_operacoes.DataSource = (
                from o in db.operacoes
                join c in db.contatos on o.id_contato equals c.id
                select new { o, c }
                )
                .AsEnumerable() // <-- executa o restante na memória
                .Where(t =>
                    t.c.nome.ToLower().Contains(txt_contato.Text.ToLower()) &&
                    (chk_filtrarData.Checked == false || (
                    DateTime.ParseExact(t.o.criado_em, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture) >= dtp_inicio.Value &&
                    DateTime.ParseExact(t.o.criado_em, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture) <= dtp_fim.Value
                    )) &&
                    t.o.tipo_pagamento.ToLower().Contains(cbx_tipoPagamento.Text.ToLower()) &&
                    t.o.tipo_operacao.ToLower().Contains(cbx_tipoOperacao.Text.ToLower())
                )
                .OrderByDescending(t => DateTime.ParseExact(t.o.criado_em, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture))
                .Select(t => new
                {
                    t.o.id,
                    contato = t.c.nome,
                    Valor = $"{t.o.valor:C}",
                    t.o.tipo_pagamento,
                    t.o.tipo_operacao,
                    t.o.criado_em,
                })
                .ToList();
            this.configureColumns();
        }
    }
}
