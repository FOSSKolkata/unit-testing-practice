

using UnitTestingPractice.Module4.Main.HardToTest.Interfaces;

namespace UnitTestingPractice.Module4.Main.HardToTest.Implementations
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
