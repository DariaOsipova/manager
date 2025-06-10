using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class PersonNameInvalidCharactersException : ArgumentException
    {
        public string Name { get; }

        public PersonNameInvalidCharactersException(string name)
            : base($"Name '{name}' contains invalid characters. Only letters and spaces are allowed.")
        {
            Name = name;
        }
    }

}
