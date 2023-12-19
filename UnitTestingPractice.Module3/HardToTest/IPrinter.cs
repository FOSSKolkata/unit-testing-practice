using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestingPractice.Module3.HardToTest
{
    public interface IPrinter
    {
        void SetPageLayout(IPageLayout layout);

        void SetInkColor(string color);

        void WriteLine(string text);
    }
}
