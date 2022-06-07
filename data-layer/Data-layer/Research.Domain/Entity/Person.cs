using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Research.Domain.Entity
{
    [Table("Person")]
    public class Person
    {
        [Key]
        public Guid PersonId { get; set; }
        
        public int Code { get; set; }
        
        public string Name{ get; set; }
        
        public string Surnamme { get; set; }
        
        [ForeignKey("SiteId")]
        public virtual Guid? SiteId { get; set; }
        
        public int? YearsOfExperience { get; set; }
        
        public string Position { get; set; }
        
        public bool Remote { get; set; }
        
        public bool IsRecruiter { get; set; }

        public Site Site { get; set; }  
        
    }
}
