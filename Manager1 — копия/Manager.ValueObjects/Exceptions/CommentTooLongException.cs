using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class CommentTooLongException : ArgumentException
    {
        public string Comment { get; }
        public int MaxLength { get; }

        public CommentTooLongException(string comment, int maxLength)
            : base($"Comment '{comment}' exceeds the maximum allowed length of {maxLength} characters.")
        {
            Comment = comment;
            MaxLength = maxLength;
        }
    }

}
