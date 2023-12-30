using AutoMoq;
using Moq;
using UnitTestingPractice.Module4.Main.EasyToTest;
using UnitTestingPractice.Module4.Main.EasyToTest.Implemetations;
using UnitTestingPractice.Module4.Main.EasyToTest.Interfaces;
using Xunit;

namespace UnitTestingPractice.Module4.Tests
{
    public class PrintInvoiceCommandTests
    {
        private PrintInvoiceCommand _command;
        private Invoice _invoice;
        private AutoMoqer _mocker;

        private const int InvoiceId = 1;
        private const string UserName = "Dipendu";

        public PrintInvoiceCommandTests()
        {
             _invoice = new Invoice();

            _mocker = new AutoMoqer();

            _mocker.GetMock<IDatabase>()
                .Setup(p => p.GetInvoice(InvoiceId))
                .Returns(_invoice);

            _mocker.GetMock<IIdentityService>()
                .Setup(p => p.GetUserName())
                .Returns(UserName);

            _command = _mocker.Create<PrintInvoiceCommand>();
        }

        [Fact]
        public void Execute_ShouldPrintInvoice()
        {
            _command.Execute(InvoiceId);

            _mocker.GetMock<IInvoiceWriter>()
                .Verify(p => p.Write(_invoice),
                    Times.Once);

        }

        [Fact]
        public void Execute_ShouldSetLastPrintedByToCurrentUserName()
        {
            _command.Execute(InvoiceId);

            Assert.Equal(UserName, _invoice.LastPrintedBy);
        }

        [Fact]
        public void Execute_ShouldSaveChangesToDatabase()
        {
            _command.Execute(InvoiceId);

            _mocker.GetMock<IDatabase>()
                .Verify(p => p.Save(),
                    Times.Once);
        }
    }
}
