using Ninject;
using Ninject.Extensions.Conventions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.Module3.EasyToTest.Implementations;
using UnitTestingPractice.Module3.EasyToTest.Interfaces;

namespace UnitTestingPractice.Module3.Main
{
    public class StartUp4
    {
        public static void Start(int invoiceId)
        {
            var container = new StandardKernel();

            container.Bind(p => {
                p.FromThisAssembly()
                .SelectAllClasses()
                .BindDefaultInterface();
            });

            var command = container.Get<PrintInvoiceCommand>();

            command.Execute(invoiceId);
        }
    }
}
