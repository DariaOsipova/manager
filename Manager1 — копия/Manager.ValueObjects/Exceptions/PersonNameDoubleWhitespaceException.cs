using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class PersonNameDoubleWhitespaceException : ArgumentException
    {
        public string Name { get; }

        public PersonNameDoubleWhitespaceException(string name)
            : base($"Name '{name}' contains double whitespace.")
        {
            Name = name;
        }
    }

}
