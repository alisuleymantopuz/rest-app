using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestApplication.Domain.UserAggregate
{
    public enum RoleLevel
    {
        Anonymous = 0,
        Administrator = 1,
        Editor = 2,
        User = 3
    }
}
