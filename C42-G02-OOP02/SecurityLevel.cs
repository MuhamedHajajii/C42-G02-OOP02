using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP02
{
    [Flags]
    internal enum SecurityLevel : byte
    {
        Guest = 1 ,Developer = 2 ,Secretary = 4 ,DBA = 8
    }
}
