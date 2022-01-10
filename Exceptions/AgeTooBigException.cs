using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class AgeTooBigException:ApplicationException
    {
        public AgeTooBigException(string message="Varsta trebuie sa fie maxim 100."):base(message)
        {

        }
    }
}
