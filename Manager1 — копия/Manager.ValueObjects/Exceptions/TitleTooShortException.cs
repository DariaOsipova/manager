using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class TitleTooShortException : ArgumentException
    {
        public string Title { get; }
        public int MinLength { get; }

        public TitleTooShortException(string title, int minLength)
            : base($"Title '{title}' is shorter than the minimum required length of {minLength}.")
        {
            Title = title;
            MinLength = minLength;
        }
    }

}
