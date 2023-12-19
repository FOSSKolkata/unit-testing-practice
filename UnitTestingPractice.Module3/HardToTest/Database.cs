using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestingPractice.Module3.HardToTest
{
    public class Database : IDatabase
    {
        public Invoice GetInvoice(int invoiceId)
        {
            throw new NotImplementedException();
        }
    }
}