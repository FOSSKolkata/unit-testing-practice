using Moq;
using UnitTestingPractice.Module2.EasyToTest;
using UnitTestingPractice.Module2.EasyToTest.Interfaces;
using UnitTestingPractice.Module2.EasyToTest.Implementations;
using AutoMoq;

namespace UnitTestingPractice.Module2.Tests
{

    public class PrintInvoiceCommandAutoMoqTests : IClassFixture<PrintInvoiceCommandAutoMoqTests>
    {
        private PrintInvoiceCommand _command;
        private AutoMoqer _mocker;

        private Invoice _invoice;

        private const int InvoiceId = 1;
        private const decimal Total = 1.23m;
        private static readonly DateTime Date = new DateTime(2001, 2, 3);
        public PrintInvoiceCommandAutoMoqTests()
        {
            _invoice = new Invoice()
            {
                Id = InvoiceId,
                Total = Total
            };

            _mocker = new AutoMoqer();

            _mocker.GetMock<IDatabase>()
                .Setup(p => p.GetInvoice(InvoiceId))
                .Returns(_invoice);

            _mocker.GetMock<IDateTimeWrapper>()
                .Setup(p => p.GetNow())
                .Returns(Date);

            _command = _mocker.Create<PrintInvoiceCommand>();
        }


        [Theory]
        [InlineData("Invoice ID: 1")]
        [InlineData("Total: $1.23")]
        [InlineData("Printed: 03/02/2001")]
        public void Execute_ShouldPrintLine(string line)
        {
            _command.Execute(InvoiceId);

            _mocker.GetMock<IPrinter>()
                 .Verify(p => p.WriteLine(line),
                    Times.Once);

        }
    }
}
