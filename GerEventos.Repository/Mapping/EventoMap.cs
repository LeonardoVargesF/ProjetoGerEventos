using GerEventos.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GerEventos.Repository.Mapping
{
    public class EventoMap : IEntityTypeConfiguration<Evento>
    {
        public void Configure(EntityTypeBuilder<Evento> builder)
        {
            builder.ToTable("Evento");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.DataEvento)
                .IsRequired();

            builder.Property(prop => prop.Descricao)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.HasMany(prop => prop.Palestrantes);

            builder.HasMany(prop => prop.Participantes);

        }
    }

    public class EventoInscricaoMap : IEntityTypeConfiguration<EventoInscricao>
    {
        public void Configure(EntityTypeBuilder<EventoInscricao> builder)
        {
            builder.ToTable("EventoInscricao");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.DataInscricao)
                .IsRequired();

            builder.HasOne(prop => prop.Evento);

            builder.HasOne(prop => prop.Participante);


        }
    }
}
