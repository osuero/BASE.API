using Data.IGenericEntities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.CommonEntities
{
    public class GenericEntity : IGenericEntity
    {
        [Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
    }
}
