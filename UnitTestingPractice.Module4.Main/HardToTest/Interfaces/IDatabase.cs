using System;
using System.Collections.Generic;
using System.Linq;
using UnitTestingPractice.Module4.Main.HardToTest.Implementations;

namespace UnitTestingPractice.Module4.Main.HardToTest.Interfaces
{
    public interface IDatabase
    {
        Invoice GetInvoice(int invoiceId);

        void Save();
    }
}
