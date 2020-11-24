using Altran.Cotacao.Dominio.Entidades;
using Altran.Cotacao.Infra.Data.Mapeamentos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Altran.Cotacao.Infra.Data.Contextos
{
    public class Contexto : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public IDbContextTransaction Transacao { get; private set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        public IDbContextTransaction IniciarTransacao()
        {
            if (Transacao == null) Transacao = this.Database.BeginTransaction();
            return Transacao;
        }

        private void RollBack()
        {
            if (Transacao != null)
                Transacao.Rollback();
        }

        private void Salvar()
        {
            try
            {
                ChangeTracker.DetectChanges();
                SaveChanges();
            }
            catch (Exception ex)
            {
                RollBack();
                throw new Exception(ex.Message);
            }
        }

        private void Commit()
        {
            if (Transacao != null)
            {
                Transacao.Commit();
                Transacao.Dispose();
                Transacao = null;
            }
        }

        public void SendChanges()
        {
            Salvar();
            //Commit();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProdutoMap());
        }
    }
}
