using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UsandoGraphQL.Entities;

namespace UsandoGraphQL.Database.Configuration
{
    public class CountryConfiguration : EntityBaseConfiguration<Country>
    {
        public override void ConfigureEntity(EntityTypeBuilder<Country> builder)
        {
            _ = builder.ToTable("pais");

            _ = builder.Property(p => p.Name).IsRequired(false).HasColumnType<string?>("varchar").HasColumnName("nome");
            _ = builder.Property(p => p.IntlName).IsRequired(false).HasColumnType<string?>("varchar").HasColumnName("nome_pt");
            _ = builder.Property(p => p.Code).IsRequired(false).HasColumnType<string?>("varchar").HasColumnName("sigla");
            _ = builder.Property(p => p.Bacen).IsRequired(false).HasColumnType<int?>("int").HasColumnName("bacen");
        }
    }
}
