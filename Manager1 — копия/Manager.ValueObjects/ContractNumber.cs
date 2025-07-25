﻿using Manager.ValueObjects.Base;
using Manager.ValueObjects.Validators;

namespace Manager.ValueObjects
{
    public class ContractNumber(string number)
        : ValueObject<string>(new ContractNumberValidator(), number)
    {
    }
}
