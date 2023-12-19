using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.Module3;
using UnitTestingPractice.Module3.EasyToTest.Implementations;

namespace UnitTestingPractice.Module3.Main
{
    internal class StartUp1
    {
        public static void Start(int invoiceId) {
            var command = new PrintInvoiceCommand(
                    new Database(),
                    new InvoiceWriter(
                            new Printer(),
                            new PageLayout()
                        )
                );

            command.Execute(invoiceId);
        }
    }
}
