using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Exceptions
{
    public class DomainException(string message) : Exception(message)
    {
    }
}
