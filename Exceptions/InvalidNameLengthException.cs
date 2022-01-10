using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class InvalidNameLengthException:ApplicationException
    {
        public InvalidNameLengthException(string message="Numele trebuie sa aiba cel putin 2 caractere."):base(message)
        {

        }
    }
}
