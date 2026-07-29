using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Exceptions
{
    public class NotFoundException(string entityName, object key) : DomainException($"{entityName} with key '{key}' was not found.")
    {
    }
}
