using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.Module4.Main.HardToTest.Interfaces;

namespace UnitTestingPractice.Module4.Main.HardToTest.Implementations
{
    public class InvoiceWriter : IInvoiceWriter
    {
        private readonly IPrinter _printer;
        private readonly IPageLayout _layout;

        public InvoiceWriter(
            IPrinter printer,
            IPageLayout layout)
        {
            _printer = printer;
            _layout = layout;
        }

        public void Write(Invoice invoice)
        {
            _printer.SetPageLayout(_layout);

           

            // Remaining print statements would go here
        }
    }
}
