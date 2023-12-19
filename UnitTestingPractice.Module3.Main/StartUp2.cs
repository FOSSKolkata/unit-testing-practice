using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.Module3;
using UnitTestingPractice.Module3.EasyToTest.Implementations;

namespace UnitTestingPractice.Module3.Main
{
    public class StartUp2
    {
        public static void Start(int invoiceId)
        {
            PrintInvoiceCommandFactory factory = new PrintInvoiceCommandFactory();
            var command = factory.Create();

            command.Execute(invoiceId);
        }
    }
}
