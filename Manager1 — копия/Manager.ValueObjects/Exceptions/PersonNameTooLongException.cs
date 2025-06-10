using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class PersonNameTooLongException : ArgumentException
    {
        public string Name { get; }
        public int MaxLength { get; }

        public PersonNameTooLongException(string name, int maxLength)
            : base($"Name '{name}' exceeds the maximum allowed length of {maxLength}.")
        {
            Name = name;
            MaxLength = maxLength;
        }
    }

}
