﻿using SpeedDating.Web.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeedDating.Web.Domain
{
    public class UserRole : BaseEntity
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
    }
}
