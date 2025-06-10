using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class CommentNullException : ArgumentNullException
    {
        public CommentNullException(string paramName)
            : base(paramName, "Comment cannot be null or whitespace.") { }
    }

}
