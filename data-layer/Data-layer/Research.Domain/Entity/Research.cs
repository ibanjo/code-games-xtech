using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Research.Domain.Entity
{
    [Table("Research")]
    public class Research
    {
        [Key]
        public Guid ResearchId { get; set; }
        
        public int Code { get; set; }
        
        public string Description { get; set; }
        
        public bool Remote { get; set; }
        
        public string Company { get; set; }

        [ForeignKey("PersonId")]
        public virtual Guid PersonId { get; set; }

        [ForeignKey("LanguageId")]
        public virtual Guid LanguageId { get; set; }

        public Person Person { get; set; }
        public Language Language { get; set; }
    }
}
