using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Research.Domain.Entity
{
    [Table("Match")]
    public class Match
    {
        [Key]
        public Guid MatchId { get; set; }
        
        [ForeignKey("PersonId")]
        public virtual Guid? EmployeeId { get; set; }

        [ForeignKey("ResearchId")]
        public virtual Guid? ResearchId { get; set; }
        
        public bool? MatchAcceptedByEmployee { get; set; }

        public Person? Person { get; set; }
        public Research? Research { get; set; }
    }
}
