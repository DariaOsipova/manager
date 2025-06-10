using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class PersonNameTooShortException : ArgumentException
    {
        public string Name { get; }
        public int MinLength { get; }

        public PersonNameTooShortException(string name, int minLength)
            : base($"Name '{name}' is shorter than the minimum required length of {minLength}.")
        {
            Name = name;
            MinLength = minLength;
        }
    }

}
