﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExcIdentity.Models
{
    public class Role : IdentityRole
    {
        public string Description { get; set; }
    }
}