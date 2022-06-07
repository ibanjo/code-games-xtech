using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Research.Domain.Entity
{
    [Table("Language")]
    public class Language
    {
        [Key]
        public Guid LanguageId { get; set; }
        
        public int Code { get; set; }
        
        public string Description { get; set; }
    }
}
