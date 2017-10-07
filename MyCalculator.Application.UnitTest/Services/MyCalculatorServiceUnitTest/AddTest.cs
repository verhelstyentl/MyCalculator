using TestSupport;
using Xunit;

namespace MyCalculator.Application.UnitTest.Services.MyCalculatorServiceUnitTest
{
    public static class AddTest
    {
        public class Given_Valid_Dependencies_When_Adding_Two_Numbers
            : BaseScenario.Given_Valid_Dependencies_And_Constructed_Instance_Scenario
        {
            private int _nr1;
            private int _nr2;
            private int _result;
            private int _expectedResult;

            protected override void Given()
            {
                base.Given();
                _nr1 = 1;
                _nr2 = 2;
                _expectedResult = 3;
            }

            protected override void When()
            {
                _result = Sut.Add(_nr1, _nr2);
            }

            [Fact]
            public void Then_It_Should_Return_The_Correct_Sum()
            {
                Assert.Equal(_expectedResult,_result);
            }
        }
    }
}