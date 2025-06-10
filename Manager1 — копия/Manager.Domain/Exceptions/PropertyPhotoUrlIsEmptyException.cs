using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Domain.Exceptions
{
    public class PropertyPhotoUrlIsEmptyException : ArgumentException
    {
        public PropertyPhotoUrlIsEmptyException(string paramName)
            : base("Photo URL cannot be null or whitespace.", paramName)
        {
        }
    }

}
