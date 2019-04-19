using Dominio.Entidades;
using System.Data.Entity;

namespace Infraestrutura.Contexto
{
    public class EmpresaContext : DbContext
    {
        public EmpresaContext() : base("name=EmpresaContext")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Veiculo> Veiculos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("TBCliente");
            modelBuilder.Entity<Veiculo>().ToTable("TBVeiculo");

            modelBuilder.Entity<Cliente>().Ignore(e => e.Email);

        }
    }
}
