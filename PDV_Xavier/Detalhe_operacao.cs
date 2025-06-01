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
    public partial class Detalhe_operacao : Form
    {
        AppDbContext db;
        int id_operacao;
        string email;
        string telefone;

        public Detalhe_operacao(int id_operacao)
        {
            this.id_operacao = id_operacao;
            try
            {
                string connectionString = Properties.Settings.Default.CaminhoBanco;
                db = new AppDbContext(connectionString);
            }
            catch { }

            var operacao =
                (
                from o in db.operacoes
                join c in db.contatos on o.id_contato equals c.id
                where o.id == id_operacao
                select new
                {
                    o = o,
                    c = c,
                }
                ).FirstOrDefault();

            var registros = (
                from r in db.registros
                join p in db.produtos on r.id_produto equals p.id
                where r.id_operacao == id_operacao
                select new
                {
                    id = r.id,
                    Codigo = p.codigo,
                    Produto = p.nome,
                    Quantidade = r.quantidade,
                    Valor = $"{r.valor:C}",
                }
                );

            this.email = operacao.c.email;
            this.telefone = operacao.c.telefone;


            InitializeComponent();
            if (operacao.o.tipo_pagamento == "Pendente")
            {
                btn_confirmarPagamento.Visible = true;
                cmb_tipoPagamento.Visible = true;
            }
            lbl_id.Text = operacao.o.id.ToString();
            lbl_tipo_operacao.Text = operacao.o.tipo_operacao;
            lbl_tipo_pagamento.Text = operacao.o.tipo_pagamento;
            lbl_data_operacao.Text = operacao.o.criado_em;
            txt_valor.Text = operacao.o.valor.ToString("C2");

            lbl_id_contato.Text = operacao.o.id_contato.ToString();
            lbl_nome_contato.Text = operacao.c.nome;
            btn_email.Text = operacao.c.email;
            btn_telefone.Text = operacao.c.telefone;

            dgv_regitstros.DataSource = registros.ToList();

        }

        private void btn_telefone_Click(object sender, EventArgs e)
        {
            //Abre whatsapp (wa.me/telefone)
            try
            {
                string telefoneFiltrado = telefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
                Console.Write(telefoneFiltrado);
                System.Diagnostics.Process.Start($"https://wa.me/55{telefoneFiltrado}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o WhatsApp: " + ex.Message);
            }
        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            //enviar email
            try
            {
                System.Diagnostics.Process.Start($"mailto:{email}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o cliente de email: " + ex.Message);
            }
        }

        private void btn_confirmarPagamento_Click(object sender, EventArgs e)
        {
            try
            {

                string tipoPagamento = cmb_tipoPagamento.SelectedItem?.ToString();
                (from o in db.operacoes
                 where o.id == id_operacao
                 select o).ToList().ForEach(o => o.tipo_pagamento = tipoPagamento);
                db.SaveChanges();
                cmb_tipoPagamento.Visible = false;
                btn_confirmarPagamento.Visible = false;
                MessageBox.Show("Pagamento confirmado com sucesso!");
            }
            catch
            {
                MessageBox.Show("Erro ao confirmar pagamento");
            }
        }
    }
}
