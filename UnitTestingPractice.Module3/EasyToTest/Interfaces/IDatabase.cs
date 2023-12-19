using System;
using System.Collections.Generic;
using System.Linq;
using UnitTestingPractice.Module3.EasyToTest.Implementations;

namespace UnitTestingPractice.Module3.EasyToTest.Interfaces
{
    public interface IDatabase
    {
        Invoice GetInvoice(int invoiceId);
    }
}