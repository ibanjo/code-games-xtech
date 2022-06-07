using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Research.Domain.Entity
{
    [Table("Site")]
    public class Site
    {
        [Key]
        public Guid SiteId { get; set; }
        
        public int Code { get; set; }
        
        public string Address { get; set; }
        
        public string AdditionalInformation { get; set; }
        
        public string City { get; set; }

        [ForeignKey("CountryId")]
        public virtual Guid CountryId { get; set; }
        
        public int CAP { get; set; }

        public Country Country { get; set; }
    }
}
