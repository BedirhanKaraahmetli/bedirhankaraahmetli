using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class IndividualCustomer: Customer //IndividualCustomer is also Customer (Inheritance)
    {                
        public string IdNumber { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
    }
}
