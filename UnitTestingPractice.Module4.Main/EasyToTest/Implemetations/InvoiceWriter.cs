using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.Module4.Main.EasyToTest.Interfaces;

namespace UnitTestingPractice.Module4.Main.EasyToTest.Implemetations
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
