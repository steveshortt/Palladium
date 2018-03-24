﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suplex.Security.AclModel
{
    public interface IAccessControlList : IEnumerable
    {
        bool AllowInherit { get; set; }
    }
}