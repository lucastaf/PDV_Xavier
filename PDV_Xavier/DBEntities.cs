
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PDV_Xavier
{
    internal class AppDbContext : DbContext
    {
        private string connectionPath;

        public AppDbContext(string connectionPath)
        {
            this.connectionPath = connectionPath;
        }
        public DbSet<Contatos> contatos { get; set; }
        public DbSet<Produtos> produtos { get; set; }
        public DbSet<Registros> registros { get; set; }

        public DbSet<Operacoes> operacoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($@"Data Source={connectionPath}");
        }

        private Dictionary<int,int> agruparRegistros(Registros[] registros)
        {
            Dictionary<int, int> agrupados = new Dictionary<int, int>();
            foreach (var registro in registros)
            {
                if (agrupados.ContainsKey(registro.id_produto))
                {
                    agrupados[registro.id_produto] += registro.quantidade;
                }
                else
                {
                    agrupados[registro.id_produto] = registro.quantidade;
                }
            }
            return agrupados;
        }

        public string checkEstoque(Registros[] registros)
        {
            string estoque = "";
            var agrupados = agruparRegistros(registros);
            foreach (var registro in agrupados)
            {
                var produto = produtos.Find(registro.Key);
                if (produto != null)
                {
                    if (produto.em_estoque < Math.Abs(registro.Value))
                    {
                        estoque += $"Produto {produto.nome} ({produto.codigo}) não tem estoque suficiente no registro.\n";
                    }
                }
                else
                {
                    estoque += $"Produto com ID {registro.Key} não encontrado.\n";
                }
            }
            return estoque;
        }

        public void atualizarEstoque(Registros[] registros)
        {
            var agrupados = agruparRegistros(registros);
            foreach (var registro in agrupados)
            {
                var produto = produtos.Find(registro.Key);
                if (produto != null)
                {
                    produto.em_estoque += registro.Value;
                    produtos.Update(produto);
                }
            }
            SaveChanges();
        }

    }

    public class Contatos
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }

        public int? is_fornecedor { get; set; } // 0 - cliente, 1 - fornecedor
    }

    public class Produtos
    {
        [Key]
        public int id { get; set; }
        public string codigo { get; set; }
        public string nome { get; set; }
        public string marca { get; set; }
        public string tipo_produto { get; set; }
        public decimal preco { get; set; }
        public int em_estoque { get; set; } // quantidade em estoque
    }

    public class Registros
    {
        [Key]
        public int id { get; set; }
        public int id_produto { get; set; }
        public int id_operacao { get; set; } // Referência à tabela Operacoes
        public int quantidade { get; set; } // quantidade de produtos vendidos ou comprados
        public float valor { get; set; } // valor total da operação
    }

    public class Operacoes
    {
        [Key]
        public int id { get; set; }
        public int id_contato { get; set; }
        public float valor { get; set; }
        public string tipo_pagamento { get; set; }
        public string tipo_operacao { get; set; } // venda, compra, etc.
        public string criado_em { get; set; } // data de criação
    }
}