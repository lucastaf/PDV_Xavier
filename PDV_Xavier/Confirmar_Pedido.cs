using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV_Xavier
{
    internal partial class Confirmar_Pedido : Form
    {
        private float valor;
        private string tipo_pagamento;
        private string tipo_operacao;
        private int contato_selecionado;
        private Registros[] registros;
        AppDbContext db;


        public Confirmar_Pedido(Registros[] registros, float valor, string tipo_pagamento, string tipo_operacao)
        {
            this.valor = valor;
            this.tipo_pagamento = tipo_pagamento;
            this.tipo_operacao = tipo_operacao;
            this.registros = registros;


            InitializeComponent();

            lbl_valorTotal.Text = $"{valor:C}";
            lbl_tipoPagamento.Text = tipo_pagamento;
            lbl_tipoOperacao.Text = tipo_operacao;
            try
            {
                string connectionString = Properties.Settings.Default.CaminhoBanco;
                if (connectionString != null)
                {
                    db = new AppDbContext(connectionString);
                    db.Database.EnsureCreated();
                }
            }
            catch
            {
                MessageBox.Show("Erro ao conectar ao banco de dados.");
            }
        }

        private void txt_contato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                string termoBusca = txt_contato.Text.ToLower();

                //Consulta ao banco com filtro case -insensitive
                var contatosFiltrados = db.contatos
                    .Where(p => p.nome.ToLower().Contains(termoBusca)).Select(p => new
                    {
                        id = p.id,
                        name = p.nome,
                        phone = p.telefone,
                        email = p.email

                    })
                    .ToList(); // Importante materializar a lista antes de usar como DataSource

                foreach (var registro in contatosFiltrados)
                {
                    dgv_contatos.Rows.Add(registro.id, registro.name, registro.phone, registro.email);
                }
            }
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            var novaOperacao = db.operacoes.Add(new Operacoes
            {
                id_contato = contato_selecionado,
                tipo_operacao = tipo_operacao,
                tipo_pagamento = tipo_pagamento,
                valor = valor,
                criado_em = DateTime.Now.ToString()
            });
            db.SaveChanges();
            foreach (var registro in this.registros)
            {
                db.registros.Add(new Registros
                {
                    id_produto = registro.id_produto,
                    id_operacao = novaOperacao.Entity.id, // Referência à nova operação
                    quantidade = registro.quantidade,
                    valor = registro.valor
                });
            }
            db.SaveChanges();
            MessageBox.Show("Pedido confirmado com sucesso!");
            this.Close();
        }

        private void dgv_contatos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_contatos.SelectedRows.Count > 0)
            {

                this.contato_selecionado = Convert.ToInt32(dgv_contatos.SelectedRows[0].Cells["id"].Value);
            }
        }

        private void btn_adicionarContato_Click(object sender, EventArgs e)
        {
            var menuGerencial = new Tela_Gerencial();

            menuGerencial.ShowDialog();
        }
    }
}
