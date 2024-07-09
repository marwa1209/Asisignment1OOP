using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asisignment1OOP
{
    [Flags]
    public enum Permissions
    {
        None,
        Read,
        Write,
        Delete,
        Execute
    }

}
