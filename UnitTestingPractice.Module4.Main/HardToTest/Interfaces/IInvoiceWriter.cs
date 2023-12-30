using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.Module4.Main.HardToTest.Implementations;

namespace UnitTestingPractice.Module4.Main.HardToTest.Interfaces
{
    public interface IInvoiceWriter
    {
        void Write(Invoice invoice);
    }
}
