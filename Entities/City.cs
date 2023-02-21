using System.ComponentModel.DataAnnotations;

namespace UsandoGraphQL.Entities
{
    public class City : EntityBase
    {
        // id
        // nome
        // uf
        // ibge
        public City() : base() { }

        [Required]
        public virtual string? Name { get; set; }

        [Required]
        public virtual int? Uf { get; set; }

        [Required]
        public virtual int? IbgeCode { get; set; }
    }
}
