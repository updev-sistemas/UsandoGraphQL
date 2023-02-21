using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UsandoGraphQL.Entities;

namespace UsandoGraphQL.Database.Configuration
{
    public abstract class EntityBaseConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : EntityBase
    {
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            _ = builder.HasKey(p => p.Id).HasName("id");

            ConfigureEntity(builder);
        }

        public abstract void ConfigureEntity(EntityTypeBuilder<TEntity> builder);
    }
}
