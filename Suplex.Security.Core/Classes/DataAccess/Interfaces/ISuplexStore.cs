﻿using System;
using System.Collections.Generic;

using Suplex.Security.Principal;

namespace Suplex.Security.AclModel.DataAccess
{
    public interface ISuplexStore
    {
        IList<SecureObject> SecureObjects { get; set; }

        IList<User> Users { get; set; }
        IList<Group> Groups { get; set; }
        IList<GroupMembershipItem> GroupMembership { get; set; }
    }
}