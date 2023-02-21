using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UsandoGraphQL.Entities;

namespace UsandoGraphQL.Database.Configuration
{
    public class CityConfiguration : EntityBaseConfiguration<City>
    {
        public override void ConfigureEntity(EntityTypeBuilder<City> builder)
        {
            _ = builder.ToTable("cidade");

            _ = builder.Property(p => p.Name).IsRequired(false).HasColumnType<string?>("varchar").HasColumnName("nome");
            _ = builder.Property(p => p.IbgeCode).IsRequired(false).HasColumnType<int?>("int").HasColumnName("ibge");
            _ = builder.Property(p => p.Uf).IsRequired(false).HasColumnType<int?>("int").HasColumnName("uf");
        }
    } 
}
