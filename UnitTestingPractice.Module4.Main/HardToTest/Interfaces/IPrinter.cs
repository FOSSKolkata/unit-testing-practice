using System;
using System.Collections.Generic;
using System.Linq;
using UnitTestingPractice.Module4.Main.EasyToTest.Interfaces;

namespace UnitTestingPractice.Module4.Main.HardToTest.Interfaces
{
    public interface IPrinter
    {
        void SetPageLayout(IPageLayout layout);

        void SetInkColor(string color);

        void WriteLine(string text);
    }
}
