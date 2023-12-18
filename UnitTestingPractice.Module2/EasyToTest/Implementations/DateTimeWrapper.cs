using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.Module2.EasyToTest.Interfaces;

namespace UnitTestingPractice.Module2.EasyToTest.Implementations
{
    public class DateTimeWrapper : IDateTimeWrapper
    {
        public DateTime GetNow()
        {
            return DateTime.Now;
        }

    }
}
