using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HouseCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("House loan payment plan has been calculated");

        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
