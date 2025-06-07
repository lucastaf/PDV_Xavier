using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace PDV_Xavier
{
    public partial class PDV : Form
    {
        //https://www.microsoft.com/en-us/download/details.aspx?id=54920
        AppDbContext db;
        string connectionString = Properties.Settings.Default.CaminhoBanco;
        public PDV()
        {
            Console.WriteLine("Iniciando o PDV");
            Console.WriteLine(connectionString);
            InitializeComponent();
            try
            {
                db = new AppDbContext(Properties.Settings.Default.CaminhoBanco);
                db.Database.EnsureCreated();
            }
            catch
            {
                MessageBox.Show("Banco não encontrado, por favor conecte um banco de dados no menu gerencial");
            }
        }


        private void btn_gerenciar_Click(object sender, EventArgs e)
        {
            var gerencial = new Tela_Gerencial();
            gerencial.Show();
        }

        private void txt_productName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                string termoBusca = txt_productName.Text.ToLower();

                // Consulta ao banco com filtro case-insensitive
                var produtosFiltrados = db.produtos
                    .Where(p => p.nome.ToLower().Contains(termoBusca) || p.codigo.Equals(termoBusca))
                    .Select(p => new
                    {
                        Produto = p,
                        Display = $"{p.codigo} - {p.nome} - {p.preco:C}" // Formata o preço como moeda
                    })
                    .ToList(); // Importante materializar a lista antes de usar como DataSource

                list_produtos.DisplayMember = "Display";
                list_produtos.ValueMember = "Produto";
                list_produtos.DataSource = produtosFiltrados;
            }
        }


        private void btn_removerSelecao_Click(object sender, EventArgs e)
        {
            if(dgv_produtosSelecionados.CurrentRow == null)
            {
                return;
            }
            dgv_produtosSelecionados.Rows.RemoveAt(dgv_produtosSelecionados.CurrentRow.Index);
            recalcularValorTotal();
        }

        private void dgv_produtosSelecionados_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            recalcularValorTotal();
        }

        private void recalcularValorTotal()
        {

            decimal total = 0;
            foreach (DataGridViewRow row in dgv_produtosSelecionados.Rows)
            {
                try
                {
                    if (row.Cells["valor"].Value != null)
                    {
                        total += Convert.ToDecimal(row.Cells["valor"].Value);
                    }
                }
                catch { }
            }
            txt_valorFinal.Text = $"{total:C}";
        }

        private void txt_valorFinal_TextChanged(object sender, EventArgs e)
        {
            string texto = txt_valorFinal.Text.Replace("R$", "").Replace(",", "").Replace(".", "").TrimStart('0');
            if (decimal.TryParse(texto, out decimal valor))
            {
                valor = valor / 100;
                txt_valorFinal.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", valor);
                txt_valorFinal.Select(txt_valorFinal.Text.Length, 0); // mantém o cursor no fim
            }
            else
            {
                txt_valorFinal.Text = "R$ 0,00";
                txt_valorFinal.Select(txt_valorFinal.Text.Length, 0);
            }
        }

        private void btn_adicionarProduto_Click(object sender, EventArgs e)
        {
            Produtos selectedValue = (Produtos)list_produtos.SelectedValue;
            var quantidade = (int)nud_quantidadeProdutos.Value;
            dgv_produtosSelecionados.Rows.Add(selectedValue.id, selectedValue.nome, quantidade, selectedValue.preco * quantidade);
            recalcularValorTotal();
        }

        private void btn_finalizarPedido_Click(object sender, EventArgs e)
        {
            if (!dgv_produtosSelecionados.Rows.Cast<DataGridViewRow>().Any())
            {
                MessageBox.Show("Nenhum produto selecionado para o pedido.");
                return;
            }
            Registros[] registros = dgv_produtosSelecionados.Rows
                .Cast<DataGridViewRow>()
                .Select(row => new Registros
                {
                    id_produto = (int)row.Cells["Id"].Value,
                    valor = Convert.ToSingle(row.Cells["valor"].Value) * (chk_operacaoCompra.Checked ? -1 : 1),
                    quantidade = Convert.ToInt32(row.Cells["quantidade"].Value) * (chk_operacaoCompra.Checked ? 1 : -1),
                })
                .ToArray();

            if (chk_operacaoCompra.Checked == false)
            {
                string estoque = db.checkEstoque(registros);
                if (!string.IsNullOrEmpty(estoque))
                {
                    MessageBox.Show(estoque, "Estoque Insuficiente, cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            string valorFinal_string = txt_valorFinal.Text;
            valorFinal_string = valorFinal_string.Replace("R$ ", "").Replace(".", "").Replace(",", ".");
            float valor = float.Parse(valorFinal_string, CultureInfo.InvariantCulture.NumberFormat) * (chk_operacaoCompra.Checked ? -1 : 1);
            string tipo_pagamento = cmb_tipoPagamento.Text;

            Confirmar_Pedido confirmar_pedido = new Confirmar_Pedido(registros, valor, tipo_pagamento, chk_operacaoCompra.Checked, this);
            confirmar_pedido.ShowDialog();
        }

        public void clearFields()
        {
            txt_productName.Clear();
            list_produtos.DataSource = null;
            dgv_produtosSelecionados.Rows.Clear();
            txt_valorFinal.Text = "R$ 0,00";
            nud_quantidadeProdutos.Value = 1;
            cmb_tipoPagamento.SelectedIndex = 0; // Reseta para o primeiro item
            chk_operacaoCompra.Checked = false; // Reseta a checkbox de compra
        }
    }
}

