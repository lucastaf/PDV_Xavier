using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV_Xavier
{
    public partial class Tela_Gerencial : Form
    {
        AppDbContext db;
        private string connectionString = Properties.Settings.Default.CaminhoBanco;
        public Tela_Gerencial()
        {
            InitializeComponent();
            try
            {
                if (connectionString != null)
                {
                    db = new AppDbContext(connectionString);
                    db.Database.EnsureCreated();
                    lbl_bdStatus.Text = "Conexão com banco estabelecida";
                }
            }
            catch
            {
                lbl_bdStatus.Text = "Banco desconectado";
            }
        }

        private void btn_conectar_banco_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "Banco de Dados Access (*.accdb)|*.accdb|Access 2003 (*.mdb)|*.mdb";
            dialog.Title = "Selecione o banco de dados Access";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    string caminhoBanco = dialog.FileName;
                    db = new AppDbContext(caminhoBanco);
                    db.Database.EnsureCreated(); // cria o banco se não existir
                    Properties.Settings.Default.CaminhoBanco = caminhoBanco;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Banco conectado com sucesso");
                    lbl_bdStatus.Text = "Conexão com banco estabelecida";
                }
                catch
                {
                    MessageBox.Show("Erro ao se conectar ao banco");
                }
            }
        }

        private void tab_produtos_Enter(object sender, EventArgs e)
        {
            var marcas = db.produtos.Select(p => p.marca).Distinct().ToList();
            var tipos = db.produtos.Select(p => p.tipo_produto).Distinct().ToList();
            cmb_marca.DataSource = marcas;
            cmb_tipo.DataSource = tipos;
        }

        private void txt_preco_TextChanged(object sender, EventArgs e)
        {
            string texto = txt_preco.Text.Replace("R$", "").Replace(",", "").Replace(".", "").TrimStart('0');
            if (decimal.TryParse(texto, out decimal valor))
            {
                valor = valor / 100;
                txt_preco.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", valor);
                txt_preco.Select(txt_preco.Text.Length, 0); // mantém o cursor no fim
            }
            else
            {
                txt_preco.Text = "R$ 0,00";
                txt_preco.Select(txt_preco.Text.Length, 0);
            }
        }

        private void btn_cadastrarProduto_Click(object sender, EventArgs e)
        {
            var produto = new Produtos
            {
                codigo = txt_codigo.Text,
                marca = cmb_marca.Text,
                nome = txt_produtos.Text,
                preco = decimal.Parse(txt_preco.Text.Replace("R$", "").TrimStart('0')),
                tipo_produto = cmb_tipo.Text
            };
            db.produtos.Add(produto);
            db.SaveChanges();

            MessageBox.Show("Produto cadastrado com sucesso");
        }

        private void btn_cadastrarCliente_Click(object sender, EventArgs e)
        {
            var cliente = new Contatos
            {
                nome = txt_contato.Text,
                telefone = mtx_telefone.Text,
                email = txt_email.Text,
                is_fornecedor = chk_isFornecedor.Checked ? 1 : 0 // 0 - cliente, 1 - fornecedor
            };
            db.contatos.Add(cliente);
            db.SaveChanges();

            MessageBox.Show("Cliente cadastrado com sucesso");
        }

        private void tab_operacoes_Enter(object sender, EventArgs e)
        {
            dgv_operacoes.DataSource = (
            from o in db.operacoes
            join c in db.contatos on o.id_contato equals c.id
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
        }



        private void dgv_operacoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idSelecionado = (int)dgv_operacoes.Rows[e.RowIndex].Cells["id"].Value;
            Detalhe_operacao detalhe_operacao = new Detalhe_operacao(idSelecionado);
            detalhe_operacao.ShowDialog();
        }

        private void tab_estoque_Enter(object sender, EventArgs e)
        {
            db.produtos.Load();
            dgv_produtos.DataSource = db.produtos.Local.ToBindingList();
            dgv_produtos.Columns["id"].Visible = false; // Oculta a coluna de ID
            dgv_produtos.Columns["preco"].DefaultCellStyle.Format = "C2"; // Formato moeda
        }

        private void refresh_database(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Erro ao salvar as alterações no produto.");
            }
        }

        private void tab_lista_contatos_Enter(object sender, EventArgs e)
        {
            db.contatos.Load();
            dgv_contatos.DataSource = db.contatos.Local.ToBindingList();
            dgv_contatos.Columns["id"].Visible = false; // Oculta a coluna de ID
        }
    }
}
