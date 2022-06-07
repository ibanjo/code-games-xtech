using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Research.Domain.Entity
{
    [Table("LanguageLevel")]
    public class LanguageLevel
    {
        [Key]
        public Guid LanguageLevelId { get; set; }
        
        public int Code { get; set; }
        
        public string Description { get; set; }
    }
}
