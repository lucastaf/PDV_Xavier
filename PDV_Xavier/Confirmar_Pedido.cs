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
    public partial class Confirmar_Pedido : Form
    {
        private float valor;
        private string tipo_pagamento;
        private string tipo_operacao;
        private Registros[] registros;
        public Confirmar_Pedido(Registros[] registros, float valor, string tipo_pagamento, string tipo_operacao)
        {
            this.valor = valor;
            this.tipo_pagamento = tipo_pagamento;
            this.tipo_operacao = tipo_operacao;
            this.registros = registros;
            InitializeComponent();
        }
    }
}
