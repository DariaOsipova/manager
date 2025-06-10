using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class AreaInvalidCharactersException : ArgumentException
    {
        public string Area { get; }

        public AreaInvalidCharactersException(string area)
            : base($"Area '{area}' contains invalid characters. Only letters and spaces are allowed.")
        {
            Area = area;
        }
    }

}
