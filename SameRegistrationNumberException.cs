using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_ApplicationException
{
    internal class SameRegistrationNumberException : ApplicationException
    {
        public SameRegistrationNumberException(string? message) :base(message) {
            
        }
    }
}
