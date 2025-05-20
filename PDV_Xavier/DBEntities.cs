
using Microsoft.EntityFrameworkCore;
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

    }

    public class Contatos
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
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
    }

    public class Registros
    {
        [Key]
        public int id { get; set; }
        public int id_produto { get; set; }
        public int id_operacao { get; set; }
        public int quantidade { get; set; }
        public decimal valor { get; set; }
        public string date { get; set; }
    }

    public class Operacoes
    {
        [Key]
        public int id { get; set; }

        public int id_contato { get; set; }

        public int valor { get; set; }

        public string tipo_pagamento { get; set; }
        public string tipo_operacao { get; set; }

        public string criado_em { get; set; }
    }
}