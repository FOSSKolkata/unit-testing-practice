using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestingPractice.Module3.HardToTest
{
    public class Printer : IPrinter
    {
        public void SetInkColor(string color)
        {
            throw new NotImplementedException();
        }

        public void SetPageLayout(IPageLayout logic)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(string text)
        {
            throw new NotImplementedException();
        }
    }
}
