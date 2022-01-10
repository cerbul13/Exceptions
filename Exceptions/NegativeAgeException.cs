using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class NegativeAgeException: ArgumentException
    {
        public NegativeAgeException(string message="Varsta nu trebuie sa fie negativa."):base(message)
        {

        }
    }
}
