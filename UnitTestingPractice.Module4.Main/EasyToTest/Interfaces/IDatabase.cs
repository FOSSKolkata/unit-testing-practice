using System;
using System.Collections.Generic;
using System.Linq;
using UnitTestingPractice.Module4.Main.EasyToTest.Implemetations;

namespace UnitTestingPractice.Module4.Main.EasyToTest.Interfaces
{
    public interface IDatabase
    {
        Invoice GetInvoice(int invoiceId);

        void Save();
    }
}
