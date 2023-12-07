using GerEventos.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GerEventos.Repository.Mapping
{
    public class EventoPalestranteMap : IEntityTypeConfiguration<EventoPalestrante>
    {
        public void Configure(EntityTypeBuilder<EventoPalestrante> builder)
        {
            builder.ToTable("EventoPalestrante");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.TituloPalestra)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.TempoDuracao)
                .IsRequired();

            builder.HasOne(prop => prop.Evento);

            builder.HasOne(prop => prop.Palestrante);
        }
    }
}
