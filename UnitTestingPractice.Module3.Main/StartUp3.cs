using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.Module3.EasyToTest.Implementations;
using UnitTestingPractice.Module3.EasyToTest.Interfaces;

namespace UnitTestingPractice.Module3.Main
{
    public class StartUp3
    {
        public static void Start(int invoiceId)
        {
            var container = new StandardKernel();

            container.Bind<IDatabase>()
                .To<Database>();

            container.Bind<IPrinter>()
                .To<Printer>();

            container.Bind<IPageLayout>()
                .To<PageLayout>();

            container.Bind<IInvoiceWriter>()
                .To<InvoiceWriter>();

            var command = container.Get<PrintInvoiceCommand>();

            command.Execute(invoiceId);
        }
    }
}
