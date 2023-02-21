using System.ComponentModel.DataAnnotations;

namespace UsandoGraphQL.Entities
{
    public class Country : EntityBase
    {
        // id
        // nome
        // nome_pt
        // sigla
        // bacen
        public Country() : base() { }

        [Required]
        public virtual string? Name { get; set; }

        [Required]
        public virtual string? IntlName { get; set; }

        [Required]
        public virtual string? Code { get; set; }

        [Required]
        public virtual int? Bacen { get; set; }
    }
}
