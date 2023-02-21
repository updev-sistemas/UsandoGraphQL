using System.ComponentModel.DataAnnotations;

namespace UsandoGraphQL.Entities
{
    public class State : EntityBase
    {
        //id
        //nome
        //uf
        //ibge
        //pais
        //ddd
        public State() : base() { }

        [Required]
        public virtual string? Name { get; set; }

        [Required]
        public virtual string? Uf { get; set; }

        [Required]
        public virtual int? IbgeCode { get; set; }

        [Required]
        public virtual int? Country { get; set; }

        [Required]
        public virtual string? Ddd { get; set; }
    }
}
