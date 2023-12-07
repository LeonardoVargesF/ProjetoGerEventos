using GerEventos.Domain.Entities;
using GerEventos.Repository.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GerEventos.Repository.Context
{
    public sealed class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated();
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Palestrante>? Palestrante { get; set; }
        public DbSet<Cidade>? Cidade { get; set; }
        public DbSet<Participante>? Participante { get; set; }
        public DbSet<Evento>? Evento { get; set; }
        public DbSet<EventoPalestrante>? EventoPalestrante { get; set; }
        public DbSet<EventoInscricao>? EventoInscricao { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Palestrante>(new PalestranteMap().Configure);
            modelBuilder.Entity<Cidade>(new CidadeMap().Configure);
            modelBuilder.Entity<Participante>(new ParticipanteMap().Configure);
            modelBuilder.Entity<Evento>(new EventoMap().Configure);
            modelBuilder.Entity<EventoPalestrante>(new EventoPalestranteMap().Configure);
            modelBuilder.Entity<EventoInscricao>(new EventoInscricaoMap().Configure);
        }
    }
}
