using AutoMoq;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using UnitTestingPractice.Module3.EasyToTest.Implementations;
using UnitTestingPractice.Module3.EasyToTest.Interfaces;
using Xunit;

namespace UnitTestingPractice.Module3.Tests
{

    public class InvoiceWriterTests
    {
        private InvoiceWriter _writer;
        private AutoMoqer _mocker;
        private Invoice _invoice;

        public InvoiceWriterTests()
        {
            _invoice = new Invoice()
            {
                Id = 1,
                IsOverdue = false
            };
            
            _mocker = new AutoMoqer();
            _writer = _mocker.Create<InvoiceWriter>();
        }

        
        [Fact]
        public void Write_ShouldSetPageLayout()
        {

            _writer.Write(_invoice);

            var pageLayout = _mocker.GetMock<IPageLayout>().Object;

            _mocker.GetMock<IPrinter>()
                .Verify(p => p.SetPageLayout(pageLayout), Times.Once());
        }

        [Fact]
        public void OverdueInvoice_ShouldBePrintedInRed()
        {
            _invoice.IsOverdue = true;

            _writer.Write(_invoice);

            _mocker.GetMock<IPrinter>()
                .Verify(p => p.SetInkColor("Red"), Times.Once());
        }

        [Fact]
        public void Write_ShouldPrintOnTimeInvoiceInDefaultColor()
        {
            _writer.Write(_invoice);

            _mocker.GetMock<IPrinter>()
                .Verify(p => p.SetInkColor(It.IsAny<string>()), Times.Never());
        }

        [Theory]
        [InlineData("Invoice ID: 1")]
      //  [InlineData("Total: $1.23")]
      //  [InlineData("Printed: 03/02/2001")]
        public void Execute_ShouldPrintLine(string line)
        {
            _writer.Write(_invoice);

            _mocker.GetMock<IPrinter>()
                 .Verify(p => p.WriteLine(line),
                    Times.Once);

        }
    }
}
