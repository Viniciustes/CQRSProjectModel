using CQRSProjectModel.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CQRSProjectModel.Infrastructure.Data.SQLServer.Mappings
{
    class PessoaMapping : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("Pessoa");

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            builder.Property(x => x.Nascimento)
                .HasColumnType("Date")
                .IsRequired();

            builder.Property(x => x.Telefone)
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.CPF)
                .HasColumnType("varchar(11)")
                .HasMaxLength(11)
                .IsRequired();
        }
    }
}
