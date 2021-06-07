using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DatabaseFirst.Models
{
    public partial class AndmedAtsContext : DbContext
    {
        public AndmedAtsContext()
        {
        }

        public AndmedAtsContext(DbContextOptions<AndmedAtsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Andmed> Andmeds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AndmedAts;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Andmed>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Andmed");

                entity.Property(e => e.Aadress).HasMaxLength(30);

                entity.Property(e => e.Linn).HasMaxLength(25);

                entity.Property(e => e.Nimi).HasMaxLength(25);

                entity.Property(e => e.Palk).HasMaxLength(50);

                entity.Property(e => e.SNniaeg).HasColumnName("S_nniaeg");

                entity.Property(e => e.Sugu)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Surnud).HasMaxLength(50);

                entity.Property(e => e.Telefon).HasMaxLength(12);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
