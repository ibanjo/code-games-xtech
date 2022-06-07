using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Research.Domain.Entity
{
    [Table("SkillLevel")]
    public class SkillLevel
    {
        [Key]
        public Guid SkillLevelId { get; set; }
        
        public string Value { get; set; }
        
        public string Description { get; set; }
    }
}
