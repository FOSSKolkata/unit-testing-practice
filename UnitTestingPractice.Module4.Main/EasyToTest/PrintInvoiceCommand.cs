using System;
using System.Collections.Generic;
using System.Linq;
using UnitTestingPractice.Module4.Main.EasyToTest.Interfaces;

namespace UnitTestingPractice.Module4.Main.EasyToTest
{
    public class PrintInvoiceCommand
    {
        private readonly IDatabase _database;
        private readonly IInvoiceWriter _writer;
        private readonly IIdentityService _identity;

        public PrintInvoiceCommand(
            IDatabase database,
            IInvoiceWriter writer,
            IIdentityService identity)
        {
            _database = database;
            _writer = writer;
            _identity = identity;
        }

        public void Execute(int invoiceId)
        {
            var invoice = _database.GetInvoice(invoiceId);

            _writer.Write(invoice);

            invoice.LastPrintedBy = _identity.GetUserName();

            _database.Save();
        }
    }
}
