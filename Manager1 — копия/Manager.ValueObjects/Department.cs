using Manager.ValueObjects.Base;
using Manager.ValueObjects.Validators;

namespace Manager.ValueObjects
{
    public class Department(string name)
        : ValueObject<string>(new DepartmentValidator(), name)
    {
    }
}

