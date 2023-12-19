using Moq;
using UnitTestingPractice.Module2.EasyToTest;
using UnitTestingPractice.Module2.EasyToTest.Interfaces;
using UnitTestingPractice.Module2.EasyToTest.Implementations;

namespace UnitTestingPractice.Module2.Tests
{

    public class PrintInvoiceCommandTests
    {
        private PrintInvoiceCommand _command;
        private Mock<IDatabase> _mockDatabase;
        private Mock<IPrinter> _mockPrinter;
        private Mock<IDateTimeWrapper> _mockDateTime;
        private Invoice _invoice;

        private const int InvoiceId = 1;
        private const decimal Total = 1.23m;
        private static readonly DateTime Date = new DateTime(2001, 2, 3);
        public PrintInvoiceCommandTests()
        {
            _invoice = new Invoice()
            {
                Id = InvoiceId,
                Total = Total
            };

            _mockDatabase = new Mock<IDatabase>();
            _mockPrinter = new Mock<IPrinter>();
            _mockDateTime = new Mock<IDateTimeWrapper>();
            _mockDatabase
                .Setup(p => p.GetInvoice(InvoiceId))
                .Returns(_invoice);

            _mockDateTime
                .Setup(p => p.GetNow())
                .Returns(Date);

            _command = new PrintInvoiceCommand(
                _mockDatabase.Object,
                _mockDateTime.Object,
                _mockPrinter.Object);


        }

        [Fact]
        public void Execute_ShouldPrintInvoiceNumber()
        {
            _command.Execute(InvoiceId);

            _mockPrinter
                 .Verify(p => p.WriteLine("Invoice ID: 1"),
                    Times.Once);

        }

        [Fact]
        public void Execute_ShouldPrintTotalPrice()
        {
            _command.Execute(InvoiceId);

            _mockPrinter
                 .Verify(p => p.WriteLine("Total: $1.23"),
                    Times.Once);
        }

        [Fact]
        public void Execute_ShouldPrintTotalAmount()
        {
            _command.Execute(InvoiceId);

            _mockPrinter
                .Verify(p => p.WriteLine($"Printed: {Date.ToShortDateString()}"),
                    Times.Once);
        }

    }
}
