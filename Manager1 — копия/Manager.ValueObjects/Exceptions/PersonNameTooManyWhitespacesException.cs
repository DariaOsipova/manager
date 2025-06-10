using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class PersonNameTooManyWhitespacesException : ArgumentException
    {
        public string Name { get; }
        public int MaxWhitespaces { get; }

        public PersonNameTooManyWhitespacesException(string name, int maxWhitespaces)
            : base($"Name '{name}' contains more than {maxWhitespaces} spaces.")
        {
            Name = name;
            MaxWhitespaces = maxWhitespaces;
        }
    }

}
