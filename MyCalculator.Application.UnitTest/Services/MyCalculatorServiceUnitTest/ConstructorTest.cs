using MyCalculator.Application.Services;
using TestSupport;
using Xunit;

namespace MyCalculator.Application.UnitTest.Services.MyCalculatorServiceUnitTest
{
    public static class ConstructorTest
    {
        public class Give_Valid_Dependencies_When_Constructing_Instance
            : Given_When_Then_Test
        {
            private MyCalculatorService _sut;

            protected override void Given()
            {

            }

            protected override void When()
            {
                _sut = new MyCalculatorService();
            }

            [Fact]
            public void Then_It_Should_Have_Created_Valid_Instance()
            {
                Assert.NotNull(_sut);
            }
        }
    }
}