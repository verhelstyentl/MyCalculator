using MyCalculator.Application.Services;
using TestSupport;

namespace MyCalculator.Application.UnitTest.Services.MyCalculatorServiceUnitTest
{
    public static class BaseScenario
    {
        public abstract class Given_Valid_Dependencies_And_Constructed_Instance_Scenario
            : Given_When_Then_Test
        {
            protected MyCalculatorService Sut;

            protected override void Given()
            {
                Sut = new MyCalculatorService();
            }
        }
    }
}