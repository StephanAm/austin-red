using System;
using System.Collections.Generic;
using System.Text;

namespace DependancyInjectionExample.Models
{
    public enum Gender
    {
        male = 1,
        female
    }

    interface IPerson
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        UInt16 Age { get; set; }
    }
}
