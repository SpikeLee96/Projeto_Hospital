using Microsoft.EntityFrameworkCore;
using Projeto_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CRUD
{
    public class ApplicationContext : DbContext
    {
        public virtual DbSet<Paciente> Paciente { get; set; }
        public virtual DbSet<Exame> Exame { get; set; }
        public virtual DbSet<TipoExame> TipoExame { get; set; }
        public virtual DbSet<Consulta> Consulta { get; set; }

        public ApplicationContext()
        {
        }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Paciente>().HasKey(t => t.id);
            modelBuilder.Entity<Paciente>().Property(t => t.nome);
            modelBuilder.Entity<Paciente>().Property(t => t.CPF);
            modelBuilder.Entity<Paciente>().Property(t => t.data);
            modelBuilder.Entity<Paciente>().Property(t => t.sexo);
            modelBuilder.Entity<Paciente>().Property(t => t.telefone);
            modelBuilder.Entity<Paciente>().Property(t => t.email);

            modelBuilder.Entity<TipoExame>().HasKey(t => t.id);
            modelBuilder.Entity<TipoExame>().Property(t => t.tipo);
            modelBuilder.Entity<TipoExame>().Property(t => t.descricao).IsUnicode(true);

            modelBuilder.Entity<Exame>().HasKey(t => t.id);
            modelBuilder.Entity<Exame>().Property(t => t.nomeExame);
            modelBuilder.Entity<Exame>().Property(t => t.observacoes).IsUnicode(true);
            modelBuilder.Entity<Exame>().HasOne(t => t.TipoExame).WithMany(t => t.Exame).HasForeignKey(t => t.TipoExameId);

            modelBuilder.Entity<Consulta>().HasKey(t => t.id);
            modelBuilder.Entity<Consulta>().Property(t => t.data);
            modelBuilder.Entity<Consulta>().HasOne(t => t.Paciente).WithMany(t => t.Consulta).HasForeignKey(t => t.PacienteId);
            modelBuilder.Entity<Consulta>().HasOne(t => t.Exame).WithMany(t => t.Consulta).HasForeignKey(t => t.ExameId);

        }
    }
}
