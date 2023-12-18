using UnitTestingPractice.Module2.EasyToTest.Implementations;
using UnitTestingPractice.Module2.EasyToTest.Interfaces;

namespace UnitTestingPractice.Module2.EasyToTest
{
    public class PrintInvoiceCommand
    {
        private IDatabase _database;
        private IDateTimeWrapper _dateTimeWrapper;
        private IPrinter _printer;
        public PrintInvoiceCommand(IDatabase database,
            IDateTimeWrapper dateTimeWrapper,
            IPrinter printer)
        {
            _database = database;
            _dateTimeWrapper = dateTimeWrapper;
            _printer = printer;
        }

        public void Execute(int invoiceId)
        {
            var invoice = _database.GetInvoice(invoiceId);

            _printer.WriteLine("Invoice ID: " + invoice.Id);

            _printer.WriteLine("Total: $" + invoice.Total);

            var dateTime = _dateTimeWrapper.GetNow();

            _printer.WriteLine("Printed: " + dateTime.ToShortDateString());
        }
    }
}
