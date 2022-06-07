using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Research.Domain.Entity
{
    [Table("LanguageLink")]
    public class LanguageLink
    {
        [Key]
        public Guid LanguageLinkId { get; set; }
        
        [ForeignKey("LanguageId")]
        public virtual Guid LanguageId { get; set; }
        
        [ForeignKey("PersonId")]
        public virtual Guid PersonId { get; set; }
        
        [ForeignKey("LanguageLevelId")]
        public virtual Guid? LanguageLevelId { get; set; }
        
        public bool? Preferred { get; set; }

        public Language Language { get; set; }
        public Person Person { get; set; }
        public LanguageLevel LanguageLevel { get; set; }
    }
}
