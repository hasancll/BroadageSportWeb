﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroadageSportWeb.Entity.Entities
{
    public class BaseEntity
    {
        [Key]
        public virtual int Id { get; set; }
    }
}
