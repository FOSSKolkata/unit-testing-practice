using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.Module2.EasyToTest.Interfaces;

namespace UnitTestingPractice.Module2.EasyToTest.Implementations
{
    public class Printer: IPrinter
    {
        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
