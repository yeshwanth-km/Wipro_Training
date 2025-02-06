using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproDay5
{
    internal class AgeException : Exception
    {
        public AgeException(string errmsg) : base(errmsg)
        { }
    }
}
