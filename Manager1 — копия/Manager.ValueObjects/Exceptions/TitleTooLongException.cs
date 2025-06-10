using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class TitleTooLongException : ArgumentException
    {
        public string Title { get; }
        public int MaxLength { get; }

        public TitleTooLongException(string title, int maxLength)
            : base($"Title '{title}' exceeds the maximum allowed length of {maxLength}.")
        {
            Title = title;
            MaxLength = maxLength;
        }
    }

}
