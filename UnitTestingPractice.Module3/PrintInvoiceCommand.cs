using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.Module3.EasyToTest.Interfaces;

namespace UnitTestingPractice.Module3
{
    public class PrintInvoiceCommand
    {
        private readonly IDatabase _database;
        private readonly IInvoiceWriter _writer;

        public PrintInvoiceCommand(
            IDatabase database,
            IInvoiceWriter writer)
        {
            _database = database;
            _writer = writer;
        }

        public void Execute(int invoiceId)
        {
            var invoice = _database.GetInvoice(invoiceId);

            _writer.Write(invoice);
        }
    }
}
