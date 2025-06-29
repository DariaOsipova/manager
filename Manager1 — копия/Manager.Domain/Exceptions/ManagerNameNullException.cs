﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Domain.Exceptions
{
    public class ManagerNameNullException : ArgumentNullException
    {
        public ManagerNameNullException(string paramName)
            : base(paramName, "Manager name cannot be null.") { }
    }

}
