using System.ComponentModel.DataAnnotations;

namespace ActimizeETL.Core.Entities
{
    public abstract class BaseEntity<T>
    {
        [Key]
        public T Id { get; set; }
        public DateTimeOffset? DateCreated { get; set; }
    }
}
