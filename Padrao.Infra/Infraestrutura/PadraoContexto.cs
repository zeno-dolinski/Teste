using System.Data.Entity;
using Padrao.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Padrao.Infra.Infraestrutura
{
    public class PadraoContexto : DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<PessoaContato> PessoaContato { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<PessoaContato>().ToTable("PessoaContato");

            base.OnModelCreating(modelBuilder);
        }
    }
}
