using System;
using System.Collections.Generic;
using System.Linq;
using UnitTestingPractice.Module4.Main.EasyToTest.Interfaces;

namespace UnitTestingPractice.Module4.Main.EasyToTest.Implemetations
{
    public class Printer : IPrinter
    {
        public void SetInkColor(string red)
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
