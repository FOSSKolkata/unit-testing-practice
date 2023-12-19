using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.Module3.Eiwen;
using UnitTestingPractice.Module3.Tests.HardToTest;

namespace UnitTestingPractice.Module3.HardToTest
{
    public class InvoiceWriter
    {
        private readonly IPrinter _printer;
        private readonly Invoice _invoice;

        public InvoiceWriter(
            IPrinter printer,
            Invoice invoice) // Smell : Injecting a newable
        {
            _printer = printer;
            _invoice = invoice;

            _printer.SetPageLayout(new PageLayout()); // Smell : newing up 

            if (_invoice.IsOverdue) // Smell : Conditional logic
                _printer.SetInkColor("Red");
        }

        public void Write()
        {
            _printer.WriteLine("Invoice ID: " + _invoice.Id);

            // Remaining print statements would go here
        }
    }
}
