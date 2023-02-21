using System.ComponentModel.DataAnnotations;

namespace UsandoGraphQL.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase()
        {
        }

        [Required]
        public virtual int? Id { get; set; }
    }
}
