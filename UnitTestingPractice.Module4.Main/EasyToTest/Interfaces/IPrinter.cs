using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestingPractice.Module4.Main.EasyToTest.Interfaces
{
    public interface IPrinter
    {
        void SetPageLayout(IPageLayout layout);

        void SetInkColor(string color);

        void WriteLine(string text);
    }
}
