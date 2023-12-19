using UnitTestingPractice.Module3;
using UnitTestingPractice.Module3.EasyToTest.Implementations;

namespace UnitTestingPractice.Module3.Main
{
    internal class PrintInvoiceCommandFactory
    {
        public PrintInvoiceCommand Create() {
            
            var command = new PrintInvoiceCommand(
                    new Database(),
                    new InvoiceWriter(
                            new Printer(),
                            new PageLayout()
                        )
                );

            return command;
        }
    }
}
