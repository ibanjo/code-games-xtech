using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Research.Domain.Entity
{
    [Table("SkillLink")]
    public class SkillLink 
    {
        [Key]
        public Guid SkillLinkId { get; set; }

        [ForeignKey("SkillId")]
        public virtual Guid SkillId { get; set; }

        [ForeignKey("PersonId")]
        public virtual Guid PersonId { get; set; }

        public int Level { get; set; }

        public Skill? Skill { get; set; }
        public Person? Person { get; set; }
    }
}
