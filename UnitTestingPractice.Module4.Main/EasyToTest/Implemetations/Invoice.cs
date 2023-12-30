using System;
using System.Collections.Generic;
using System.Linq;
using UnitTestingPractice.Module4.Main.HardToTest.Implementations;

namespace UnitTestingPractice.Module4.Main.EasyToTest.Implemetations
{
    public class Invoice
    {
        // Remaining invoice fields would go here

        public InvoiceStatus Status { get; set; }

        public string LastPrintedBy { get; set; }
    }
}
