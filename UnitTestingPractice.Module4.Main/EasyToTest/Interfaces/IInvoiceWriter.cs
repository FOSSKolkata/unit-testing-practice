using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.Module4.Main.EasyToTest.Implemetations;

namespace UnitTestingPractice.Module4.Main.EasyToTest.Interfaces
{
    public interface IInvoiceWriter
    {
        void Write(Invoice invoice);
    }
}
