﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Research.Domain.Entity
{
    [Table("Skill")]
    public class Skill
    {
        [Key]
        public Guid SkillId { get; set; }

        public int Code { get; set; }

        public string FEBEDevops { get; set; }
        
        public string WebMobile { get; set; }
        
        public string Technology { get; set; }
        
        public string ProjectRef { get; set; }
        
        public string Description { get; set; }
    }
}
