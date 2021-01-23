using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class CoorporateCustomer:Customer //CoorporateCustomer is also Customer (Inheritance)
    {        
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
