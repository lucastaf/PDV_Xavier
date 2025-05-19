using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

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
            if (connectionString != null)
            {
                db = new AppDbContext(connectionString);
            }
        }

        private void btn_conectar_banco_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "Banco de Dados Access (*.accdb)|*.accdb|Access 2003 (*.mdb)|*.mdb";
            dialog.Title = "Selecione o banco de dados Access";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoBanco = dialog.FileName;
                db = new AppDbContext(caminhoBanco);
                db.Database.EnsureCreated(); // cria o banco se não existir
                Console.WriteLine("Conectando ao banco");
                Properties.Settings.Default.CaminhoBanco = caminhoBanco;
                Properties.Settings.Default.Save();

            }
        }

        private void txt_productName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                string termoBusca = txt_productName.Text.ToLower();

                // Consulta ao banco com filtro case-insensitive
                var produtosFiltrados = db.produtos
                    .Where(p => p.nome.ToLower().Contains(termoBusca))
                    .ToList(); // Importante materializar a lista antes de usar como DataSource

                list_produtos.DisplayMember = "nome";
                list_produtos.ValueMember = "codigo";
                list_produtos.DataSource = produtosFiltrados;
            }
        }

        private void list_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(list_produtos.SelectedValue.ToString());
        }
    }
}

