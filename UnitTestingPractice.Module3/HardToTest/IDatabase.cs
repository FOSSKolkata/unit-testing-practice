using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestingPractice.Module3.HardToTest
{
    public interface IDatabase
    {
        Invoice GetInvoice(int invoiceId);
    }
}