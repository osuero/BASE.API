using System;
using System.ComponentModel.DataAnnotations;

namespace Data.IGenericEntities
{
    public interface IGenericEntity
    {
        [Key]
        Guid Id { get; set; }
    }
}
