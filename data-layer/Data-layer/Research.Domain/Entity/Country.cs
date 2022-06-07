using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Research.Domain.Entity
{
    [Table("Country")]
    public class Country
    {
        [Key]
        public Guid CountryId { get; set; }
        
        public int Code { get; set; }
        
        public string Description { get; set; }
}
}