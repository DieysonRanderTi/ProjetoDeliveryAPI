using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurator
{
    public class ClienteConfigurator : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            //builder.ToTable("Cliente");

            //builder.HasKey(prop => prop.Id);

            //builder.Property(prop => prop.Nome)
            //    .HasConversion(prop => prop.ToString(), prop => prop)
            //    .IsRequired()
            //    .HasColumnType("varchar(100)");

            //builder.Property(prop => prop.Email)
            //   .HasConversion(prop => prop.ToString(), prop => prop)
            //   .IsRequired()
            //   .HasColumnType("varchar(100)");

            //builder.Property(prop => prop.DataCadastro)
            //    .HasConversion(prop => prop.DateTime(), prop => prop)
            //    .IsRequired()
            //    .HasColumnName("Password")
            //    .HasColumnType("varchar(100)");
        }
    }
}
