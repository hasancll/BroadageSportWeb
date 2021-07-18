﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroadageSportWeb.Entity.Entities
{
    public class HomeTeam:BaseEntity
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string MediumName { get; set; }
        [ForeignKey("Match")]
        public int MatchId { get; set; }
        public virtual Match Match { get; set; }
        [ForeignKey("Score")]
        public int ScoreId { get; set; }
        [NotMapped]
        public virtual Score Score { get; set; }
    }
}
