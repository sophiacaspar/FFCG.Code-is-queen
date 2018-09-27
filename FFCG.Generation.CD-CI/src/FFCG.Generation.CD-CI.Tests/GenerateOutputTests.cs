using System;
using Xunit;

namespace FFCG.Generation.CD_CI.Tests
{
    public class GenerateOutputTests
    {
        private GenerateOutput _generateOutput;

        public GenerateOutputTests()
        {
            _generateOutput = new GenerateOutput();
        }

        [Fact]
        public void Should_return_hello_world()
        {
            string initialOutput = _generateOutput.GetInitialOutput();
            Assert.Equal("Hello World", initialOutput);
        }

        [Fact]
        public void Should_return_personal_greeting()
        {
            string personalGreeting = _generateOutput.GetPersonalGreeting("Sophia");
            Assert.Equal("Hello Sophia!", personalGreeting);
        }
    }
}
