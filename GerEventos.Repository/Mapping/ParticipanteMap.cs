using GerEventos.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace GerEventos.Repository.Mapping
{
    public class ParticipanteMap : IEntityTypeConfiguration<Participante>
    {
        public void Configure(EntityTypeBuilder<Participante> builder)
        {
            builder.ToTable("Participante");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Email)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.CPF)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(prop => prop.Telefone)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.HasOne(prop => prop.Cidade);

        }
    }
}
