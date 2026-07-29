using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Common
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TableNameAttribute(string name) : Attribute
    {
        public string Name { get; } = name;
    }
}
