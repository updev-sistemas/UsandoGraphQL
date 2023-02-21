using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UsandoGraphQL.Entities;

namespace UsandoGraphQL.Database.Configuration
{
    public class StateConfiguration : EntityBaseConfiguration<State>
    {
        public override void ConfigureEntity(EntityTypeBuilder<State> builder)
        {
            _ = builder.ToTable("estado");

            _ = builder.Property(p => p.Name).IsRequired(false).HasColumnType<string?>("varchar").HasColumnName("nome");
            _ = builder.Property(p => p.Uf).IsRequired(false).HasColumnType<string?>("varchar").HasColumnName("uf");
            _ = builder.Property(p => p.Ddd).IsRequired(false).HasColumnType<string?>("varchar").HasColumnName("ddd");
            _ = builder.Property(p => p.IbgeCode).IsRequired(false).HasColumnType<int?>("int").HasColumnName("ibge");
            _ = builder.Property(p => p.Country).IsRequired(false).HasColumnType<int?>("int").HasColumnName("pais");
        }
    }
}
