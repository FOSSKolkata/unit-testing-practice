using System;
using System.Collections.Generic;
using System.Linq;
using UnitTestingPractice.Module2.EasyToTest.Implementations;

namespace UnitTestingPractice.Module2.EasyToTest.Interfaces
{
    public interface IDatabase
    {
        Invoice GetInvoice(int invoiceId);
    }
}